using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F57_1Tests
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

            IFormula formula = new F57_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 302.46);
            Assert.AreEqual(actual.HargaKainA, 42);
            Assert.AreEqual(actual.HargaKainB, 42);
            Assert.AreEqual(actual.HargaKainC, 42);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaRainbow, 25);
            Assert.AreEqual(actual.HargaRenda, 118.46);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 18.72);
            Assert.AreEqual(actual.TailorMeterC, 18.72);
        }
    }
}