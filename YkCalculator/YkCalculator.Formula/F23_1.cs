using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F23_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar * 3.5 / 60.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeter = (input.Lebar * 3.5) / 39.0 * input.Set;
            result.HargaKainA = Math.Round(kainMeter * input.HargaKainA, 2) ;
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeter, input.HargaKainA, result.HargaKainA);
            result.UpahHook = Math.Round(Math.Ceiling(input.Lebar * 3.5) / 4 * input.HargaHook * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
