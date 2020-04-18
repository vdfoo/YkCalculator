using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F51_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 120,
                HargaHook = 1.5,
                Layout = "L",
            };

            IFormula formula = new F51_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 118.00);
            Assert.AreEqual(actual.HargaKainA, 20.00);
            Assert.AreEqual(actual.HargaKainB, 80.00);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.UpahHook, 6);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorMeter, 0);
            Assert.AreEqual(actual.TailorMeterB, 3.21);
        }
    }
}