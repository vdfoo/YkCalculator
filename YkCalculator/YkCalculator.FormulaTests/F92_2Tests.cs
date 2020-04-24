using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F92_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F92_2";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.3", "4", Constant.WithRing, 32.00)); // 112
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.12", "6", Constant.WithoutRing, 45.00)); // 156
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.27", Constant.EndCap, string.Empty, 6.00)); // 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.28", Constant.Bracket, string.Empty, 7.50)); // 15

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F92_2().Calculate(input);

            Assert.AreEqual(actual.Transportation, 100);
            Assert.AreEqual(actual.RodQuantity, 4);
            Assert.AreEqual(actual.BracketSubtotal, 15);
            Assert.AreEqual(actual.EndCapSubtotal, 12);
            Assert.AreEqual(actual.RodSubtotal, 268);
            Assert.AreEqual(actual.RodSetTotal, 395);
        }
    }
}