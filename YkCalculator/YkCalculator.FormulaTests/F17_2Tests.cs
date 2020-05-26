using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F17_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 16,
                HargaKainB = 16,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.50,
                Layout = "L",
            };

            IFormula formula = new F17_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 128.76);
            Assert.AreEqual(actual.HargaKainA, 55.38);
            Assert.AreEqual(actual.HargaKainB, 55.38);
            Assert.AreEqual(actual.UpahHook, 6);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKepingBreakdownA, 1);
            Assert.AreEqual(actual.TailorKepingBreakdownB, 1);
            Assert.AreEqual(actual.TailorMeterA, 1.67);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.AreEqual(actual.TailorMeterB, 3.33);
            Assert.AreEqual(actual.TailorKepingB, 1);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorMeterA, 1.67);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.AreEqual(actual.TailorMeterB, 1.67);
            Assert.AreEqual(actual.TailorKepingB, 2);

        }
    }
}