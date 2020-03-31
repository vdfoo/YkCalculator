﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F41_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainC = 12,
                Lebar = 120,
                Tinggi = 100,
                HargaCincinG = 11.20,
                HargaCincinC = 7,
                KepingG = 4,
                KepingC = 2
            };

            IFormula formula = new F41_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 265.14);
            Assert.AreEqual(actual.HargaKainA, 198.34);
            Assert.AreEqual(actual.HargaKainC, 66.80);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorMeterG, 2.82);
            Assert.AreEqual(actual.TailorMeterC, 1.57);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
        }
    }
}