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

            // Endcap: 2 x 2 = 4
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.6", "5", Constant.WithoutRing, 65.00));

            // Endcap: 2 x 3 = 6
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.7", "6", Constant.WithRing, 84.00));

            // Endcap: 2 x 4 = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_2.19", "14", Constant.WithRing, 196.00));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F94_2().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 6); // 2 + 2 + 2
            Assert.AreEqual(actual.EndCapQuantity, 12);
            Assert.AreEqual(actual.EndCapSubtotal, 0); 
            Assert.AreEqual(actual.BracketQuantity, 18);
            Assert.AreEqual(actual.BracketSubtotal, 0); 
            Assert.AreEqual(actual.RodOnlySubtotal, 1380); //260 + 336 + 784
            Assert.AreEqual(actual.RodSetTotal, 1380); // 1380 + 156 + 288
        }
    }
}