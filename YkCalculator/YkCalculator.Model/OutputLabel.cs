using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class OutputLabel
    {
        public OutputLabel(string formulaCode)
        {
            FormulaCode = formulaCode;
            Fields = new Dictionary<string, string>();
        }
        public string FormulaCode { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }
}
