using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F25_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(result.Keping * 1.6 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round(Math.Ceiling((input.Lebar + 10) / 39.0 * input.HargaKainB * 2) * input.Set, 2);
            result.UpahHook = Math.Round(input.HargaHook * result.Keping, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round(1.55 * 2, 2);
            result.TailorTinggiB = Math.Round((input.Lebar + 5) / 39.0, 2);
            result.TailorTotalKeping = result.TailorKeping;

            return result;
        }
    }
}
