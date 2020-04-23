using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

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
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.1", "3.5", "with ring", 28.80));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.5", "4.5", "with ring", 36.00));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F92_1().Calculate(input);

            Assert.AreEqual(actual.Transportation, 100);
            Assert.AreEqual(actual.Jumlah, 229.6);
        }
    }
}