using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F62_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7,
                Lebar = 120,
                Tinggi = 24,
                TariScalletQuantity = 1,
                HargaButang = 2,
                HargaCincin = 0.8,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 1
            };

            IFormula formula = new F62_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 283.25);
            Assert.AreEqual(actual.HargaKainA, 24.23);
            Assert.AreEqual(actual.HargaKainB, 37.69); 
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaRainbow, 5);
            Assert.AreEqual(actual.HargaRenda, 23.08);
            Assert.AreEqual(actual.HargaRenda2, 53.85);
            Assert.AreEqual(actual.HargaCincin, 6.4);
            Assert.AreEqual(actual.HargaTariScallet, 20);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 9999);
            Assert.AreEqual(actual.TailorRenda1, 3.33);
            Assert.AreEqual(actual.TailorRenda2, 9.23);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));
        }
    }
}