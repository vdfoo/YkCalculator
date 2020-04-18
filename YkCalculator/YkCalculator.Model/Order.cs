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

        public int TotalTailorKeping
        {
            get
            {
                int totalTailorKeping = 0;
                if(QuotationDetail != null)
                {
                    foreach (var quotation in QuotationDetail)
                    {
                        totalTailorKeping =+ (int)quotation.TailorTotalKeping;
                    }
                }

                return totalTailorKeping;
            }
        }
    }
}
