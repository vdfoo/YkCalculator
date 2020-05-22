using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F41_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainG = 12,
                HargaKainC = 12,
                Lebar = 120,
                Tinggi = 100,
                HargaCincinG = 11.20,
                HargaCincinC = 7,
                Layout = "L",
            };

            IFormula formula = new F41_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 265.14);
            Assert.AreEqual(actual.HargaKainG, 198.34);
            Assert.AreEqual(actual.HargaKainC, 66.80);
            Assert.AreEqual(actual.Keping, 6);
            Assert.AreEqual(actual.TailorTotalKeping, 6);
            Assert.AreEqual(actual.TailorKepingBreakdownC, 1);
            Assert.AreEqual(actual.TailorKepingBreakdownG, 1);
            Assert.AreEqual(actual.TailorKepingBreakdownG2, 2);
            Assert.AreEqual(actual.TailorMeterG, 2.82);
            Assert.AreEqual(actual.TailorMeterC, 1.57);
            Assert.AreEqual(actual.TailorKepingG, 4);
            Assert.AreEqual(actual.TailorKepingC, 2);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKepingBreakdownC, 1);
            Assert.AreEqual(actual.TailorKepingBreakdownG, 1);
            Assert.AreEqual(actual.TailorMeterG, 2.82);
            Assert.AreEqual(actual.TailorMeterC, 1.57);
            Assert.AreEqual(actual.TailorKepingG, 4);
            Assert.AreEqual(actual.TailorKepingC, 2);
        }
    }
}