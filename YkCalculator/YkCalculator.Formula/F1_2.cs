using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F1_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((input.Lebar * input.Lipat) / 56.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahCincin = Math.Round(result.Keping * input.HargaCincin, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 15) / 39 * result.Keping * input.HargaKainA, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.UpahCincin + result.HargaKainA, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}
