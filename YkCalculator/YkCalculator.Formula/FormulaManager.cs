﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class FormulaManager
    {
        public Output Identify(Input input)
        {
            Output result;
            IFormula formula;
            switch (input.FormulaCode)
            {
                case "F1_1":
                    formula = new F1_1();
                    break;
                case "F1_2":
                    formula = new F1_2();
                    break;
                case "F3_1":
                    formula = new F3_1();
                    break;
                case "F3_2":
                    formula = new F3_2();
                    break;
                default:
                    throw new NotImplementedException($"No implementation for formula {input.FormulaCode}");
            }

            result = formula.Calculate(input);
            return result; 
        }
    }
}
