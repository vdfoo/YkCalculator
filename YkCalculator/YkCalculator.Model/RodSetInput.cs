using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class RodSetInput
    {
        public string FormulaCode { get; set; }
        public string ProductName { get; set; }
        public List<ReadyMadeProduct> ReadyMadeProduct { get; set; }
        public int Set { get; set; }
    }
}
