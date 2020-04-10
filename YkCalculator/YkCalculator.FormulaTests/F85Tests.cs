using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F85Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F85";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("1 Panel", "27'' x 66", 61.70));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("2 Panel", "51'' x 66", 76.70));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("3 Panel", "75'' x 66", 96));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F85().Calculate(input);

            Assert.AreEqual(actual.Jumlah, 468.8);
        }
    }
}