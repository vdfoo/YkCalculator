﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F72_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7,
                Lebar = 120,
                Tinggi = 24,
                HargaButang = 2,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 1
            };

            IFormula formula = new F72_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 212.98);
            Assert.AreEqual(actual.HargaRainbow, 5.00);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaKainA, 25.13);
            Assert.AreEqual(actual.HargaKainB, 7);
            Assert.AreEqual(actual.HargaButang, 74);
            Assert.AreEqual(actual.HargaRenda, 53.85);
            Assert.AreEqual(actual.HargaRenda2, 15);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 9999);
            Assert.AreEqual(actual.TailorRenda, 8.46);
            Assert.AreEqual(actual.TailorRenda2, 2);
        }
    }
}