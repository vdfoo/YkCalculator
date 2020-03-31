using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F27_1_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(result.Keping * 1.8 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.Tinggi + 15) / 39.0 * input.HargaKainB * result.Keping, 2);
            result.UpahCincin = Math.Round(input.HargaCincin * result.Keping, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahCincin, 2);

            result.TailorKeping = result.Keping;
            result.TailorTotalKeping = result.TailorKeping;
            result.TailorJalur = result.Keping * 4;
            result.TailorTinggi = result.TailorJalur / 2;
            result.TailorTinggiB = Math.Round((double)(input.Tinggi + 10) / 39, 2);

            return result;
        }
    }
}
