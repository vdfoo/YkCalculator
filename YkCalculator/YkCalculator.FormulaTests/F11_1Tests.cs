﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F11_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 56,
                Tinggi = 100,
            };

            IFormula formula = new F11_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 82.92);
            Assert.AreEqual(actual.HargaKainA, 76.92);
            Assert.AreEqual(actual.UpahKainA, 6.00);
            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorTotal, 2);
            Assert.AreEqual(actual.TailorTinggi, 3.08);
        }
    }
}