using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class SearchOrderCondition
    {
        public string Username { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int OrderIdFrom { get; set; }
        public int OrderIdTo { get; set; }
        public int OrderId { get; set; }
        public int Offset { get; set; }

        public SearchOrderCondition()
        {
            DateFrom = DateTime.Parse("2020-01-01T00:00:00");
            DateTo = DateTime.Parse("2050-01-01T00:00:00");
        }

    }
}
