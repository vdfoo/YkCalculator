using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F17_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 30.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = (input.Lebar + 15) / 39.0 * input.Set;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            double kainMeterB = (input.Lebar + 15) / 39.0 * input.Set;
            result.HargaKainB = Math.Round((double)(input.Lebar + 15) / 39 * input.HargaKainB * input.Set, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook,
                result.HargaTaliLangsir);

            result.TailorKepingBreakdownA = Math.Round(result.Keping / 4.0 / input.Set, 1);
            result.TailorKepingBreakdownB = Math.Round(result.Keping / 4.0 / input.Set, 1);
            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round((input.Lebar + 10) / 39.0 / 2, 2);
                result.TailorMeterB = Math.Round((input.Lebar + 10) / 39.0 / 2, 2);
                result.TailorKepingA = Math.Round(result.Keping / 2.0, 1);
                result.TailorKepingB = Math.Round(result.Keping / 2.0, 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round((input.Lebar + 10) / 39.0 / 2, 2);
                result.TailorMeterB = Math.Round((input.Lebar + 10) / 39.0, 2);
                result.TailorKepingA = Math.Round(result.Keping / 2.0, 1);
                result.TailorKepingB = result.TailorKepingBreakdownB * input.Set;
            }

            return result;
        }
    }
}
