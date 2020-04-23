using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class F92ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.1", "3.5", "with ring", 28.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.2", "3.5", "without ring", 27.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.3", "4", "with ring", 32.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.4", "4", "without ring", 30.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.5", "4.5", "with ring", 36.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.6", "4.5", "without ring", 33.75));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.7", "5", "with ring", 40.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.8", "5", "without ring", 37.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.9", "5.5", "with ring", 44.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.10", "5.5", "without ring", 41.25));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.11", "6", "with ring", 48.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.12", "6", "without ring", 45.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.13", "6.5", "with ring", 52.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.14", "6.5", "without ring", 48.75));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.15", "7", "with ring", 56.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.16", "7", "without ring", 52.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.17", "8", "with ring", 64.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.18", "8", "without ring", 60.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.19", "9", "with ring", 72.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.20", "9", "without ring", 67.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.21", "10", "with ring", 80.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.22", "10", "without ring", 75.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.23", "12", "with ring", 101.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.24", "12", "without ring", 95.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.25", "14", "with ring", 117.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.26", "14", "without ring", 110.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.27", "End Cap (pc)", string.Empty, 6.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.28", "Bracket (pc)", string.Empty, 7.50));

            return p;
        }

        
    }
}
