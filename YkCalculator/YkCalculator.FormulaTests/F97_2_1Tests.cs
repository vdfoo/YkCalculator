using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F97_2_1Tests
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
                HargaKainA = 13,
                Lebar = 120,
                Tinggi = 100,
                Layout = "L",
                HargaCincin = 10.5,
                RodSetOutput = rodSetOutput1,
                RodSetOutput2 = rodSetOutput2,
            };

            IFormula formula = new F97_2_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.Jumlah, 366.40); 
            Assert.AreEqual(actual.HargaKainA, 83.2);
            Assert.AreEqual(actual.UpahKainA, 12);
            Assert.AreEqual(actual.HargaCincin, 67.20);
            Assert.AreEqual(actual.TailorTotalKeping, 4);
            Assert.AreEqual(actual.TailorKeping, 4);
            Assert.AreEqual(actual.TailorSheer, 1);
            Assert.AreEqual(actual.TailorKainTebal, 1);
            Assert.AreEqual(actual.TailorMeterA, 9999);
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Jumlah"));
            Assert.IsTrue(actual.DetailedBreakdown.Contains("Harga"));

            input.Layout = "T";
            actual = formula.Calculate(input);
            Assert.AreEqual(actual.TailorKeping, 2);
            Assert.AreEqual(actual.TailorSheer, 1);
            Assert.AreEqual(actual.TailorKainTebal, 1);
            Assert.AreEqual(actual.TailorMeterA, 9999);
        }
    }
}