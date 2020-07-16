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
    public class F92_1Tests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            RodSetInput input = new RodSetInput();
            input.FormulaCode = "F92_1";
            input.Set = 2;
            input.ReadyMadeProduct = new List<ReadyMadeProduct>();

            //Price: 60, Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 2 x 2 (quantity) x 2 (set) = 8
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.4", "4", Constant.WithoutRing, 30.00));

            //Price: 128, Rod: 2 (quantity), Endcap: 2 x 2 (quantity) x 2 (set) = 8, Bracket: 3 x 2 (quantity) x 2 (set) = 12
            input.ReadyMadeProduct.Add(new ReadyMadeProduct("F92_1.7", "8", Constant.WithRing, 64.00)); 

            foreach (var p in input.ReadyMadeProduct)
                p.Quantity = 2;

            RodSetOutput actual = new F92_1().Calculate(input);

            Assert.AreEqual(actual.RodQuantity, 8); // 2 rod x 2 quantity x 2 set
            Assert.AreEqual(actual.BracketQuantity, 20);
            Assert.AreEqual(actual.BracketSubtotal, 150); //Price: 7.5/unit
            Assert.AreEqual(actual.EndCapQuantity, 16); 
            Assert.AreEqual(actual.EndCapSubtotal, 96); //Price: 6/unit
            Assert.AreEqual(actual.RodOnlySubtotal, 376);
            Assert.AreEqual(actual.RodSetTotal, 622);
        }
    }
}