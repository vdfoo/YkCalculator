using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F19_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 5) / 60 * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Lebar * 6) / 39 * input.HargaKainA * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaTaliLangsir, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round(((input.Lebar * 5 / 39.0) - 0.5) / 2, 2);
            result.TailorTotalKeping = result.TailorKeping;

            return result;
        }
    }
}
