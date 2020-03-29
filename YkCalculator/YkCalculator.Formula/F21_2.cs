using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F21_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double) 120 / 30) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Lebar + 10) / 39 * 2 * input.HargaKainA * input.Set, 2);
            result.HargaKainB = Math.Round((double)(input.Lebar + 10) / 39 * 2 * input.HargaKainB * input.Set, 2);
            if (input.Separate)
                result.UpahHook = input.HargaHook * result.Keping * 2;
            else
                result.UpahHook = input.HargaHook * result.Keping;

            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook, 2);

            result.TailorKeping = result.Keping;
            result.TailorTotal = result.TailorKeping;
            result.TailorTinggi = Math.Round((double)(input.Lebar * 2 + 5) / 39, 2);
            result.TailorTinggiB = Math.Round((double)(input.Lebar + 5) / 39, 2);

            return result;
        }
    }
}
