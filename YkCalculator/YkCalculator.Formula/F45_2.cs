using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F45_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.HargaCincin = Math.Round(1.8 * input.HargaCincin * result.Keping, 2);

            double kainMeterA = 0.00;
            if (input.Tinggi > 27)
            {
                kainMeterA = Math.Round(1.8 * result.Keping, 2);
            }
            else
            {
                kainMeterA = Math.Round(1.8 * result.Keping / 2, 2);
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

            result.TailorInchLabel = "60'';110''";
            result.TailorTotalKeping = result.Keping;
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorHeaderKepingA = 9999;
            result.TailorMeterA = 9999;
            result.TailorKepingA = 9999;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39, 2);
                result.TailorKepingB = Math.Round(result.Keping / 2.0, 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterB = Math.Round((((56 * result.TailorKeping / 2) * 2) + 5) / 39, 2);
                result.TailorKepingB = input.Set;
            }

            return result;
        }
    }
}
