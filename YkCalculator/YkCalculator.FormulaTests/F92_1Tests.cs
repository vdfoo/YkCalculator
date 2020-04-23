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
    public class F92_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F92_1";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.4", "4", Constant.WithoutRing, 30.00)); //60
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.7", "5", Constant.WithRing, 40.00)); //80
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.27", Constant.EndCap, string.Empty, 6.00)); //12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.28", Constant.Bracket, string.Empty, 7.50)); //15

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F92_1().Calculate(input);

            Assert.AreEqual(actual.BracketSubtotal, 15);
            Assert.AreEqual(actual.EndCapSubtotal, 12);
            Assert.AreEqual(actual.RodSubtotal, 140);
            Assert.AreEqual(actual.Jumlah, 167);
        }
    }
}