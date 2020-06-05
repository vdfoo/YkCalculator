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
    public class F97_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput rodSetInput = new RodSetInput();
            rodSetInput.FormulaCode = "F97";
            rodSetInput.ReadyMadeProduct = new List<ReadyMadeProduct>();

            ReadyMadeProduct p1 = new ReadyMadeProduct("F97.1", "Rod Kayu", string.Empty, 0)
            {
                Meter = 4,
                Quantity = 2
            };

            ReadyMadeProduct p2 = new ReadyMadeProduct("F97.2", "Aluminium Rail", string.Empty, 0)
            {
                Meter = 3,
                Quantity = 3
            };

            rodSetInput.ReadyMadeProduct.Add(p1);
            rodSetInput.ReadyMadeProduct.Add(p2);

            RodSetOutput rodSetOutput = new F97().Calculate(rodSetInput);

            string jsonOutput = JsonSerializer.Serialize(rodSetOutput);

            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 120,
                Tinggi = 100,
                Layout = "L",
                HargaCincin = 16.8,
                RodSetOutput = rodSetOutput
            };

            IFormula formula = new F97_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.Jumlah, 469.92); 
            Assert.AreEqual(actual.HargaKainA, 176.92);
            Assert.AreEqual(actual.HargaCincin, 84);
            Assert.AreEqual(actual.TailorKeping, 5);
            Assert.AreEqual(actual.TailorTotalKeping, 5);
            Assert.AreEqual(actual.TailorSheer, 1);
            Assert.AreEqual(actual.TailorKainTebal, 1);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2.5);
            Assert.AreEqual(actual.TailorSheer, 1);
            Assert.AreEqual(actual.TailorKainTebal, 1);
            Assert.AreEqual(actual.TailorMeterA, 9999);
        }
    }
}