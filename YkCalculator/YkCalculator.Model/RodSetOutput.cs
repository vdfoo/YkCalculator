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
        public double RodOnlySubtotal { get; set; }
        public int RodQuantity { get; set; }
        public double RodSetTotal { get; set; }

        public int EndCapQuantity { get; set; }
        public int BracketQuantity { get; set; }
        public int Set { get; set; }
    }
}
