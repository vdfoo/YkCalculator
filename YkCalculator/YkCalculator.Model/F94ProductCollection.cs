using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F94ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.1", "3", Constant.WithRing, 27.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.2", "3", Constant.WithoutRing, 26.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.3", "4", Constant.WithRing, 33.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.4", "4", Constant.WithoutRing, 31.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.5", "5", Constant.WithRing, 41.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.6", "5", Constant.WithoutRing, 39.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.7", "6", Constant.WithRing, 49.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.8", "6", Constant.WithoutRing, 46.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.9", "7", Constant.WithRing, 58.10));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.10", "7", Constant.WithoutRing, 54.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.11", "8", Constant.WithRing, 66.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.12", "8", Constant.WithoutRing, 62.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.13", "9", Constant.WithRing, 74.70));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.14", "9", Constant.WithoutRing, 70.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.15", "10", Constant.WithRing, 83.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.16", "10", Constant.WithoutRing, 78.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.17", "12", Constant.WithRing, 99.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.18", "12", Constant.WithoutRing, 93.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.19", "14", Constant.WithRing, 116.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.20", "14", Constant.WithoutRing, 109.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.21", Constant.EndCap, string.Empty, 6.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.22", Constant.Bracket, string.Empty, 8.00));

            return p;
        }
    }
}
