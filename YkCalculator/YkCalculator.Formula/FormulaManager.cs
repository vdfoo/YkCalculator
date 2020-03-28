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
            Output result;
            IFormula formula;
            switch (input.FormulaCode)
            {
                case "F1_1":
                    formula = new F1_1(); break;
                case "F1_2":
                    formula = new F1_2(); break;
                case "F3_1":
                    formula = new F3_1(); break;
                case "F3_2":
                    formula = new F3_2(); break;
                case "F3_3":
                    formula = new F3_3(); break;
                case "F3_4":
                    formula = new F3_4(); break;
                case "F5_1":
                    formula = new F5_1(); break;
                case "F5_2":
                    formula = new F5_2(); break;
                case "F7_1":
                    formula = new F7_1(); break;
                case "F7_2":
                    formula = new F7_2(); break;
                case "F9_1":
                    formula = new F9_1(); break;
                case "F9_2": 
                    formula = new F9_2(); break;
                case "F11_1":
                    formula = new F11_1(); break;
                case "F11_2":
                    formula = new F11_2(); break;
                case "F13_1":
                    formula = new F13_1(); break;
                case "F13_2":
                    formula = new F13_2(); break;
                case "F15_1":
                    formula = new F15_1(); break;
                case "F15_2":
                    formula = new F15_2(); break;
                case "F17_1":
                    formula = new F17_1(); break;
                case "F17_2":
                    formula = new F17_2(); break;
                case "F17_3":
                    formula = new F17_3(); break;
                case "F19_1":
                    formula = new F19_1(); break;
                case "F19_2":
                    formula = new F19_2(); break;
                case "F21_1":
                    formula = new F21_1(); break;
                case "F21_2":
                    formula = new F21_2(); break;
                case "F23_1":
                    formula = new F23_1(); break;
                case "F25_1":
                    formula = new F25_1(); break;
                case "F25_2":
                    formula = new F25_2(); break;
                default:
                    throw new NotImplementedException($"No implementation for formula {input.FormulaCode}");
            }

            result = formula.Calculate(input);
            return result; 
        }
    }
}
