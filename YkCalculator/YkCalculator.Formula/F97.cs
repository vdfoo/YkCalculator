using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F97 : FormulaBase
    {
        public RodSetOutput Calculate(RodSetInput input)
        {
            RodSetOutput result = new RodSetOutput();

            if (input.ReadyMadeProduct != null && input.ReadyMadeProduct.Count != 0)
            {
                result.ReadyMadeProduct = new List<ReadyMadeProduct>();

                ReadyMadeProduct product1 = input.ReadyMadeProduct[0];
                product1.Subtotal = Math.Round(product1.Quantity * product1.Meter * 13, 2);
                result.ReadyMadeProduct.Add(product1);

                ReadyMadeProduct product2 = input.ReadyMadeProduct[1];
                product2.Subtotal = Math.Round(product2.Quantity * product2.Meter * 10, 2);
                result.ReadyMadeProduct.Add(product2);

                result.RodSubtotal = Math.Round(product1.Subtotal + product2.Subtotal, 2);

                //result.Transportation = 100;
                result.RodSetTotal = result.RodSubtotal;// + result.Transportation;
            }

            return result;
        }
    }
}
