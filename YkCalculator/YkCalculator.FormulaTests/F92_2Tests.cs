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
            input.Set = 2;
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            //Bracket: 2 x 2 x 2 = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.14", "6.5", Constant.WithoutRing, 84.50));

            //Bracket: 2 x 2 x 3 = 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.15", "7", Constant.WithRing, 98.00));

            //Bracket: 2 x 2 x 4 = 16
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_2.25", "14", Constant.WithRing, 196.00));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F92_2().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 12); // 4 + 4 + 4
            Assert.AreEqual(actual.EndCapQuantity, 24);
            Assert.AreEqual(actual.EndCapSubtotal, 144); //Price: 6/unit
            Assert.AreEqual(actual.BracketQuantity, 36);
            Assert.AreEqual(actual.BracketSubtotal, 270); //Price: 7.5/unit
            Assert.AreEqual(actual.RodOnlySubtotal, 1514); // 338 + 392 + 784
            Assert.AreEqual(actual.RodSetTotal, 1928); //1514 + 144 + 270
        }
    }
}