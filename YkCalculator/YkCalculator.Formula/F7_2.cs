using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F7_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 12.0) * input.Set;
            result.Keping2 = 5 * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi * 2.5) / 39 * input.HargaKainA * input.Set, 2);
            result.UpahHook = Math.Round(Math.Ceiling((double)input.Lebar / 3.5) * input.HargaHook * input.Set, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook, 2);

            result.TailorKeping = result.Keping2;
            result.TailorTinggi = Math.Round((double)(input.Tinggi * 2.4) / 39 / 2, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}
