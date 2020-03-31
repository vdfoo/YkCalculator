using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F31_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.5,
                HargaKainB = 12,
                Lebar = 96,
                Tinggi = 96,
                Lipat = 6,
                HargaHook = 1.5,
                HargaCincin = 11.2
            };

            IFormula formula = new F31_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 593.23);
            Assert.AreEqual(actual.HargaKainA, 368);
            Assert.AreEqual(actual.HargaKainB, 65.23);
            Assert.AreEqual(actual.UpahKainA, 30);
            Assert.AreEqual(actual.UpahKainB, 12.00);
            Assert.AreEqual(actual.Keping, 10);
            Assert.AreEqual(actual.TailorKeping, 10);
            Assert.AreEqual(actual.TailorRenda, 14.49);
            Assert.AreEqual(actual.TailorRendaKeping, 2);
            Assert.AreEqual(actual.TailorTotalKeping, 14);
            Assert.AreEqual(actual.TailorTinggi, 0);
            Assert.AreEqual(actual.TailorTinggiB, 2.59);
        }
    }
}