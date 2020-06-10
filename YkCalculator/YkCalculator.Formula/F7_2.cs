using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F7_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 12.0) * input.Set;
            result.KepingB = (int)Math.Ceiling(input.Lebar * 2.5 / 60.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeter = (input.Tinggi * 2.5) / 39 * input.Set;
            result.HargaKainA = Math.Round(kainMeter * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeter, input.HargaKainA, result.HargaKainA);
            result.UpahHook = Math.Round(Math.Ceiling((double)input.Lebar / 3.5) * input.HargaHook * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.KepingB, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round((input.Lebar * 2.4) / 39 / 2, 2);
                result.TailorKepingA = Math.Floor(input.Set * 2.0);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round((input.Lebar * 2.4) / 39, 2);
                result.TailorKepingA = input.Set;
            }

            return result;
        }
    }
}
