using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F93_2ProductCollection : ProductCollectionBase
    {
        public Product Initialize(Product p, bool initializeAccessories)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.1", "4", Constant.WithRing, 56.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.2", "4", Constant.WithoutRing, 52.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.3", "4.5", Constant.WithRing, 63.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.4", "4.5", Constant.WithoutRing, 58.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.5", "5", Constant.WithRing, 70.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.6", "5", Constant.WithoutRing, 65.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.7", "5.5", Constant.WithRing, 77.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.8", "5.5", Constant.WithoutRing, 71.50));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.9", "6", Constant.WithRing, 84));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.10", "6", Constant.WithoutRing, 78.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.11", "6.5", Constant.WithRing, 91.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.12", "6.5", Constant.WithoutRing, 84.5));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.13", "7", Constant.WithRing, 98.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.14", "7", Constant.WithoutRing, 91.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.15", "8", Constant.WithRing, 112.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.16", "8", Constant.WithoutRing, 104.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.17", "9", Constant.WithRing, 126.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.18", "9", Constant.WithoutRing, 117.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.19", "10", Constant.WithRing, 140.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.20", "10", Constant.WithoutRing, 130.00));

            if(initializeAccessories)
            {
                p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.21", Constant.EndCap, string.Empty, 6.50));
                p.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.22", Constant.Bracket, string.Empty, 8.00));
            }

            return p;
        }
    }
}
