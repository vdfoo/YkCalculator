﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F9_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 28,
                Lebar = 105,
                Tinggi = 104,
                HargaHook = 0.1,
                Layout = "L",
            };

            IFormula formula = new F9_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 256.15);
            Assert.AreEqual(actual.HargaKainA, 226.15);
            Assert.AreEqual(actual.UpahKainA, 27.00);
            Assert.AreEqual(actual.UpahHook, 3.00);
            Assert.AreEqual(actual.Keping, 9);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.KepingB, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 9);
            Assert.AreEqual(actual.TailorMeterA, 7.81);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input); 
            Assert.AreEqual(actual.TailorKeping, 3);
            Assert.AreEqual(actual.TailorMeterA, 3.9);
            Assert.AreEqual(actual.TailorKepingA, 2);
        }
    }
}