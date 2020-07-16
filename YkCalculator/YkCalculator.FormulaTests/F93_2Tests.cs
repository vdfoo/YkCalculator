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
    public class F93_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F93_2";
            input.Set = 2;
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            //Bracket: 2 x 2 x 2 = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.12", "6.5", Constant.WithoutRing, 84.5));

            //Bracket: 2 x 2 x 3 = 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_2.13", "7", Constant.WithRing, 98.00));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F93_2().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 8); // 4 + 4
            Assert.AreEqual(actual.EndCapQuantity, 16);
            Assert.AreEqual(actual.EndCapSubtotal, 104); // Price: 6.5/unit
            Assert.AreEqual(actual.BracketQuantity, 20);
            Assert.AreEqual(actual.BracketSubtotal, 160); // Price: 8/unit
            Assert.AreEqual(actual.RodOnlySubtotal, 730); //338 + 392
            Assert.AreEqual(actual.RodSetTotal, 994); // 730 + 104 + 160
        }
    }
}