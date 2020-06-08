using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F17_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = input.Keping;
            result.KepingA = input.KepingA;
            result.KepingB = input.KepingB;

            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = (input.Tinggi + 15) / 39.0 * result.KepingA;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            double kainMeterB = (input.Tinggi + 15) / 39.0 * result.KepingB;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            result.UpahHook = Math.Round(input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook + 
                result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook,
                result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKepingBreakdownA = Math.Round(result.KepingA / 2.0 / input.Set, 1);
            result.TailorKepingBreakdownB = Math.Round(result.KepingB / 2.0 / input.Set, 1);
            result.TailorMeterA = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorMeterB = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorKepingA = result.KepingA;
            result.TailorKepingB = result.KepingB;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}

