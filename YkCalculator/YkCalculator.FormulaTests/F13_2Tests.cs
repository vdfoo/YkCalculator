using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F13_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 14,
                Lebar = 56,
                Tinggi = 100,
            };

            IFormula formula = new F13_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 26.69);
            Assert.AreEqual(actual.HargaKainA, 23.69);
            Assert.AreEqual(actual.UpahKainA, 3);
            Assert.AreEqual(actual.Keping, 1);
            Assert.AreEqual(actual.TailorKeping, 1);
            Assert.AreEqual(actual.TailorTotal, 1);
            Assert.AreEqual(actual.TailorTinggi, 1,64);
        }
    }
}