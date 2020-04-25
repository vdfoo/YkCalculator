using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Order
    {
        public int Id { get; set; }
        public List<string> QuotationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Output> QuotationDetail { get; set; }
        public double TotalTailorKeping { get; set; }
        public double TotalBeforeDiscount { get; set; }
        public double TotalAfterDiscount { get; set; }
        public int MemberId { get; set; }
    }
}
