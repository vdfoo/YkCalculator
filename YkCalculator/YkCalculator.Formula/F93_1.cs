using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F93_1 : FormulaBase
    {
        public RodSetOutput Calculate(RodSetInput input)
        {
            Product p = new Product(null, null, null, true);
            F93_1ProductCollection products = new F93_1ProductCollection();
            p = products.Initialize(p, true);
            ReadyMadeProduct bracket = p.ReadyMadeProduct.Find(x => x.Name == Constant.Bracket);
            ReadyMadeProduct endcap = p.ReadyMadeProduct.Find(x => x.Name == Constant.EndCap);

            RodSetOutput output = CalculateRod(input);
            output = CalculateEndcapBracket(output, 2, bracket, endcap);
            return output;
        }
    }
}
