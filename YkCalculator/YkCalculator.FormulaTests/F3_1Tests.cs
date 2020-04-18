using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F3_1Tests
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
                Layout = "L",
            };

            IFormula formula = new F3_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 261.60);
            Assert.AreEqual(actual.HargaKainA, 249.60);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorMeter, 3);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.UpahKainA, 12);
        }
    }
}