﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F25_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.9,
                HargaKainB = 18.8,
                Lebar = 56,
                Tinggi = 104,
                HargaHook = 1.5,
                Layout = "L",
            };

            IFormula formula = new F25_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 91.88);
            Assert.AreEqual(actual.HargaKainA, 18.88);
            Assert.AreEqual(actual.HargaKainB, 64);
            Assert.AreEqual(actual.UpahKainA, 6.00);
            Assert.AreEqual(actual.UpahHook, 3.00);
            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.TailorKeping, 1);
            Assert.AreEqual(actual.TailorTotalKeping, 2);
            Assert.AreEqual(actual.TailorMeterA, 3.10);
            Assert.AreEqual(actual.TailorMeterB, 3.13);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorKepingB, 1);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 1);
            Assert.AreEqual(actual.TailorMeterA, 3.10);
            Assert.AreEqual(actual.TailorMeterB, 1.56);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorKepingB, 2);
        }
    }
}