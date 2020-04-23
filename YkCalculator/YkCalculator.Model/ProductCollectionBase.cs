using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class ProductCollectionBase
    {
        public Product CleanUpPrice(Product p)
        {
            foreach (var readyMadeProduct in p.ReadyMadeProduct)
            {
                bool meterProduct = double.TryParse(readyMadeProduct.Name, out var a);
                if(meterProduct)
                    readyMadeProduct.Price = 0;
            }

            return p;
        }
    }
}
