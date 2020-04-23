using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F92_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F92_2";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.3", "4", "with ring", 32.00)); //112
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.12", "6", "without ring", 45.00)); //156
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.27", "End Cap (pc)", string.Empty, 6.00)); //12

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F92_2().Calculate(input);

            Assert.AreEqual(actual.Transportation, 100);
            Assert.AreEqual(actual.Jumlah, 380);
        }
    }
}