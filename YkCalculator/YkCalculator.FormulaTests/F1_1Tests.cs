using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using System.Text.Json;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F1_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            LocationInput locationInput = new LocationInput();
            locationInput.Sliding = "Sliding 4"; 

            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 120,
                Tinggi = 110,
                HargaCincin = 11.2,
                Location = locationInput
            };

            //string jsonOutput = JsonSerializer.Serialize(input);

            IFormula formula = new F1_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Jumlah, 263.31);
            Assert.AreEqual(actual.HargaKainA, 192.31);
            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTinggi, 3.08);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.UpahKainA, 15);
            Assert.AreEqual(actual.UpahCincin, 56);
            
        }
    }
}