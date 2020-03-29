using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F17_3 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = input.Keping;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)input.HargaKainA * input.KepingA * 1.6, 2);
            result.HargaKainB = Math.Round((double)input.HargaKainB * input.KepingB * 2.94, 2);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorTinggiB = Math.Round((double)1.5 * 1.5, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}
