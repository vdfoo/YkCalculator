﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F82Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input();
            input.FormulaCode = "F82";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "1 Panel", "27'' x 60", 67));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "2 Panel", "51'' x 60", 77));
            input.ReadyMadeProduct.Add(new ReadyMadeProduct(string.Empty, "3 Panel", "75'' x 84", 97));

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            Output actual = new F82().Calculate(input);

            Assert.AreEqual(actual.Jumlah, 482);
        }
    }
}