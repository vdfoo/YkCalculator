using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F33_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 5.5,
                HargaKainB = 7.8,
                Lebar = 120,
                Tinggi = 100,
                Lipat = 2,
                HargaButang = 2.00,
                HargaCincin = 11.2
            };

            IFormula formula = new F33_1();
            Output actual = formula.Calculate(input);

            //Assert.AreEqual(actual.Jumlah, 653.23);
            //Assert.AreEqual(actual.HargaKainA, 414);
            //Assert.AreEqual(actual.HargaKainB, 65.23);
            //Assert.AreEqual(actual.UpahKainA, 30);
            //Assert.AreEqual(actual.UpahKainB, 12.00);
            //Assert.AreEqual(actual.Keping, 10);
            //Assert.AreEqual(actual.TailorKeping, 10);
            //Assert.AreEqual(actual.TailorRenda, 14.49);
            //Assert.AreEqual(actual.TailorRendaKeping, 2);
            //Assert.AreEqual(actual.TailorTotal, 14);
            //Assert.AreEqual(actual.TailorTinggi, 0);
            //Assert.AreEqual(actual.TailorTinggiB, 2.59);
        }
    }
}