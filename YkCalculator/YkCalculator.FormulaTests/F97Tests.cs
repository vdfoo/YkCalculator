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
    public class F97Tests
    {
        [TestMethod()]
        public void CalculateTest_Sequence1()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F97";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.Sequence = 1;
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.1", Constant.RodKayuHitam, string.Empty, 0)); 

            foreach (var p in input.ReadyMadeProduct)
            { 
                p.Quantity = 2;
                p.Meter = 2;
            }

            RodSetOutput actual = new F97().Calculate(input);

            Assert.AreEqual(actual.RodOnlySubtotal, 52);
            Assert.AreEqual(actual.RodQuantity, 2);
            Assert.AreEqual(actual.EndCapQuantity, 4);
            Assert.AreEqual(actual.EndCapSubtotal, 24);
            Assert.AreEqual(actual.BracketQuantity, 4);
            Assert.AreEqual(actual.BracketSubtotal, 30);
            Assert.AreEqual(actual.RodSetTotal, 106);
        }

        [TestMethod()]
        public void CalculateTest_Sequence2()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F97";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.Sequence = 2;
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.4", Constant.RodAluminiumMeroon, string.Empty, 0));

            foreach (var p in input.ReadyMadeProduct)
            {
                p.Quantity = 2;
                p.Meter = 2;
            }

            RodSetOutput actual = new F97().Calculate(input);

            Assert.AreEqual(actual.RodOnlySubtotal, 40);
            Assert.AreEqual(actual.RodQuantity, 2);
            Assert.AreEqual(actual.EndCapQuantity, 4);
            Assert.AreEqual(actual.EndCapSubtotal, 26);
            Assert.AreEqual(actual.BracketQuantity, 4);
            Assert.AreEqual(actual.BracketSubtotal, 32);
            Assert.AreEqual(actual.RodSetTotal, 98);
        }
    }
}