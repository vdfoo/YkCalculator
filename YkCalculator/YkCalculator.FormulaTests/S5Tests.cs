using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class S5Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 18,
                Lebar = 101,
                Tinggi = 104,
                HargaHook = 1.5,
                Layout = "T",
            };

            IFormula formula = new S5();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 120.60);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.UpahHook, 6);
            Assert.AreEqual(actual.HargaKainA, 102.60);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorMeterA, 2.72);
            Assert.AreEqual(actual.TailorKepingA, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "L";
            actual = formula.Calculate(input);

            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorMeterA, 5.31);
            Assert.AreEqual(actual.TailorKepingA, 1);
        }
    }
}