﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class S2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                Lebar = 110,
                Tinggi = 104,
                HargaCincin = 7,
                Layout = "T",
            };

            IFormula formula = new S2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 392.72);
            Assert.AreEqual(actual.UpahKainA, 18);
            Assert.AreEqual(actual.UpahCincin, 67.20);
            Assert.AreEqual(actual.HargaKainA, 307.52);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
            Assert.AreEqual(actual.TailorKeping, 3);
            Assert.AreEqual(actual.TailorMeterA, 4.44);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "L";
            actual = formula.Calculate(input);

            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorMeterA, 8.75);
            Assert.AreEqual(actual.TailorKepingA, 1);
        }
    }
}