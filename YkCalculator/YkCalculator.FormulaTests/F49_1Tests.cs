using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F49_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7.8,
                HargaKainB = 12,
                Lebar = 72,
                Tinggi = 100,
                HargaCincin = 11.2,
                MeterDiscountAmount = 24,
                Layout = "L",
            };

            IFormula formula = new F49_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 193.76);
            Assert.AreEqual(actual.HargaKainA, 24.96);
            Assert.AreEqual(actual.HargaKainB, 168.80);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.KepingA, 2);
            Assert.AreEqual(actual.KepingB, 4);
            Assert.AreEqual(actual.TailorMeter, 0);
            Assert.AreEqual(actual.TailorMeterB, 2.21);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
        }
    }
}