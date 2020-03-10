using Microsoft.VisualStudio.TestTools.UnitTesting;
using YkCalculator.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.DAL.Tests
{
    [TestClass()]
    public class QuotationTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            Quotation quotation = new Quotation();
            Input input = new Input()
            {
                HargaKainA = 12,
                Tinggi = 110,
                Lebar = 56,
                Set = 5,
                Tempat = "Ruang Tamu"
            };

            //int i = quotation.Read(input);
        }
    }
}