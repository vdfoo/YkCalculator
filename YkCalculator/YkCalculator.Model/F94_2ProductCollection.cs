using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F94_2ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.1", "3", Constant.WithRing, 42.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.2", "3", Constant.WithoutRing, 39.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.3", "4", Constant.WithRing, 56.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.4", "4", Constant.WithoutRing, 52.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.5", "5", Constant.WithRing, 70.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.6", "5", Constant.WithoutRing, 65.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.7", "6", Constant.WithRing, 84.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.8", "6", Constant.WithoutRing, 78.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.9", "7", Constant.WithRing, 98.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.10", "7", Constant.WithoutRing, 91.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.11", "8", Constant.WithRing, 112.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.12", "8", Constant.WithoutRing, 104.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.13", "9", Constant.WithRing, 126.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.14", "9", Constant.WithoutRing, 117.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.15", "10", Constant.WithRing, 140.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.16", "10", Constant.WithoutRing, 130.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.17", "12", Constant.WithRing, 168.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.18", "12", Constant.WithoutRing, 156.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.19", "14", Constant.WithRing, 196.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.20", "14", Constant.WithoutRing, 182.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.21", Constant.EndCap, string.Empty, 6.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.22", Constant.Bracket, string.Empty, 8.00));

            return p;
        }
    }
}
