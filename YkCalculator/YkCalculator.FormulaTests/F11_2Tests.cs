using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F11_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 28,
                Lebar = 56,
                Tinggi = 100,
                Layout = "L",
            };

            IFormula formula = new F11_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 100.77);
            Assert.AreEqual(actual.HargaKainA, 94.77);
            Assert.AreEqual(actual.UpahKainA, 6.00);
            Assert.AreEqual(actual.Keping, 2);
            Assert.AreEqual(actual.TailorTotalKeping, 2);
            Assert.AreEqual(actual.TailorKeping, 1);
            Assert.AreEqual(actual.TailorMeterA, 3.13);
            Assert.AreEqual(actual.TailorKepingA, 1);

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 1);
            Assert.AreEqual(actual.TailorMeterA, 1.56);
            Assert.AreEqual(actual.TailorKepingA, 2);
        }
    }
}
