using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F15_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 18,
                Lebar = 101,
                Tinggi = 104,
                HargaHook = 1.50
            };

            IFormula formula = new F15_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 120.46);
            Assert.AreEqual(actual.HargaKainA, 102.46);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotal, 4);
            Assert.AreEqual(actual.TailorTinggi, 1, 2.72);
        }
    }
}