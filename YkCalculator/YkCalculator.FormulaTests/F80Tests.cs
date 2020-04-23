using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using System.Text.Json;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F80Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F80";

            ReadyMadeProduct p1 = new ReadyMadeProduct(string.Empty, "1 Panel Bunga", "27'' x 84", 125);
            p1.Quantity = 2;

            ReadyMadeProduct p2 = new ReadyMadeProduct(string.Empty, "1 Panel Kosong", "27'' x 96", 125);
            p2.Quantity = 2;

            ReadyMadeProduct p3 = new ReadyMadeProduct(string.Empty, "2 Panel", "51'' x 84", 175);
            p3.Quantity = 2;

            ReadyMadeProduct p4 = new ReadyMadeProduct(string.Empty, "3 Panel", "75'' x 84", 235);
            p4.Quantity = 2;

            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            input.ReadyMadeProduct.Add(p1);
            input.ReadyMadeProduct.Add(p2);
            input.ReadyMadeProduct.Add(p3);
            input.ReadyMadeProduct.Add(p4);

            IFormula formula = new F80();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 1320);
        }
    }
}
