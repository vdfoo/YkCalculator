using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F29_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.5,
                HargaKainB = 7.8,
                Lebar = 96,
                Tinggi = 96,
                Lipat = 6,
                HargaHook = 1.5,
                HargaCincin = 11.2
            };

            IFormula formula = new F29_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 560.80);
            Assert.AreEqual(actual.HargaKainA, 312);
            Assert.AreEqual(actual.HargaKainB, 88.80);
            Assert.AreEqual(actual.UpahKainA, 30);
            Assert.AreEqual(actual.UpahKainB, 12.00);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorKeping, 10);
            Assert.AreEqual(actual.TailorRenda, 14.49);
            Assert.AreEqual(actual.TailorTotal, 14);
            Assert.AreEqual(actual.TailorTinggi, 0.74);
            Assert.AreEqual(actual.TailorTinggi2, 2.72);
        }
    }
}