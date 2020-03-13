using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.DAL;
using YkCalculator.Model;

namespace YkCalculator.Formula
{
    public class FormulaBase
    {
        public int StoreCalculation(Output output)
        {
            QuotationDal dal = new QuotationDal();
            int id = dal.Insert(output);
            return id;

        }
    }
}
