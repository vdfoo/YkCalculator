using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F47_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                HargaKainB = 32,
                Lebar = 100,
                Tinggi = 100,
                HargaCincin = 7,
                Layout = "L",
            };

            IFormula formula = new F47_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 350.40);
            Assert.AreEqual(actual.HargaKainA, 292.80);
            Assert.AreEqual(actual.HargaKainB, 57.60);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorHeaderKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorKepingA, 9999);
            Assert.AreEqual(actual.TailorJalur, 16);
            Assert.AreEqual(actual.TailorKepingB, 1);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorJalur, 8);
            Assert.AreEqual(actual.TailorKepingB, 2);
        }
    }
}