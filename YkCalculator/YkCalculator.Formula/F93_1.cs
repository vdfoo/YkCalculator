﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F93_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            return CalculateRod(input);
        }
    }
}