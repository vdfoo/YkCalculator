using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F43_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                HargaKainC = 32,
                Lebar = 120,
                Tinggi = 96,
                HargaCincinG = 7,
                HargaCincinC = 7,
                KepingG = 4,
                KepingC = 2,
                Layout = "L",
            };

            IFormula formula = new F43_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 392.40);
            Assert.AreEqual(actual.HargaKainA, 261.60);
            Assert.AreEqual(actual.HargaKainC, 130.80);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorMeterG, 1.51);
            Assert.AreEqual(actual.TailorMeterC, 2.95);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
        }
    }
}