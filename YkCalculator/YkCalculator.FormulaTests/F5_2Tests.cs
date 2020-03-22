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
                HargaHook = 0.1
            };

            IFormula formula = new F5_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 314.84);
            Assert.AreEqual(actual.HargaKainA, 225.64);
            Assert.AreEqual(actual.UpahKainA, 30.00);
            Assert.AreEqual(actual.UpahButang, 56.00);
            Assert.AreEqual(actual.UpahHook, 3.20);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorKeping, 10);
            Assert.AreEqual(actual.TailorTotal, 10);
            Assert.AreEqual(actual.TailorTinggi, 3.38);
        }
    }
}