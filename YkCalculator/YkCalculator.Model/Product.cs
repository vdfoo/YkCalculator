using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string FormulaCode { get; set; }
        public List<Field> Field { get; set; }
    }
}
