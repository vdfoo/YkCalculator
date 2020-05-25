using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class S4Tests
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
                Layout = "T",
            };

            IFormula formula = new S4();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 439.20);
            Assert.AreEqual(actual.UpahKainA, 18);
            Assert.AreEqual(actual.HargaKainA, 421.20);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
            Assert.AreEqual(actual.TailorKeping, 3);
            Assert.AreEqual(actual.TailorJalur, 12);
            Assert.AreEqual(actual.TailorKepingA, 2);

            input.Layout = "L";
            actual = formula.Calculate(input);

            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorJalur, 24);
            Assert.AreEqual(actual.TailorKepingA, 1);
        }
    }
}