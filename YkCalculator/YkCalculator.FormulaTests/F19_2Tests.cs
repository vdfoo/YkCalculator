using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F19_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 120,
                Tinggi = 104
            };

            IFormula formula = new F19_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 251.54);
            Assert.AreEqual(actual.HargaKainA, 221.54);
            Assert.AreEqual(actual.UpahKainA, 30);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorKeping, 10);
            Assert.AreEqual(actual.TailorTotalKeping, 10);
            Assert.AreEqual(actual.TailorTinggi, 7.44);
        }
    }
}