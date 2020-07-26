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

            //Rod: 2 (quantity), Endcap: 2 x 2 (quantity) = 4, Bracket: 2 x 2 (quantity) = 4
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.5", "5", Constant.WithRing, 41.50));

            //Rod: 2 (quantity), Endcap: 2 x 2 (quantity) = 4, Bracket: 3 x 2 (quantity) = 6
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.8", "6", Constant.WithoutRing, 46.80));

            //Rod: 2 (quantity), Endcap: 2 x 2 (quantity) = 4, Bracket: 4 x 2 (quantity) = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.19", "14", Constant.WithRing, 116.20));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F94_1().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 6); // 3 rod x 2 quantity
            Assert.AreEqual(actual.BracketQuantity, 18); // 4 + 6 + 8
            Assert.AreEqual(actual.BracketSubtotal, 0); 
            Assert.AreEqual(actual.EndCapQuantity, 12); //4 + 4 + 4
            Assert.AreEqual(actual.EndCapSubtotal, 0); 
            Assert.AreEqual(actual.RodOnlySubtotal, 818); // 166 + 187.2 + 464.8
            Assert.AreEqual(actual.RodSetTotal, 818); //818 + 288 + 156
        }
    }
}