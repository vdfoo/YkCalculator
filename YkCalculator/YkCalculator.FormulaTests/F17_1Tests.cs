using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F17_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 6.6,
                HargaKainB = 7.8,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.50,
                Keping = 5,
                KepingA = 3,
                KepingB = 2
            };

            IFormula formula = new F17_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 126.88);
            Assert.AreEqual(actual.HargaKainA, 58.38);
            Assert.AreEqual(actual.HargaKainB, 46);
            Assert.AreEqual(actual.UpahKainA, 15);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotal, 5);
            Assert.AreEqual(actual.TailorTinggi, 2.82);
        }
    }
}