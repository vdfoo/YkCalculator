﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F97_2_1Tests
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

            Input input = new Input
            {
                Set = 1,
                HargaKainA = 13,
                Lebar = 120,
                Tinggi = 100,
                Layout = "L",
                HargaCincin = 10.5,
                RodSetOutput = rodSetOutput
            };

            IFormula formula = new F97_2_1();
            Output actual = formula.Calculate(input);

            Assert.AreEqual(actual.Keping, 4);
            Assert.AreEqual(actual.Jumlah, 356.40); 
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