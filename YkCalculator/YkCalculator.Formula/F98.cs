using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F98 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            return CalculateReadyMadeProduct(input);
        }
    }
}
