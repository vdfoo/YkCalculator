using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F60_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 120,
                Tinggi = 24,
                HargaCincin = 0.8,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 2
            };

            IFormula formula = new F60_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 306.93);
            Assert.AreEqual(actual.HargaKainA, 64.62);
            Assert.AreEqual(actual.HargaKainB, 64.62);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaRainbow, 5);
            Assert.AreEqual(actual.HargaRenda, 107.69);
            Assert.AreEqual(actual.HargaCincin, 32);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorRenda1, 3.33);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 9999);
            Assert.AreEqual(actual.TailorRenda, 6.67);
        }
    }
}