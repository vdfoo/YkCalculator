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
            double totalBeforeDiscount = 0.0;
            double tailorTotalKeping = 0;
            try
            {
                List<Output> quotations = order.QuotationDetail;
                foreach (Output quotation in quotations)
                {
                    quotationIds.Add(new QuotationDal().Insert(quotation).ToString());
                    totalBeforeDiscount += Math.Round(quotation.Jumlah, 2);
                    tailorTotalKeping += quotation.TailorTotalKeping;
                }

                if(order.PasangRumah)
                {
                    totalBeforeDiscount += 100;
                }

                order.QuotationId = quotationIds;
                order.TotalBeforeDiscount = totalBeforeDiscount;
                order.TotalTailorKeping = tailorTotalKeping;
                ApplyMemberDisount(order, totalBeforeDiscount);

                OrderDal orderDal = new OrderDal();
                result.OrderId = orderDal.Insert(order);

                if(order.MemberId != 0)
                {
                    MemberDal memberDal = new MemberDal();
                    memberDal.InsertMemberOrder(result.OrderId, order.MemberId);
                }

                result.Status = "Success";
            }
            catch (Exception ex)
            {
                result.Status = ex.Message;
            }

            return result;
        }

        public List<Order> SearchOrderByMemberDetail(string searchText, int offset)
        {
            List<Order> result = new List<Order>();
            OrderDal dal = new OrderDal();
            result = dal.ReadAllByUserSearch(searchText, offset);
            return result;
        }

        private static void ApplyMemberDisount(Order order, double totalBeforeDiscount)
        {
            if (order.MemberId != 0)
            {
                order.TotalAfterDiscount = Math.Round(totalBeforeDiscount * .97, 2);
            }
            else
            {
                order.TotalAfterDiscount = totalBeforeDiscount;
            }
        }
    }
}
