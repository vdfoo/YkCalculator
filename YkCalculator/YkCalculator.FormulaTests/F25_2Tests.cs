using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F25_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.9,
                HargaKainB = 18.8,
                Lebar = 56,
                Tinggi = 104,
                HargaHook = 1.5
            };

            IFormula formula = new F25_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 91.88);
            Assert.AreEqual(actual.HargaKainA, 18.88);
            Assert.AreEqual(actual.HargaKainB, 64);
            Assert.AreEqual(actual.UpahKainA, 6.00);
            Assert.AreEqual(actual.UpahHook, 3.00);
            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorTotalKeping, 2);
            Assert.AreEqual(actual.TailorTinggi, 3.10);
            Assert.AreEqual(actual.TailorTinggiB, 1.56);
        }
    }
}