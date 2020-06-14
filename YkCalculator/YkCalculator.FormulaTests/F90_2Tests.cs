using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F90_2Tests
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

            IFormula formula = new F90_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.Jumlah, 121.38);
            Assert.AreEqual(actual.UpahKainA, 86.00);
            Assert.AreEqual(actual.HargaKainA, 35.38);
            Assert.AreEqual(actual.TailorMeterA, 2.05);
            Assert.AreEqual(actual.TailorKepingA, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));
        }
    }
}