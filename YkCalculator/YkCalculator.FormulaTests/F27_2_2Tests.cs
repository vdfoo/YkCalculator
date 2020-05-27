using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F27_2_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.9,
                HargaKainB = 12,
                Lebar = 100,
                Tinggi = 100,
                HargaCincin = 7,
                Layout = "L",
            };

            IFormula formula = new F27_2_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 220.10);
            Assert.AreEqual(actual.HargaKainA, 53.10);
            Assert.AreEqual(actual.HargaKainB, 96);
            Assert.AreEqual(actual.UpahCincin, 56);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.TailorJalur, 20);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorMeterB, 7.31);
            Assert.AreEqual(actual.TailorKepingB, 1);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2.5);
            Assert.AreEqual(actual.TailorJalur, 10);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.AreEqual(actual.TailorMeterB, 3.72);
            Assert.AreEqual(actual.TailorKepingB, 2);
        }
    }
}