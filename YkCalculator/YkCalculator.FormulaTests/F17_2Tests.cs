using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F17_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 16,
                HargaKainB = 16,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.50,
                Layout = "L",
            };

            IFormula formula = new F17_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 128.76);
            Assert.AreEqual(actual.HargaKainA, 55.38);
            Assert.AreEqual(actual.HargaKainB, 55.38);
            Assert.AreEqual(actual.UpahHook, 6);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorMeter, 3.33);
        }
    }
}