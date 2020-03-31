using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F21_2Tests
    {
        [TestMethod()]
        public void CalculateSeparateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 28,
                HargaKainB = 28,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.5,
                Separate = true
            };

            IFormula formula = new F21_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 397.34);
            Assert.AreEqual(actual.HargaKainA, 186.67);
            Assert.AreEqual(actual.HargaKainB, 186.67);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.UpahHook, 12.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorTinggi, 6.28);
            Assert.AreEqual(actual.TailorTinggiB, 3.21);
        }

        [TestMethod()]
        public void CalculateTogetherTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 28,
                HargaKainB = 28,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.5,
                Separate = false
            };

            IFormula formula = new F21_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 391.34);
            Assert.AreEqual(actual.HargaKainA, 186.67);
            Assert.AreEqual(actual.HargaKainB, 186.67);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.UpahHook, 6.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorTinggi, 6.28);
            Assert.AreEqual(actual.TailorTinggiB, 3.21);
        }
    }
}