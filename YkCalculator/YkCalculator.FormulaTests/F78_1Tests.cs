using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F78_1Tests
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
                RibbonQuantity = 1,
                HargaHook = 0.1,
                HargaRenda = 5,
                RainbowQuantity = 1,
                RendaQuantity = 1
            };

            IFormula formula = new F78_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 61.31);
            Assert.AreEqual(actual.HargaRibbon, 5);
            Assert.AreEqual(actual.UpahKainA, 6);
            Assert.AreEqual(actual.UpahHook, 3);
            Assert.AreEqual(actual.HargaKainA, 24.23);
            Assert.AreEqual(actual.HargaRenda, 23.08);
            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.TailorTotalKeping, 2);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorRenda, 3.33);
        }
    }
}