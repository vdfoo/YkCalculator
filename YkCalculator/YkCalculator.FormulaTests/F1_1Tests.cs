using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Formula;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Formula.Tests
{
    [TestClass()]
    public class F1_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            F1_1_Input input = new F1_1_Input
            {
                Set = 1,
                Harga = 12,
                Lebar = 120,
                Tinggi = 110
            };

            F1_1 formula = new F1_1();
            F1_1_Result actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 263.31);
            Assert.AreEqual(actual.Kain, 192.31);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTinggi, 3.08);
            Assert.AreEqual(actual.Upah1, 15);
            Assert.AreEqual(actual.Upah2Cincin, 56);
        }
    }
}