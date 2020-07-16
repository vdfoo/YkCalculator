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
    public class F93_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F93_1";
            input.Set = 2;
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            //Price: 31.20, Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 2 x 2 (quantity) x 2 (set) = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.2", "4", Constant.WithoutRing, 31.20));

            //Price: 58.10, Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 3 x 2 (quantity) x 2 (set) = 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.13", "7", Constant.WithRing, 58.10));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F93_1().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 8); // 2 rod x 2 quantity x 2 set
            Assert.AreEqual(actual.BracketQuantity, 20);
            Assert.AreEqual(actual.BracketSubtotal, 160); //Price: 8/unit
            Assert.AreEqual(actual.EndCapQuantity, 16);
            Assert.AreEqual(actual.EndCapSubtotal, 104); //Price: 6.5/unit
            Assert.AreEqual(actual.RodOnlySubtotal, 357.2);
            Assert.AreEqual(actual.RodSetTotal, 621.2);
        }
    }
}