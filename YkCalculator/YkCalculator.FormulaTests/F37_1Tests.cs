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
                HargaKainK = 12,
                HargaKainB = 32,
                KepingK = 4,
	            KepingB = 2,
                Lebar = 120,
                Tinggi = 100,
                HargaCincinK = 11.20,
                HargaCincinB = 7,
                Layout = "L",
            };

            IFormula formula = new F37_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 344.74);
            Assert.AreEqual(actual.HargaKainK, 141.54);
            Assert.AreEqual(actual.HargaKainB, 115.2);
            Assert.AreEqual(actual.HargaCincinK, 44.8);
            Assert.AreEqual(actual.HargaCincinB, 25.2);
            Assert.AreEqual(actual.UpahKainA, 18);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
            Assert.AreEqual(actual.TailorKepingBreakdownK, 2);
            Assert.AreEqual(actual.TailorKepingBreakdownB, 1);
            Assert.AreEqual(actual.TailorMeterK, 2.82);
            Assert.AreEqual(actual.TailorKepingK, 2);
            Assert.AreEqual(actual.TailorJalur, 8);
            Assert.AreEqual(actual.TailorKepingB, 1);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKepingBreakdownK, 2);
            Assert.AreEqual(actual.TailorKepingBreakdownB, 1);
            Assert.AreEqual(actual.TailorMeterK, 2.82);
            Assert.AreEqual(actual.TailorKepingK, 4);
            Assert.AreEqual(actual.TailorJalur, 4);
            Assert.AreEqual(actual.TailorKepingB, 2);
        }
    }
}
