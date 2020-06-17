using System.Collections.Generic;

namespace YkCalculator.Model
{
    public class Input
    {
        public string FormulaCode { get; set; }
        public int Set { get; set; }
        public int Lebar { get; set; }
        public int Tinggi { get; set; }
        public int TinggiA { get; set; }
        public int TinggiB { get; set; }

        public double HargaKainA { get; set; }
        public double HargaKainB { get; set; }
        public double HargaKainC { get; set; }
        public double HargaKainG { get; set; }
        public double HargaKainK { get; set; }

        public int Keping { get; set; }
        public int KepingA { get; set; }
        public int KepingB { get; set; }
        public int KepingC { get; set; }
        public int KepingG { get; set; }
        public int KepingK { get; set; }

        public double HargaCincin { get; set; }
        public double HargaCincinB { get; set; }
        public double HargaCincinC { get; set; }
        public double HargaCincinG { get; set; }
        public double HargaCincinK { get; set; }
        public double HargaHook { get; set; }
        public double HargaButang { get; set; }
        public double HargaRenda { get; set; }
        public double HargaTali { get; set; }
        public int TariScalletQuantity { get; set; }
        public int TaliLangsirQuantity { get; set; }
        public int RendaQuantity { get; set; }
        public int RainbowQuantity { get; set; }
        public int RibbonQuantity { get; set; }
        public int ButangChoice { get; set; }
        public double MeterDiscountAmount { get; set; }
        public int Lipat { get; set; }
        public bool Separate { get; set; }
        public bool Hanger { get; set; }
        public List<ReadyMadeProduct> ReadyMadeProduct { get; set; }
        public LocationInput Location { get; set; }
        public string Layout { get; set; }
        public RodSetOutput RodSetOutput { get; set; }
    }
}

