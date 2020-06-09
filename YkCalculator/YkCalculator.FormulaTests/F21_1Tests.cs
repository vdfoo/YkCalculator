using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F21_1Tests
    {
        [TestMethod()]
        public void CalculateAsingTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 100,
                TinggiA = 24,
                HargaHook = 1.5,
                Separate = false, //Bersama
                Layout = "L",
            };

            IFormula formula = new F21_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 259.23);
            Assert.AreEqual(actual.HargaKainA, 52.31);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.UpahHook, 15.00);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.TailorHeaderKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 2.82);
            Assert.AreEqual(actual.TailorKepingA, 9999);
            Assert.AreEqual(actual.TailorKepingB, 5);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2.5);
        }

        [TestMethod()]
        public void CalculateBersamaTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                HargaKainB = 12,
                Lebar = 120,
                Tinggi = 100,
                TinggiA = 24,
                HargaHook = 1.5,
                Separate = true, //Bersama
                Layout = "L",
            };

            IFormula formula = new F21_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 251.73);
            Assert.AreEqual(actual.HargaKainA, 52.31);
            Assert.AreEqual(actual.UpahKainA, 15.00);
            Assert.AreEqual(actual.UpahHook, 7.50);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 2.82);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2.5);
        }
    }
}