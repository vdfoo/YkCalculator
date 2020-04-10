using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F83Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F83";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("1 Panel", "27'' x 78", 72));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("1 Panel", "27'' x 96", 82));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("1 Panel", "27'' x 120", 108));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("2 Panel", "51'' x 78", 102));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("2 Panel", "51'' x 120", 158));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("3 Panel", "75'' x 78", 125));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("3 Panel", "75'' x 120", 208));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F83().Calculate(input);

            Assert.AreEqual(actual.Jumlah, 1710);
        }
    }
}