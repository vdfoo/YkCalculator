using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F35_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.5,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 100,
                Lipat = 2,
                HargaButang = 2.00,
            };

            IFormula formula = new F35_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 294.40);
            Assert.AreEqual(actual.JumlahA, 157.60);
            Assert.AreEqual(actual.JumlahB, 136.80);
            Assert.AreEqual(actual.HargaKainA, 113.6);
            Assert.AreEqual(actual.HargaKainB, 136.80);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorRenda, 6);
            Assert.AreEqual(actual.TailorTotal, 4);
            Assert.AreEqual(actual.TailorTinggi, 0);
            Assert.AreEqual(actual.TailorTinggiB, 3);
        }
    }
}