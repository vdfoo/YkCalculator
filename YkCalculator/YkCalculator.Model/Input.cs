using System.Collections.Generic;

namespace YkCalculator.Model
{
    public class Input
    {
        public string FormulaCode { get; set; }
        public int Set { get; set; }
        public int Lebar { get; set; }
        public int Tinggi { get; set; }

        public double HargaKainA { get; set; }
        public double HargaKainB { get; set; }
        public double HargaKainC { get; set; }

        public int Keping { get; set; }
        public int KepingA { get; set; }
        public int KepingB { get; set; }

        public double HargaCincin { get; set; }
        public double HargaHook { get; set; }
        public double HargaButang { get; set; }

        public int Lipat { get; set; }

        public string Tempat { get; set; }
    }
}

