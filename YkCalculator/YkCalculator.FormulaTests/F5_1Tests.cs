using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F5_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 110,
                Tinggi = 96,
                HargaButang = 2,
                HargaHook = 0.1
            };

            IFormula formula = new F5_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 259.97);
            Assert.AreEqual(actual.HargaKainA, 170.77);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahButang, 56.00);
            Assert.AreEqual(actual.UpahHook, 3.20);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.Keping2, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotal, 5);
            Assert.AreEqual(actual.TailorTinggi, 2.72);
        }
    }
}