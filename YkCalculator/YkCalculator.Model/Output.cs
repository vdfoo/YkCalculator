using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Output
    {
        public int QuotationId { get; set; }
        public Input Input { get; set; }

        public int Keping { get; set; }
        public double Upah1 { get; set; }
        public double Upah2Cincin { get; set; }
        public double Kain { get; set; }
        public double Jumlah { get; set; }

        public int TailorKeping { get; set; }
        public double TailorTinggi { get; set; }
    }
}
