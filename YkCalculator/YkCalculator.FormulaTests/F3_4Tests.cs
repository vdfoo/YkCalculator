using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F3_4Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                Lebar = 110,
                Tinggi = 104,
            };

            IFormula formula = new F3_4();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 439.20);
            Assert.AreEqual(actual.HargaKainA, 421.20);
            Assert.AreEqual(actual.UpahKainA, 18.00);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
            Assert.AreEqual(actual.TailorTinggi, 12);
        }
    }
}