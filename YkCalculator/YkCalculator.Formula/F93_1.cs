using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F93_1 : FormulaBase
    {
        public RodSetOutput Calculate(RodSetInput input)
        {
            return CalculateRod(input);
        }
    }
}
