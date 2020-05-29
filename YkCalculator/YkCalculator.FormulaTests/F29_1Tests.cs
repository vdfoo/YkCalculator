using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F29_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.5,
                HargaKainB = 7.8,
                Lebar = 96,
                Tinggi = 96,
                Lipat = 6,
                HargaHook = 1.5,
                HargaCincin = 11.2,
                Layout = "L",
            };

            IFormula formula = new F29_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 560.80);
            Assert.AreEqual(actual.HargaKainA, 312);
            Assert.AreEqual(actual.HargaKainB, 88.80);
            Assert.AreEqual(actual.UpahKainA, 30);
            Assert.AreEqual(actual.UpahKainB, 12.00);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.KepingB, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 14);
            Assert.AreEqual(actual.TailorRenda1, 14.49);
            Assert.AreEqual(actual.TailorRenda2, 14.49); ;
            Assert.AreEqual(actual.TailorMeterA, 0.75);
            Assert.AreEqual(actual.TailorMeterB, 0.75);
            Assert.AreEqual(actual.TailorKepingA, 10);
            Assert.AreEqual(actual.TailorKepingB, 10);
            Assert.AreEqual(actual.TailorBodyMeter, 2.72);
            Assert.AreEqual(actual.TailorBodyKeping, 4);
            Assert.AreEqual(actual.TailorHeaderKepingA, 10);
            Assert.AreEqual(actual.TailorHeaderKepingB, 10);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
        }
    }
}
