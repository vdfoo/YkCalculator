using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F23_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 32,
                Lebar = 120,
                Tinggi = 100,
                HargaHook = 0.1,
                Layout = "L",
            };

            IFormula formula = new F23_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 376.12);
            Assert.AreEqual(actual.HargaKainA, 344.62);
            Assert.AreEqual(actual.UpahKainA, 21.00);
            Assert.AreEqual(actual.UpahHook, 10.50);
            Assert.AreEqual(actual.Keping, 7);
            Assert.AreEqual(actual.TailorKeping, 7);
            Assert.AreEqual(actual.TailorTotalKeping, 7);
            //Assert.AreEqual(actual.TailorTinggi, 0);
        }
    }
}