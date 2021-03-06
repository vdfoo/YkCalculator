﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F19_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7,
                Lebar = 120,
                Tinggi = 104,
                Layout = "L",
            };

            IFormula formula = new F19_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 252.56);
            Assert.AreEqual(actual.HargaKainA, 222.56);
            Assert.AreEqual(actual.UpahKainA, 30);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorKeping, 10);
            Assert.AreEqual(actual.TailorKepingA, 10);
            Assert.AreEqual(actual.TailorMeterA, 3.05);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 5);

        }
    }
}