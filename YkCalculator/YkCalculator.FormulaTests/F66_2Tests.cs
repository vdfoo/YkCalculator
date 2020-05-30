using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F66_2Tests
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
                HargaButang = 2,
                HargaCincin = 0.8,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 1
            };

            IFormula formula = new F66_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 297.96);
            Assert.AreEqual(actual.HargaRainbow, 5.00);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaKainA, 25.13);
            Assert.AreEqual(actual.HargaKainB, 25.13);
            Assert.AreEqual(actual.HargaKainC, 7.00);
            Assert.AreEqual(actual.HargaRenda, 53.85);
            Assert.AreEqual(actual.HargaRenda2, 53.85);
            Assert.AreEqual(actual.HargaRenda3, 15);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.HargaButang, 80);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 9999);
            Assert.AreEqual(actual.TailorMeterC, 9999);
            Assert.AreEqual(actual.TailorRenda1, 8.46);
            Assert.AreEqual(actual.TailorRenda2, 8.46);
            Assert.AreEqual(actual.TailorRenda3, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));
        }
    }
}