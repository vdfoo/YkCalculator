using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F94_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            return CalculateRodWithInstallation(input);
        }
    }
}
