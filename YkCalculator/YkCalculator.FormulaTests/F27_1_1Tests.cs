using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F27_1_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.9,
                HargaKainB = 7.8,
                Lebar = 100,
                Tinggi = 100,
                HargaCincin = 11.2,
                Layout = "L",
            };

            IFormula formula = new F27_1_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 191.28);
            Assert.AreEqual(actual.HargaKainA, 42.48);
            Assert.AreEqual(actual.HargaKainB, 92.00);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.UpahCincin, 44.80);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorJalur, 16);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorMeterB, 2.82);
            Assert.AreEqual(actual.TailorKepingB, 4);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorJalur, 8);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.AreEqual(actual.TailorMeterB, 2.82);
            Assert.AreEqual(actual.TailorKepingB, 4);
        }
    }
}