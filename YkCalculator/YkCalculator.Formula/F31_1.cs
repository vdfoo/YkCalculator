using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F31_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.KepingB = (int)Math.Ceiling((double)input.Lebar / 30) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahKainB = Math.Round((double)result.KepingB * 3, 2);
            result.HargaKainA = Math.Round(1.6 * result.Keping / 2 * input.HargaKainB, 2) +
                                Math.Round(1.6 * result.Keping / 2 * input.HargaKainB, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.Lebar + 10) / 39.0 * input.HargaKainB * result.KepingB / 2, 2);
            result.UpahCincin = Math.Round(input.HargaCincin * result.Keping, 2);
            result.UpahHook = Math.Round(input.HargaHook * result.KepingB, 2);

            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahKainB + result.HargaKainB + result.UpahHook + result.UpahCincin, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = 0;
            result.TailorTinggiB = Math.Round((input.Lebar + 5) / 39.0, 2);
            result.TailorRenda = Math.Round((56 * 10 + 5) / 39.0, 2);
            result.TailorRendaKeping = result.Keping / 5;
            result.TailorTotal = result.TailorKeping + result.KepingB;

            return result;
        }
    }
}
