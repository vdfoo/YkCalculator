using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Output
    {
        public int QuotationId { get; set; }
        //public string FormulaCode { get; set; }
        public List<string> Image { get; set; }

        public Input Input { get; set; }

        public int Keping { get; set; }
        public int KepingB { get; set; }
        public double UpahKainA { get; set; }
        public double UpahKainB { get; set; }
        public double UpahCincin { get; set; }
        public double UpahButang { get; set; }
        public double UpahHook { get; set; }
        public double HargaKainA { get; set; }
        public double HargaKainB { get; set; }
        public double Jumlah { get; set; }

        public int TailorKeping { get; set; }
        public double TailorTinggi { get; set; }
        public double TailorTinggiB { get; set; }
        public double TailorJalur { get; set; }
        public double TailorRenda { get; set; }
        public double TailorRendaKeping { get; set; }
        public double TailorTotal { get; set; }
    }
}

