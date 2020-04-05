using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F68_2Tests
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
                HargaTali = 5,
                HargaButang = 2,
                HargaCincin = 0.8,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 1
            };

            IFormula formula = new F68_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 332.95);
            Assert.AreEqual(actual.HargaRainbow, 5.00);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.HargaTali, 20.00);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaKainA, 43.08);
            Assert.AreEqual(actual.HargaKainB, 41.54);
            Assert.AreEqual(actual.HargaKainC, 12.00);
            Assert.AreEqual(actual.HargaRenda, 53.85);
            Assert.AreEqual(actual.HargaRenda2, 23.08);
            Assert.AreEqual(actual.HargaRenda3, 15);
            Assert.AreEqual(actual.HargaCincin, 6.4);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.HargaButang, 80);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorRenda, 8.46);
            Assert.AreEqual(actual.TailorRenda2, 3.33);
            Assert.AreEqual(actual.TailorRenda3, 2);
        }
    }
}