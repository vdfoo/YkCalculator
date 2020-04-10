using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YkCalculator.Logic;
using YkCalculator.Model;

namespace YkCalculator
{
    public class F81 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            return CalculateReadyMadeProduct(input);
        }
    }
}
