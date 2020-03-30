using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F33_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahKainB = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(Math.Round(1.6 * result.Keping / 2 * input.HargaKainB, 2) +
                                Math.Round(1.6 * 5 * input.HargaKainA, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2), 2) ;
            result.HargaKainB = Math.Round((input.Tinggi + 15) / 39.0 * input.HargaKainB * result.Keping, 2) + result.UpahKainB;
            result.UpahCincin = Math.Round(input.HargaCincin * result.Keping, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);

            result.JumlahA = Math.Round(result.UpahKainA + result.UpahCincin + result.UpahButang + result.HargaKainA, 2);
            result.JumlahB = Math.Round(result.HargaKainB + result.UpahKainA, 2);
            result.Jumlah = Math.Round(result.JumlahA + result.JumlahB, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((56 * 2.5 + 5) / 39.0, 2);
            result.TailorTinggiB = Math.Round((input.Tinggi + 10) / 39.0, 2);
            result.TailorRenda = 7.44;
            result.TailorRendaKeping = Math.Round(result.Keping / 5.0, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}
