using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic.Tests
{
    [TestClass()]
    public class F97Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F97";
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.1", "Rod Kayu", string.Empty, 0)); 
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.2", "Aluminium Rail", string.Empty, 0)); 

            foreach (var p in input.ReadyMadeProduct)
            { 
                p.Quantity = 2;
                p.Meter = 2;
            }

            RodSetOutput actual = new F97().Calculate(input);

            //Assert.AreEqual(actual.Transportation, 100);
            Assert.AreEqual(actual.RodOnlySubtotal, 92);
            Assert.AreEqual(actual.RodSetTotal, 92);
        }
    }
}