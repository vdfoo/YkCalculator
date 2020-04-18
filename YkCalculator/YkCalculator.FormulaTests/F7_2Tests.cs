using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F7_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                Lebar = 100,
                Tinggi = 100,
                HargaHook = 0.1,
                Layout = "L",
            };

            IFormula formula = new F7_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 235.03);
            Assert.AreEqual(actual.HargaKainA, 205.13);
            Assert.AreEqual(actual.UpahKainA, 27.00);
            Assert.AreEqual(actual.UpahHook, 2.90);
            Assert.AreEqual(actual.Keping, 9);
            Assert.AreEqual(actual.KepingB, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 9);
            Assert.AreEqual(actual.TailorMeter, 3.08);
        }
    }
}