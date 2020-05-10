using System;
using System.Collections.Generic;
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

            //result.Jumlah = Math.Ceiling(result.Jumlah * 20) / 20;
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
