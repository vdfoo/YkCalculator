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
            string hargaLabel = GetLabelByPropertyName(hargaName) + $"<br>RM {subtotalHarga} = ";
            string hargaWorking = $"{Math.Round(kainMeter, 4)} x RM {hargaPerUnit}";
            string hargaBreakdown = hargaLabel + hargaWorking + "<br><br>";
            return hargaBreakdown;
        }

        public string GetDetailBreakdown(Output result, params double[] args)
        {
            List<double> values = args.ToList();
            values.Add(result.RodSetTotal);
            values.Add(result.HargaHanger);

            string jumlahLabel = GetLabelByPropertyName(nameof(Output.Jumlah)) + $"<br>RM {result.Jumlah} = ";
            string jumlahBreakdown = string.Empty;

            foreach (var value in values)
            {
                if (value != 0)
                {
                    jumlahBreakdown += $"RM {Math.Round(value, 2)} + ";
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

        public RodSetOutput CalculateRod(RodSetInput rodSetInput)
        {
            Input input = new Input()
            {
                FormulaCode = rodSetInput.FormulaCode,
                ReadyMadeProduct = rodSetInput.ReadyMadeProduct
            };

            Output result = CalculateReadyMadeProduct(input);
            RodSetOutput rodSetOutput = new RodSetOutput()
            {
                ProductName = rodSetInput.ProductName,
                RodSetTotal = result.Jumlah,
                ReadyMadeProduct = result.ReadyMadeProduct,
            };

            rodSetOutput = CalculateRodSubtotal(rodSetOutput);
            return rodSetOutput;
        }

        public RodSetOutput CalculateRodSubtotal(RodSetOutput output)
        {
            if (output.ReadyMadeProduct.Count != 0)
            {
                foreach (ReadyMadeProduct product in output.ReadyMadeProduct)
                {
                    switch(product.Name)
                    {
                        case Constant.Bracket:
                            output.BracketSubtotal = product.Subtotal;
                            break;
                        case Constant.EndCap:
                            output.EndCapSubtotal = product.Subtotal;
                            break;
                        default:
                            output.RodQuantity += product.Quantity;
                            break;
                    }
                }

                output.RodSubtotal = output.RodSetTotal - output.BracketSubtotal - output.EndCapSubtotal - output.Transportation;
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
                    product.Subtotal = Math.Round(product.Price * product.Quantity, 2);
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
                ReadyMadeProduct = input.ReadyMadeProduct
            };
            
            if (input.ReadyMadeProduct.Count != 0)
            {
                result.ReadyMadeProduct = new List<ReadyMadeProduct>();

                foreach (ReadyMadeProduct product in input.ReadyMadeProduct)
                {
                    bool withRing = Transform.WithRing(product.Description);
                    double meter;
                    bool isMeter = double.TryParse(product.Name, out meter);
                    if(isMeter)
                    {
                        if (withRing)
                        {
                            product.Subtotal = Math.Round(meter * product.Quantity * 14, 2);
                        }
                        else
                        {
                            product.Subtotal = Math.Round(meter * product.Quantity * 13, 2);
                        }
                    }
                    else
                    {
                        product.Subtotal = Math.Round(product.Price * product.Quantity, 2);
                    }

                    result.ReadyMadeProduct.Add(product);
                    result.RodSetTotal += product.Subtotal;
                }

                result.Transportation = 100;
                result.RodSetTotal += result.Transportation;
            }
            
            return CalculateRodSubtotal(result);
        }
    }
}
