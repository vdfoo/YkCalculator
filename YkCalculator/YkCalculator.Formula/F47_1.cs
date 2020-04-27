using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F47_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            input.KepingA = result.Keping;
            input.KepingB = (int)Math.Ceiling(result.Keping / 4.0);
            result.HargaKainA = Math.Round(((32 + input.HargaCincin) * 1.8 + 3) * result.Keping, 2);
            result.HargaKainB = Math.Round( 1.8 * input.HargaKainB, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout);
            result.TailorMeter = 0;
            result.TailorJalur = result.Keping * 2;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
