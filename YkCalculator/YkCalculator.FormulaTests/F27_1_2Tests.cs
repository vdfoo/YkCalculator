using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F27_1_2Tests
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

            IFormula formula = new F27_1_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 286.92);
            Assert.AreEqual(actual.HargaKainA, 63.72);
            Assert.AreEqual(actual.HargaKainB, 138.00);
            Assert.AreEqual(actual.UpahKainA, 18.00);
            Assert.AreEqual(actual.UpahCincin, 67.20);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorTotal, 6);
            Assert.AreEqual(actual.TailorTinggi, 12.00);
            Assert.AreEqual(actual.TailorTinggiB, 2.82);
            Assert.AreEqual(actual.TailorJalur, 24);
        }
    }
}