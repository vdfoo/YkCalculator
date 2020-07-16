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
    public class F94_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F94_1";
            input.Set = 2;
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            //Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 2 x 2 (quantity) x 2 (set) = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.5", "5", Constant.WithRing, 41.50));

            //Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 3 x 2 (quantity) x 2 (set) = 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.8", "6", Constant.WithoutRing, 46.80));

            //Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 4 x 2 (quantity) x 2 (set) = 16
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.19", "14", Constant.WithRing, 116.20));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F94_1().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 12); // 3 rod x 2 quantity x 2 set
            Assert.AreEqual(actual.BracketQuantity, 36); // 8 + 12 + 16
            Assert.AreEqual(actual.BracketSubtotal, 288); //Price: 8/unit
            Assert.AreEqual(actual.EndCapQuantity, 24);
            Assert.AreEqual(actual.EndCapSubtotal, 156); //Price: 6.5/unit
            Assert.AreEqual(actual.RodOnlySubtotal, 818); // 166 + 187.2 + 464.8
            Assert.AreEqual(actual.RodSetTotal, 1262); //818 + 288 + 156
        }
    }
}