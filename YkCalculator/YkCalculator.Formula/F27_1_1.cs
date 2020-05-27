using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F27_1_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = result.Keping * 1.8;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            double kainMeterB = (input.Tinggi + 15) / 39.0 * result.Keping;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            result.UpahCincin = Math.Round(input.HargaCincin * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahCincin
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahCincin, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;
            result.TailorMeterB = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorKepingB = Math.Round((double)(result.Keping), 1);

            if (input.Layout.Equals("T"))
            {
                result.TailorJalur = Math.Round(result.Keping * 4.0 / 2 / input.Set, 1);
                result.TailorKepingA = input.Set * 2;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorJalur = Math.Round(result.Keping * 4.0 / input.Set, 1);
                result.TailorKepingA = 1;
            }

            return result;
        }
    }
}
