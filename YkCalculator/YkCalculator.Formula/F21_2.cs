using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F21_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double) 120 / 30) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = (input.Lebar + 10) / 39.0 * 2 * input.Set;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            double kainMeterB = (input.Lebar + 10) / 39.0 * 2 * input.Set;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            if (input.Separate) // understand as Bersama. Cheaper if together.
                result.UpahHook = input.HargaHook * result.Keping;
            else
                result.UpahHook = input.HargaHook * result.Keping * 2;

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorHeaderKepingA = 9999;
            result.TailorTotalKeping = result.Keping;
            result.TailorMeterA = 9999;
            result.TailorMeterB = Math.Round((double)(input.Lebar + 5) / 39, 2);
            result.TailorKepingA = 9999;
            result.TailorKepingB = Math.Round(result.Keping / 2.0, 1);

            return result;
        }
    }
}
