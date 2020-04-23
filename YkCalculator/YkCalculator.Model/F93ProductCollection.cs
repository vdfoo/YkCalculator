using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F93ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.1", "4", Constant.WithRing, 33.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.2", "4", Constant.WithoutRing, 31.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.3", "4.5", Constant.WithRing, 37.35));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.4", "4.5", Constant.WithoutRing, 35.10));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.5", "5", Constant.WithRing, 41.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.6", "5", Constant.WithoutRing, 39.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.7", "5.5", Constant.WithRing, 45.65));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.8", "5.5", Constant.WithoutRing, 42.90));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.9", "6", Constant.WithRing, 49.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.10", "6", Constant.WithoutRing, 46.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.11", "6.5", Constant.WithRing, 53.95));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.12", "6.5", Constant.WithoutRing, 50.70));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.13", "7", Constant.WithRing, 58.10));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.14", "7", Constant.WithoutRing, 54.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.15", "8", Constant.WithRing, 66.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.16", "8", Constant.WithoutRing, 62.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.17", "9", Constant.WithRing, 74.70));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.18", "9", Constant.WithoutRing, 70.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.19", "10", Constant.WithRing, 83.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.20", "10", Constant.WithoutRing, 78.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.21", Constant.EndCap, string.Empty, 6.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.22", Constant.Bracket, string.Empty, 7.50));

            return p;
        }
    }
}
