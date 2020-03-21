using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F1_2Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 120,
                Tinggi = 110,
                HargaCincin = 11.2,
                Lipat = 3
            };

            IFormula formula = new F1_2();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 368.63);
            Assert.AreEqual(actual.HargaKainA, 269.23);
            Assert.AreEqual(actual.Keping, 7);
            Assert.AreEqual(actual.TailorKeping, 7);
            Assert.AreEqual(actual.TailorTinggi, 3.08);
            Assert.AreEqual(actual.UpahKainA, 21);
            Assert.AreEqual(actual.UpahCincin, 78.40);
        }
    }
}