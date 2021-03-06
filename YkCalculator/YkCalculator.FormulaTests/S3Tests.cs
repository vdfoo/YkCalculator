﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class S3Tests
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

            IFormula formula = new S3();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 292.80);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.UpahCincin, 50.40);
            Assert.AreEqual(actual.HargaKainA, 230.4);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorJalur, 8);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "L";
            actual = formula.Calculate(input);

            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorJalur, 16);
            Assert.AreEqual(actual.TailorKepingA, 1);
        }
    }
}