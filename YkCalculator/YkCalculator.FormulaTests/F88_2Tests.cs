using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F88_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 7,
                Lebar = 102,
                Tinggi = 100,
                HargaHook = 1.5,
                HargaRenda = 5,
                RendaQuantity = 1,
                Layout = "L",
            };

            IFormula formula = new F88_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.Jumlah, 111.89);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.UpahHook, 6);
            Assert.AreEqual(actual.HargaKainA, 22.40);
            Assert.AreEqual(actual.HargaKainB, 39.49);
            Assert.AreEqual(actual.HargaRenda, 32);
            Assert.AreEqual(actual.TailorHeaderKepingA, 1);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorMeterA, 3.06);
            Assert.AreEqual(actual.TailorKepingA, 1);
            Assert.AreEqual(actual.TailorKepingB, 1);
            Assert.AreEqual(actual.TailorMeterB, 5.49);
            Assert.AreEqual(actual.TailorTotalKeping, 4);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorKepingB, 4);
            Assert.AreEqual(actual.TailorMeterB, 2.74);
        }
    }
}