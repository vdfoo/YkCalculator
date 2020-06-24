using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F92_2ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.1", "3.5", Constant.WithRing, 49.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.2", "3.5", Constant.WithoutRing, 45.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.3", "4", Constant.WithRing, 56.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.4", "4", Constant.WithoutRing, 52.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.5", "4.5", Constant.WithRing, 63.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.6", "4.5", Constant.WithoutRing, 58.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.7", "5", Constant.WithRing, 70.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.8", "5", Constant.WithoutRing, 65.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.9", "5.5", Constant.WithRing, 77.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.10", "5.5", Constant.WithoutRing, 71.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.11", "6", Constant.WithRing, 84.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.12", "6", Constant.WithoutRing, 78.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.13", "6.5", Constant.WithRing, 91.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.14", "6.5", Constant.WithoutRing, 84.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.15", "7", Constant.WithRing, 98.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.16", "7", Constant.WithoutRing, 91.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.17", "8", Constant.WithRing, 112.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.18", "8", Constant.WithoutRing, 104.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.19", "9", Constant.WithRing, 126.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.20", "9", Constant.WithoutRing, 117.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.21", "10", Constant.WithRing, 140.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.22", "10", Constant.WithoutRing, 130.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.23", "12", Constant.WithRing, 168.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.24", "12", Constant.WithoutRing, 156.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.25", "14", Constant.WithRing, 196.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.26", "14", Constant.WithoutRing, 182.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.27", Constant.EndCap, string.Empty, 6.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.28", Constant.Bracket, string.Empty, 7.50));

            return p;
        }
    }
}
