using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F21_1Tests
    {
        [TestMethod()]
        public void CalculateSeparateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.5,
                Separate = true
            };

            IFormula formula = new F21_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 259.23);
            Assert.AreEqual(actual.HargaKainA, 52.31);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.UpahHook, 15.00);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotal, 5);
            Assert.AreEqual(actual.TailorTinggi, 0.74);
            Assert.AreEqual(actual.TailorTinggiB, 2.82);
        }

        [TestMethod()]
        public void CalculateTogetherTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.5,
                Separate = false
            };

            IFormula formula = new F21_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 251.73);
            Assert.AreEqual(actual.HargaKainA, 52.31);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.UpahHook, 7.50);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotal, 5);
            Assert.AreEqual(actual.TailorTinggi, 0.74);
            Assert.AreEqual(actual.TailorTinggiB, 2.82);
        }
    }
}