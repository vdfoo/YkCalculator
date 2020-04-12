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

            Fields.Add("formulaCode", "Kod");
            Fields.Add("jumlah", "Jumlah");
        }
        public string FormulaCode { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }
}
