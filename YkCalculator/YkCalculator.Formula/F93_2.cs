using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F93_2 : FormulaBase
    {
        public RodSetOutput Calculate(RodSetInput input)
        {
            Product p = new Product(null, null, null, true);
            F93_2ProductCollection products = new F93_2ProductCollection();
            p = products.Initialize(p, true);
            ReadyMadeProduct bracket = p.ReadyMadeProduct.Find(x => x.Name == Constant.Bracket);
            ReadyMadeProduct endcap = p.ReadyMadeProduct.Find(x => x.Name == Constant.EndCap);

            RodSetOutput output = CalculateRodWithInstallation(input);
            output = CalculateEndcapBracket(output, 2, bracket, endcap);
            return output;
        }
    }
}
