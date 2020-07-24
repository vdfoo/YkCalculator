using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using System.Text.Json;
using YkCalculator.Utility;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F97_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput rodSetInput1 = new RodSetInput();
            rodSetInput1.FormulaCode = "F97";
            rodSetInput1.ReadyMadeProduct = new List<ReadyMadeProduct>();
            rodSetInput1.Sequence = 1;
            rodSetInput1.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.1", Constant.RodKayuHitam, string.Empty, 0));

            foreach (var p in rodSetInput1.ReadyMadeProduct)
            {
                p.Quantity = 2;
                p.Meter = 2;
            }

            RodSetOutput rodSetOutput1 = new F97().Calculate(rodSetInput1);

            RodSetInput rodSetInput2 = new RodSetInput();
            rodSetInput2.FormulaCode = "F97";
            rodSetInput2.ReadyMadeProduct = new List<ReadyMadeProduct>();
            rodSetInput2.Sequence = 2;
            rodSetInput2.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.4", Constant.RodAluminiumMeroon, string.Empty, 0));

            foreach (var p in rodSetInput2.ReadyMadeProduct)
            {
                p.Quantity = 2;
                p.Meter = 2;
            }

            RodSetOutput rodSetOutput2 = new F97().Calculate(rodSetInput2);

            Input input = new Input
            {
                Set = 1,
                HargaKainA = 12,
                Lebar = 120,
                Tinggi = 100,
                Layout = "L",
                HargaCincin = 16.8,
                RodSetOutput = rodSetOutput1,
                RodSetOutput2 = rodSetOutput2,
            };

            IFormula formula = new F97_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 5);
            Assert.AreEqual(actual.Jumlah, 479.92); 
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