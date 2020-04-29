using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class ReadyMadeProduct
    {
        public ReadyMadeProduct()
        {

        }
        public ReadyMadeProduct(string productId, string name, string description, double price)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
        }

        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Meter { get; set; }
        public double Subtotal { get; set; }
    }
}
