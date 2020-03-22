using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Location
    {
        public List<string> TingkatBawah { get; set; }
        public List<string> Tempat { get; set; }
        public List<string> Sliding { get; set; }
        public List<string> Tingkap { get; set; }

        public Location()
        {
            TingkatBawah = new List<string>();
            Tempat = new List<string>();
            Sliding = new List<string>();
            Tingkap = new List<string>();
        }
    }
}
