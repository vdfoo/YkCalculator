using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F97_2_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 13,
                Lebar = 120,
                Tinggi = 100,
                Layout = "L"
            };

            IFormula formula = new F97_2_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.Jumlah, 181.20);
            Assert.AreEqual(actual.HargaKainA, 181.20);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
        }
    }
}