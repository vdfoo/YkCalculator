using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F92_1ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.1", "3.5", Constant.WithRing, 28.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.2", "3.5", Constant.WithoutRing, 27.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.3", "4", Constant.WithRing, 32.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.4", "4", Constant.WithoutRing, 30.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.5", "4.5", Constant.WithRing, 36.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.6", "4.5", Constant.WithoutRing, 33.75));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.7", "5", Constant.WithRing, 40.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.8", "5", Constant.WithoutRing, 37.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.9", "5.5", Constant.WithRing, 44.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.10", "5.5", Constant.WithoutRing, 41.25));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.11", "6", Constant.WithRing, 48.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.12", "6", Constant.WithoutRing, 45.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.13", "6.5", Constant.WithRing, 52.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.14", "6.5", Constant.WithoutRing, 48.75));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.15", "7", Constant.WithRing, 56.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.16", "7", Constant.WithoutRing, 52.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.17", "8", Constant.WithRing, 64.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.18", "8", Constant.WithoutRing, 60.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.19", "9", Constant.WithRing, 72.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.20", "9", Constant.WithoutRing, 67.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.21", "10", Constant.WithRing, 80.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.22", "10", Constant.WithoutRing, 75.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.23", "12", Constant.WithRing, 101.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.24", "12", Constant.WithoutRing, 95.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.25", "14", Constant.WithRing, 117.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.26", "14", Constant.WithoutRing, 110.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.27", Constant.EndCap, string.Empty, 6.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.28", Constant.Bracket, string.Empty, 7.50));

            return p;
        }
    }
}
