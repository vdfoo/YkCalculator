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

        public Output CalculateRodWithInstallation(Input input)
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
                    result.Jumlah += product.Subtotal;
                }

                result.Transportation = 100;
                result.Jumlah += result.Transportation;
            }

            return result;
        }
    }
}
