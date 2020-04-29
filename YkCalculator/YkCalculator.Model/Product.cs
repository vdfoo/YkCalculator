using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class Product
    {
        public Product(string formulaCode, string name, string imagePath, bool readyMadeProduct = false)
        {
            FormulaCode = formulaCode;
            Name = name;
            ImagePath = imagePath;

            if(readyMadeProduct)
            {
                ReadyMadeProduct = new List<ReadyMadeProduct>();
            }
            else
            {
                Field = new InputField();
            }
            
        }

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string FormulaCode { get; set; }
        public InputField Field { get; set; }
        public List<ReadyMadeProduct> ReadyMadeProduct { get; set; }

    }
}
