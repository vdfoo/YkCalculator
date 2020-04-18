using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F39_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                HargaKainB = 32,
                Lebar = 120,
                Tinggi = 100,
                HargaCincin = 7,
                Layout = "L",
            };

            IFormula formula = new F39_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 277.20);
            Assert.AreEqual(actual.HargaKainA, 130.80);
            Assert.AreEqual(actual.HargaKainB, 146.40);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorMeter, 4);
            Assert.AreEqual(actual.TailorMeterB, 1.56);
            Assert.AreEqual(actual.TailorMeterK, 1.56);
        }
    }
}