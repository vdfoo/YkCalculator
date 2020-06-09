using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F21_2Tests
    {
        [TestMethod()]
        public void CalculateAsingTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 28,
                HargaKainB = 28,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.5,
                Separate = false, //Bersama
                Layout = "L",
            };

            IFormula formula = new F21_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 397.34);
            Assert.AreEqual(actual.HargaKainA, 186.67);
            Assert.AreEqual(actual.HargaKainB, 186.67);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.UpahHook, 12.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            //Assert.AreEqual(actual.TailorHeaderKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 3.21);
            Assert.AreEqual(actual.TailorKepingA, 9999);
            Assert.AreEqual(actual.TailorKepingB, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
        }

        [TestMethod()]
        public void CalculateBersamaTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 28,
                HargaKainB = 28,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 1.5,
                Separate = true, //Bersama
                Layout = "L",
            };

            IFormula formula = new F21_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 391.34);
            Assert.AreEqual(actual.HargaKainA, 186.67);
            Assert.AreEqual(actual.HargaKainB, 186.67);
            Assert.AreEqual(actual.UpahKainA, 12.00);
            Assert.AreEqual(actual.UpahHook, 6.00);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            //Assert.AreEqual(actual.TailorHeaderKepingA, 9999);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.AreEqual(actual.TailorMeterB, 3.21);
            Assert.AreEqual(actual.TailorKepingA, 9999);
            Assert.AreEqual(actual.TailorKepingB, 2);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
        }
    }
}