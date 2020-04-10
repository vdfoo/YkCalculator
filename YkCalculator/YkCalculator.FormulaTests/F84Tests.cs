using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F84Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F84";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("1 Panel", "27'' x 78", 95));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("1 Panel", "27'' x 96", 95));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("2 Panel", "51'' x 78", 124));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("3 Panel", "75'' x 120", 144));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F84().Calculate(input);

            Assert.AreEqual(actual.Jumlah, 916);
        }
    }
}