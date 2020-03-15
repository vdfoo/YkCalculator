using System;
using System.Collections.Generic;
using YkCalculator.DAL;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class OrderManager
    {
        public OrderResult PlaceOrder(Order order)
        {
            OrderResult result = new OrderResult();
            List<string> quotationIds = new List<string>();
            try
            { 
                List<Output> quotations = order.QuotationDetail;
                foreach (Output quotation in quotations)
                {
                    quotationIds.Add(new QuotationDal().Insert(quotation).ToString());
                }

                order.QuotationId = quotationIds;
                OrderDal dal = new OrderDal();
                result.OrderId = dal.Insert(order);
                result.Status = "Success";
            }
            catch (Exception ex)
            {
                result.Status = ex.Message;
            }

            return result;
        }
    }
}
