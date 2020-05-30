using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F90_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Tinggi / 60.0) * input.Set;
            result.UpahKainA = result.Keping * 43;

            double kainMeterA = (input.Lebar + 15) / 39.0 * 2 * input.Set;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Math.Round((double)(result.Keping / input.Set));
            result.TailorMeterA = Math.Round((input.Tinggi + 10) / 39.0, 2);
            result.TailorKepingA = Math.Round(result.Keping * 5.0, 1);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
