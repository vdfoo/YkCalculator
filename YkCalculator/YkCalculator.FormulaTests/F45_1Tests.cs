using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F45_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7.8,
                HargaKainB = 18,
                Lebar = 120,
                Tinggi = 24,
                TinggiB = 100,
                HargaCincin = 7,
                Layout = "L",
            };

            IFormula formula = new F45_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 196.96);
            Assert.AreEqual(actual.HargaKainA, 24.96);
            Assert.AreEqual(actual.HargaKainB, 172.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorHeaderKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 5.87);
            Assert.AreEqual(actual.TailorKepingB, 1);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorMeterB, 3);
            Assert.AreEqual(actual.TailorKepingB, 2);
        }
    }
}