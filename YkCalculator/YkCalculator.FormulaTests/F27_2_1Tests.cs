using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F27_2_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.9,
                HargaKainB = 7.8,
                Lebar = 100,
                Tinggi = 100,
                HargaCincin = 11.2
            };

            IFormula formula = new F27_2_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 176.08);
            Assert.AreEqual(actual.HargaKainA, 42.48);
            Assert.AreEqual(actual.HargaKainB, 121.60);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotal, 4);
            Assert.AreEqual(actual.TailorTinggi, 8.00);
            Assert.AreEqual(actual.TailorTinggi2, 3);
            Assert.AreEqual(actual.TailorJalur, 16);
        }
    }
}