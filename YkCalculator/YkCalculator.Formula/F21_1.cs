using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F21_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = (24 + 10) / 39.0 * result.Keping;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            double kainMeterB = (input.Tinggi + 15) / 39.0 * result.Keping;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            if (input.Separate)
                result.UpahHook = input.HargaHook * result.Keping * 2;
            else
                result.UpahHook = input.HargaHook * result.Keping;

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook + result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;
            result.TailorMeterA = Math.Round((double)(input.TinggiA + 5) / 39, 2);
            result.TailorMeterB = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorKepingA = Math.Round((double)(result.Keping), 1);
            result.TailorKepingB = Math.Round((double)(result.Keping), 1);

            return result;
        }
    }
}

