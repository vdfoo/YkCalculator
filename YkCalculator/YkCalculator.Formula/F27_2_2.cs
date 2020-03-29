using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F27_2_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 3 / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(result.Keping * 1.8 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.HargaKainB + input.HargaCincin) * 1.6 * result.Keping, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahCincin, 2);

            result.TailorKeping = result.Keping;
            result.TailorTotal = result.TailorKeping;
            result.TailorJalur = result.Keping * 4;
            result.TailorTinggi = result.TailorJalur / 2;
            result.TailorTinggi2 = Math.Round(1.5 * result.Keping / 2, 2);

            return result;
        }
    }
}
