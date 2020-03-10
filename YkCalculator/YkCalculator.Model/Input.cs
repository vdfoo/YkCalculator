using System.Collections.Generic;

namespace YkCalculator.Model
{
    public class Input
    {
        public int Set { get; set; }
        public int Lebar { get; set; }
        public int Tinggi { get; set; }

        public double HargaKainA { get; set; }
        public double HargaKainB { get; set; }
        public double HargaKainC { get; set; }

        public double HargaCincin { get; set; }
        public double HargaHook { get; set; }

        public int Lipat { get; set; }

        public string Tempat { get; set; }
    }
}
