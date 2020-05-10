using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F5_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                Lebar = 110,
                Tinggi = 96,
                HargaButang = 2,
                HargaHook = 0.1,
                Layout = "L",
            };

            IFormula formula = new F5_2();

            // Test L
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 314.84);
            Assert.AreEqual(actual.HargaKainA, 225.64);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahButang, 56.00);
            Assert.AreEqual(actual.UpahHook, 3.20);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorKeping, 1);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorMeterA, 6.77);
            Assert.AreEqual(actual.TailorKepingA, 1);

            // Test T
            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2.5);
            Assert.AreEqual(actual.TailorMeterA, 3.38);
            Assert.AreEqual(actual.TailorKepingA, 2);
        }
    }
}
