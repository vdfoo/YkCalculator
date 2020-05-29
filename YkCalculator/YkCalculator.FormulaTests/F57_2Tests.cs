using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F57_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7.8,
                HargaKainB = 7.8,
                HargaKainC = 7.8,
                Lebar = 120,
                Tinggi = 24,
                HargaHook = 0.1,
                MeterDiscountAmount = 24,
                HargaRenda = 5.5,
                RainbowQuantity = 5,
                RendaQuantity = 2
            };

            IFormula formula = new F57_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 260.46);
            Assert.AreEqual(actual.HargaKainA, 28.00);
            Assert.AreEqual(actual.HargaKainB, 28.00);
            Assert.AreEqual(actual.HargaKainC, 28.00);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaRainbow, 25.00);
            Assert.AreEqual(actual.HargaRenda, 118.46);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorHeaderKepingA, 9999);
            Assert.AreEqual(actual.TailorHeaderKepingB, 9999);
            Assert.AreEqual(actual.TailorRenda1, 9.36);
            Assert.AreEqual(actual.TailorRenda2, 9.36);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 9999);
            Assert.AreEqual(actual.TailorRenda, 18.72);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));
        }
    }
}