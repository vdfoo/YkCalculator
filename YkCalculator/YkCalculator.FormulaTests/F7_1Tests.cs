using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F7_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 100,
                Tinggi = 100,
                HargaHook = 0.1
            };

            IFormula formula = new F7_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 206.82);
            Assert.AreEqual(actual.HargaKainA, 176.92);
            Assert.AreEqual(actual.UpahKainA, 27.00);
            Assert.AreEqual(actual.UpahHook, 2.90);
            Assert.AreEqual(actual.Keping, 9);
            Assert.AreEqual(actual.Keping2, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTinggi, 2.82);
        }
    }
}