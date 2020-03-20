using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Product
    {
        public Product(string formulaCode, string name, string imagePath)
        {
            FormulaCode = formulaCode;
            Name = name;
            ImagePath = imagePath;
            Field = new InputField();
        }

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string FormulaCode { get; set; }
        public InputField Field { get; set; }
    }
}
