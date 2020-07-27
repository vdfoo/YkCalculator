using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YkCalculator.DAL;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class FormulaBase
    {
        public int StoreCalculation(Output output)
        {
            QuotationDal dal = new QuotationDal();
            int id = dal.Insert(output);
            return id;
        }

        public string GetHargaBreakdown(string hargaName, double kainMeter, double hargaPerUnit, double subtotalHarga)
        {
            string hargaLabel = GetLabelByPropertyName(hargaName) + $"<br>RM {subtotalHarga.ToString("0.00")} = ";
            string hargaWorking = $"{Math.Round(kainMeter, 2).ToString("0.00")} m x RM {hargaPerUnit.ToString("0.00")}";
            string hargaBreakdown = hargaLabel + hargaWorking + "<br><br>";
            return hargaBreakdown;
        }
        public string GetKainABreakdown(double hargaSubtotal, string hargaName, params double[] args)
        {
            string hargaLabel = GetLabelByPropertyName(hargaName) + $"<br>RM {hargaSubtotal} = ";
            string hargaBreakdown = string.Empty;

            foreach (var value in args)
            {
                if (value != 0)
                {
                    hargaBreakdown += $"RM {Math.Round(value, 2).ToString("0.00")} + ";
                }
            }

            hargaBreakdown = hargaBreakdown.TrimEnd(' ', '+');
            string detailBreakdown = hargaLabel + hargaBreakdown + "<br><br>";
            return detailBreakdown;
        }

        public string GetDetailBreakdown(Output result, params double[] args)
        {
            List<double> values = args.ToList();
            values.Add(result.RodSetTotal);
            values.Add(result.HargaHanger);

            string jumlahLabel = GetLabelByPropertyName(nameof(Output.Jumlah)) + $"<br>RM {Math.Round(result.Jumlah, 2).ToString("0.00")} = ";
            string jumlahBreakdown = string.Empty;

            foreach (var value in values)
            {
                if (value != 0)
                {
                    jumlahBreakdown += $"RM {Math.Round(value, 2).ToString("0.00")} + ";
                }
            }

            jumlahBreakdown = jumlahBreakdown.TrimEnd(' ', '+');
            string detailBreakdown = jumlahLabel + jumlahBreakdown;
            return detailBreakdown;
        }

        public string GetLabelByPropertyName(string propertyName)
        {
            OutputLabelCollection collection = new OutputLabelCollection();
            string label = string.Empty;
            collection.Formula[0].Fields.TryGetValue(Transform.ToJsonProperty(propertyName), out label);
            return label;
        }

        public void AddOptionalItemsToJumlah(Input input, Output result)
        {
            if (input.RodSetOutput != null)
            {
                result.RodSetTotal = Math.Round(input.RodSetOutput.RodSetTotal * input.Set, 2);
                result.Jumlah = Math.Round(result.Jumlah + result.RodSetTotal, 2);
            }

            if (input.Hanger)
            {
                result.HargaHanger = Math.Round(2.80 * input.Set, 2);
                result.Jumlah = Math.Round(result.Jumlah + result.HargaHanger, 2);
            }
        }

        public void AddSecondRodsetOutputToJumlah(Input input, Output result)
        {
            if (input.RodSetOutput2 != null)
            {
                result.RodSetTotal2 = Math.Round(input.RodSetOutput2.RodSetTotal * input.Set, 2);
                result.Jumlah = Math.Round(result.Jumlah + result.RodSetTotal2, 2);
            }
        }

        public RodSetOutput CalculateRod(RodSetInput rodSetInput)
        {
            Input input = new Input()
            {
                FormulaCode = rodSetInput.FormulaCode,
                ReadyMadeProduct = rodSetInput.ReadyMadeProduct,
                Set = rodSetInput.Set,
            };

            Output result = CalculateReadyMadeProduct(input);
            RodSetOutput rodSetOutput = new RodSetOutput()
            {
                ProductName = rodSetInput.ProductName,
                RodOnlySubtotal = result.Jumlah,
                ReadyMadeProduct = result.ReadyMadeProduct,
                Set = rodSetInput.Set
            };

            rodSetOutput = CalculateRodQuantity(rodSetOutput);
            return rodSetOutput;
        }

        public RodSetOutput CalculateEndcapBracket(RodSetOutput output, int option, ReadyMadeProduct bracket, ReadyMadeProduct endcap)
        {
            output.EndCapQuantity = output.RodQuantity * 2; // no need multiply by Set here because RodQuantity already calculated with Set
            foreach (ReadyMadeProduct product in output.ReadyMadeProduct)
            {
                double meter;
                bool isMeter = double.TryParse(product.Name, out meter);
                if(isMeter)
                {
                    if (option == 1)
                    {
                        if(meter <= 6.5)
                        {
                            output.BracketQuantity += product.Quantity * 2;
                        }
                        else if (meter <= 12)
                        {
                            output.BracketQuantity += product.Quantity * 3;
                        }
                        else if(meter <= 14)
                        {
                            output.BracketQuantity += product.Quantity * 4;
                        }
                    }
                    else if (option == 2)
                    {
                        if (meter <= 6.5)
                        {
                            output.BracketQuantity += product.Quantity * 2;
                        }
                        else if (meter <= 10)
                        {
                            output.BracketQuantity += product.Quantity * 3;
                        }
                    }
                    else if (option == 3)
                    {
                        if (meter <= 5)
                        {
                            output.BracketQuantity += product.Quantity * 2;
                        }
                        else if (meter <= 12)
                        {
                            output.BracketQuantity += product.Quantity * 3;
                        }
                        else if (meter <= 14)
                        {
                            output.BracketQuantity += product.Quantity * 4;
                        }
                    }
                }
                else if(product.Name == Constant.Bracket)
                {
                    output.BracketQuantity += product.Quantity;
                }
                else if (product.Name == Constant.EndCap)
                {
                    output.EndCapQuantity += product.Quantity;
                }
            }

            //bracket.Subtotal = output.BracketQuantity * bracket.Price;
            //endcap.Subtotal = output.EndCapQuantity * endcap.Price;
            //output.ReadyMadeProduct.Add(bracket);
            //output.ReadyMadeProduct.Add(endcap);
            //output.BracketSubtotal = bracket.Subtotal;
            //output.EndCapSubtotal = endcap.Subtotal;
            output.RodSetTotal = output.RodOnlySubtotal;// + output.BracketSubtotal + output.EndCapSubtotal;
            return output;
        }

        public RodSetOutput CalculateRodQuantity(RodSetOutput output)
        {
            if (output.ReadyMadeProduct.Count != 0)
            {
                foreach (ReadyMadeProduct product in output.ReadyMadeProduct)
                {
                    // Only count quantity if they are not bracket or endcap
                    if (product.Name == Constant.Bracket || product.Name == Constant.EndCap) continue;

                    output.RodQuantity += product.Quantity;
                }
            }

            return output;
        }

        public Output CalculateReadyMadeProduct(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            if (input.ReadyMadeProduct.Count != 0)
            {
                result.ReadyMadeProduct = new List<ReadyMadeProduct>();

                foreach (ReadyMadeProduct product in input.ReadyMadeProduct)
                {
                    if (input.Set == 0) input.Set = 1;

                    product.Subtotal = Math.Round(product.Price * product.Quantity * input.Set, 2);
                    result.ReadyMadeProduct.Add(product);
                    result.Jumlah += product.Subtotal;
                }
            }

            return result;
        }

        public RodSetOutput CalculateRodWithInstallation(RodSetInput input)
        {
            RodSetOutput result = new RodSetOutput()
            {
                ProductName = input.ProductName,
                ReadyMadeProduct = input.ReadyMadeProduct,
                Set = input.Set
            };
            
            if (input.ReadyMadeProduct.Count != 0)
            {
                result.ReadyMadeProduct = new List<ReadyMadeProduct>();
                if (input.Set == 0) input.Set = 1;

                foreach (ReadyMadeProduct product in input.ReadyMadeProduct)
                {
                    product.Subtotal = Math.Round(product.Price * product.Quantity * input.Set, 2);
                    result.ReadyMadeProduct.Add(product);
                    result.RodOnlySubtotal += product.Subtotal;
                }
            }
            
            return CalculateRodQuantity(result);
        }
    }
}
