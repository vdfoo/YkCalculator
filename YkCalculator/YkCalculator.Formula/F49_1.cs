using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F49_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 3 / 60) * input.Set;
            result.KepingA = result.Keping / 2;
            result.KepingB = result.Keping;
            result.HargaKainA = Math.Round(1.6 * input.HargaKainA * 2, 2);
            result.HargaKainB = Math.Round((((input.Tinggi - input.MeterDiscountAmount + 15) / 39 * 12) + input.HargaCincin + 3) * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout);
            result.TailorTotalKeping = result.Keping;
            result.TailorHeaderKepingA = 9999;
            result.TailorMeterA = 9999;
            result.TailorKepingA = 9999;
            result.TailorMeterB = Math.Round(((input.Tinggi - input.MeterDiscountAmount) + 10) / 39, 2);
            result.TailorKepingB = result.KepingB;
            return result;
        }
    }
}
