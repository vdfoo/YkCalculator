using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F37_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 32,
                Lebar = 120,
                Tinggi = 100,
                KepingA = 4,
                KepingB = 2, 
                HargaCincin = 11.20,
                HargaCincinB = 7,
                Layout = "L",
            };

            IFormula formula = new F37_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 344.72);
            Assert.AreEqual(actual.JumlahA, 198.32);
            Assert.AreEqual(actual.JumlahB, 146.40);
            Assert.AreEqual(actual.HargaKainA, 35.38);
            Assert.AreEqual(actual.HargaKainB, 70.20);
            Assert.AreEqual(actual.UpahKainA, 18);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorKeping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
            Assert.AreEqual(actual.TailorMeter, 2.82);
            Assert.AreEqual(actual.TailorMeterB, 4);
            Assert.AreEqual(actual.TailorMeterK, 2.82);
        }
    }
}