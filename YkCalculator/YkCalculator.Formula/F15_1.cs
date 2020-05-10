using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F15_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 15) / 39 * input.HargaKainA * result.Keping, 2);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout);
            result.TailorMeterA = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorKepingA = result.Keping;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
