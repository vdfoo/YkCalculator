﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F53_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7.8,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 120,
                HargaHook = 1.5,
                MeterDiscountAmount = 24,
                Layout = "L",
            };

            IFormula formula = new F53_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 224.47);
            Assert.AreEqual(actual.HargaKainA, 31.20);
            Assert.AreEqual(actual.HargaKainB, 170.77);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.UpahHook, 7.5);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 2.72);
            Assert.AreEqual(actual.TailorKepingB, 5);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2.5);
        }
    }
}