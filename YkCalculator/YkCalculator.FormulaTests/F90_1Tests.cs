using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F90_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 70,
                Tinggi = 100
            };

            IFormula formula = new F90_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.Jumlah, 138.31);
            Assert.AreEqual(actual.UpahKainA, 86.00);
            Assert.AreEqual(actual.HargaKainA, 52.31);
            Assert.AreEqual(actual.TailorMeterA, 2.82);
            Assert.AreEqual(actual.TailorKepingA, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 2);
        }
    }
}