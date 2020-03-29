using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F27_2_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.9,
                HargaKainB = 12,
                Lebar = 100,
                Tinggi = 100,
                HargaCincin = 7
            };

            IFormula formula = new F27_2_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 220.10);
            Assert.AreEqual(actual.HargaKainA, 53.10);
            Assert.AreEqual(actual.HargaKainB, 152.00);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotal, 5);
            Assert.AreEqual(actual.TailorTinggi, 10.00);
            Assert.AreEqual(actual.TailorTinggi2, 3.75);
            Assert.AreEqual(actual.TailorJalur, 20);
        }
    }
}