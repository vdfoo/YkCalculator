using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F3_3Tests
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

            IFormula formula = new F3_3();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 292.80);
            Assert.AreEqual(actual.HargaKainA, 280.80);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorJalur, 8);
        }
    }
}