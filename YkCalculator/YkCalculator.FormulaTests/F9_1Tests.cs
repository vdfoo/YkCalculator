﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F9_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7.8,
                Lebar = 105,
                Tinggi = 104,
                HargaHook = 0.1,
                Layout = "L",
            };

            IFormula formula = new F9_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 172.80);
            Assert.AreEqual(actual.HargaKainA, 142.80);
            Assert.AreEqual(actual.UpahKainA, 27.00);
            Assert.AreEqual(actual.UpahHook, 3.00);
            Assert.AreEqual(actual.Keping, 9);
            Assert.AreEqual(actual.KepingB, 6);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 9);
            Assert.AreEqual(actual.TailorMeterA, 2.92);
            Assert.AreEqual(actual.TailorKepingA, 6);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 3);
        }
    }
}