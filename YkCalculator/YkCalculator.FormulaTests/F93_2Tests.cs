﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F93_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F93_2";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.19", "10", Constant.WithRing, 83.00)); //280
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.20", "10", Constant.WithoutRing, 78.00)); //260
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.21", Constant.EndCap, string.Empty, 6.00)); //12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.22", Constant.Bracket, string.Empty, 7.50)); //15

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F93_2().Calculate(input);

            Assert.AreEqual(actual.Transportation, 100);
            Assert.AreEqual(actual.RodQuantity, 4);
            Assert.AreEqual(actual.BracketSubtotal, 15);
            Assert.AreEqual(actual.EndCapSubtotal, 12);
            Assert.AreEqual(actual.RodSubtotal, 540);
            Assert.AreEqual(actual.Jumlah, 667);
        }
    }
}