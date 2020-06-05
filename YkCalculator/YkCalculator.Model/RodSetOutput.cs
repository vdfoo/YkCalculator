using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class RodSetOutput
    {
        public string ProductName { get; set; }
        public List<ReadyMadeProduct> ReadyMadeProduct { get; set; }
        //public double Transportation { get; set; }
        public double EndCapSubtotal { get; set; }
        public double BracketSubtotal { get; set; }
        public double RodSubtotal { get; set; }
        public int RodQuantity { get; set; }
        public double RodSetTotal { get; set; }
    }
}
