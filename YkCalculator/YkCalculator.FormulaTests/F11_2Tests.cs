using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F11_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 2,
                HargaKainA = 28,
                Lebar = 56,
                Tinggi = 100,
            };

            IFormula formula = new F11_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 201.54);
            Assert.AreEqual(actual.HargaKainA, 189.54);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotal, 4);
            Assert.AreEqual(actual.TailorTinggi, 1.56);
        }
    }
}