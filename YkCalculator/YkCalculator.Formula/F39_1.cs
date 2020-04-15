using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F39_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            result.HargaKainA = Math.Round(((32 + input.HargaCincin) * 1.6 + 3) * 2 * input.Set, 2);
            result.HargaKainB = Math.Round(((32 + input.HargaCincin) * 1.8 + 3) * 2 * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);

            result.TailorKeping = result.Keping;
            result.TailorMeterK = 1.56;
            result.TailorJalur = 4;
            result.TailorTinggi = result.TailorJalur;
            result.TailorTinggiB = result.TailorMeterK;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
