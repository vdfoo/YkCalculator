using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F43_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainG = 32,
                HargaKainC = 32,
                Lebar = 120,
                Tinggi = 96,
                HargaCincinG = 7,
                HargaCincinC = 7,
                KepingC = 2,
                KepingG = 4,
                Layout = "L",
            };

            IFormula formula = new F43_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 392.40);
            Assert.AreEqual(actual.HargaKainG, 204.8);
            Assert.AreEqual(actual.HargaKainC, 102.4);
            Assert.AreEqual(actual.HargaCincinG, 44.80);
            Assert.AreEqual(actual.HargaCincinC, 22.40);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorKepingBreakdownC, 1);
            Assert.AreEqual(actual.TailorKepingBreakdownG, 2);
            Assert.AreEqual(actual.TailorMeterG, 2.95);
            Assert.AreEqual(actual.TailorMeterC, 3.03);
            Assert.AreEqual(actual.TailorKepingG, 2);
            Assert.AreEqual(actual.TailorKepingC, 1);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKepingBreakdownC, 1);
            Assert.AreEqual(actual.TailorKepingBreakdownG, 2);
            Assert.AreEqual(actual.TailorMeterG, 2.95);
            Assert.AreEqual(actual.TailorMeterC, 1.52);
            Assert.AreEqual(actual.TailorKepingG, 2);
            Assert.AreEqual(actual.TailorKepingC, 2);
        }
    }
}