using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class S1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                Lebar = 100,
                Tinggi = 104,
                Layout = "T",
            };

            IFormula formula = new S1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 261.60);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.HargaKainA, 249.60);
            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorMeterA, 3);
            Assert.AreEqual(actual.TailorKepingA, 2);

            input.Layout = "L";
            actual = formula.Calculate(input);

            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorMeterA, 5.88);
            Assert.AreEqual(actual.TailorKepingA, 1);
        }
    }
}