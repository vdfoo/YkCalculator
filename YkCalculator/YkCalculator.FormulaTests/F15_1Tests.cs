using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F15_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 101,
                Tinggi = 104,
                HargaHook = 1.50,
                Layout = "L",
            };

            IFormula formula = new F15_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 164.46);
            Assert.AreEqual(actual.HargaKainA, 146.46);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorMeterA, 2.92);
            Assert.AreEqual(actual.TailorKepingA, 4);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
        }
    }
}