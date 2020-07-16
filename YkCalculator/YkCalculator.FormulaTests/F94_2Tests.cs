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
    public class F94_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F94_2";
            input.Set = 2;
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            // 2 x 2 x 2 = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.6", "5", Constant.WithoutRing, 65.00));

            // 2 x 2 x 3 = 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.7", "6", Constant.WithRing, 84.00));

            // 2 x 2 x 4 = 16
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.19", "14", Constant.WithRing, 196.00));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F94_2().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 12); // 4 + 4 + 4
            Assert.AreEqual(actual.EndCapQuantity, 24);
            Assert.AreEqual(actual.EndCapSubtotal, 156); // Price: 6.5/unit
            Assert.AreEqual(actual.BracketQuantity, 36);
            Assert.AreEqual(actual.BracketSubtotal, 288); // Price: 8/unit
            Assert.AreEqual(actual.RodOnlySubtotal, 1380); //260 + 336 + 784
            Assert.AreEqual(actual.RodSetTotal, 1824); // 1380 + 156 + 288
        }
    }
}