using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class FormulaManager
    {
        public Output Identify(Input input)
        {
            Output result = new Output();
            switch (input.FormulaCode)
            {
                case "F1_1":
                    F1_1 formula = new F1_1();
                    result = formula.Calculate(input);
                    break;
                default:
                    throw new NotImplementedException($"No implementation for formula {input.FormulaCode}");
            }

            return result; 
        }
    }
}
