﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F58_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 12,
                HargaKainC = 12,
                Lebar = 120,
                Tinggi = 24,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 2,
                HargaButang = 2,
                ButangChoice = 2
            };

            IFormula formula = new F58_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 288.77);
            Assert.AreEqual(actual.HargaKainAB, 41.54);
            Assert.AreEqual(actual.HargaKainC, 43.08);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaRainbow, 5);
            Assert.AreEqual(actual.HargaRenda, 46.15);
            Assert.AreEqual(actual.HargaButang, 120);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorRenda1, 3.33);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 9999);
            Assert.AreEqual(actual.TailorRenda, 6.67);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));
        }
    }
}