using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F81Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F81";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "1 Panel", "60'' x 84", 130));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "2 Panel", "72'' x 84", 150));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "3 Panel", "84'' x 84", 170));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "4 Panel", "96'' x 84", 190));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;
            
            Output actual = new F81().Calculate(input);

            Assert.AreEqual(actual.Jumlah, 1280);
        }
    }
}