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
                HargaCincin = 11.2,
                Layout = "L",
            };

            IFormula formula = new F33_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 308.96);
            Assert.AreEqual(actual.JumlahA, 192.96);
            Assert.AreEqual(actual.JumlahB, 116.00);
            Assert.AreEqual(actual.HargaKainA, 104.16);
            Assert.AreEqual(actual.HargaKainB, 104);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.UpahKainB, 12);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorRenda1, 3);
            Assert.AreEqual(actual.TailorRenda2, 3);
            Assert.AreEqual(actual.TailorMeterA, 3);
            Assert.AreEqual(actual.TailorMeterB, 2.82);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorKepingB, 4);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorRenda1, 3);
            Assert.AreEqual(actual.TailorRenda2, 3);
            Assert.AreEqual(actual.TailorMeterA, 3);
            Assert.AreEqual(actual.TailorMeterB, 2.82);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorKepingB, 4);
        }
    }
}