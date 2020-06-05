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
            input.FormulaCode = "F94_1";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.1", "3", Constant.WithRing, 27.00)); //84
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F94_1.2", "3", Constant.WithoutRing, 26.00)); //78
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.21", Constant.EndCap, string.Empty, 6.50)); //13
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F93_1.22", Constant.Bracket, string.Empty, 8.00)); //16

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F94_2().Calculate(input);

            //Assert.AreEqual(actual.Transportation, 100);
            Assert.AreEqual(actual.RodQuantity, 4);
            Assert.AreEqual(actual.BracketSubtotal, 16);
            Assert.AreEqual(actual.EndCapSubtotal, 13);
            Assert.AreEqual(actual.RodSubtotal, 162);
            Assert.AreEqual(actual.RodSetTotal, 191);
        }
    }
}