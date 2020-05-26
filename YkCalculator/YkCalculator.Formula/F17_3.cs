using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F17_3 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = input.Keping;
            result.KepingA = input.KepingA * input.Set;
            result.KepingB = input.KepingB * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = result.KepingA * 1.6;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            double kainMeterB = result.KepingB * 2.94;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook, 
                result.HargaTaliLangsir);

            result.TailorKepingBreakdownA = Math.Round(result.KepingA / 2.0 / input.Set, 1);
            result.TailorKepingBreakdownB = Math.Round(result.KepingB / 2.0 / input.Set, 1);
            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round(1.5 * result.TailorKepingBreakdownA, 2);
                result.TailorMeterB = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingA = result.KepingB;
                result.TailorKepingB = result.KepingB;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round(1.5 * result.TailorKepingBreakdownA, 2);
                result.TailorMeterB = Math.Round((input.Tinggi + 10) * 2 / 39.0, 2);
                result.TailorKepingA = result.KepingB;
                result.TailorKepingB = result.TailorKepingBreakdownB * input.Set;
            }

            return result;
        }
    }
}
