using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F17_3Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 16,
                HargaKainB = 7.8,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.50,
                Keping = 5,
                KepingA = 3,
                KepingB = 2,
                Layout = "L",
            };

            IFormula formula = new F17_3();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 145.16);
            Assert.AreEqual(actual.HargaKainA, 76.80);
            Assert.AreEqual(actual.HargaKainB, 45.86);
            Assert.AreEqual(actual.UpahKainA, 15);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.TailorMeter, 2.82);
            Assert.AreEqual(actual.TailorMeterB, 2.25);
        }
    }
}