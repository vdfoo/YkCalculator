using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F92_2 : FormulaBase
    {
        public RodSetOutput Calculate(RodSetInput input)
        {
            return CalculateRodWithInstallation(input);
        }
    }
}
