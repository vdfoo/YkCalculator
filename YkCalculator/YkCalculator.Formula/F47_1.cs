using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F47_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            result.KepingA = result.Keping;
            result.KepingB = (int)Math.Ceiling(result.Keping / 4.0);
            
            result.UpahKainA = result.Keping * 3;
            result.HargaCincin = 1.8 * result.Keping * input.HargaCincin;

            double kainMeterA = 0.00;
            if (input.Tinggi > 27)
            {
                kainMeterA = Math.Round(1.8  * (result.Keping / 2), 2);
            }
            else
            {
                kainMeterA = Math.Round(1.8 * (result.Keping / 4), 2);
            }

            result.HargaKainA = kainMeterA * input.HargaKainA;
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);

            double kainMeterB = 1.8 * result.Keping;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaCincin + result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaCincin, result.HargaKainA, result.HargaKainB, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;
            result.TailorHeaderKepingA = 9999;
            result.TailorMeterA = 9999;
            result.TailorKepingA = 9999;
            if (input.Layout.Equals("T"))
            {
                result.TailorJalur = Math.Round((double)(result.Keping * 2 / input.Set), 1);
                result.TailorKepingB = result.TailorKeping * input.Set;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorJalur = Math.Round((double)(result.Keping * 4 / input.Set), 1);
                result.TailorKepingB = input.Set;
            }

            return result;
        }
    }
}
