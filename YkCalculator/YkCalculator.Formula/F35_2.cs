using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F35_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);

            double kainMeterA1 = 1.8 * result.Keping / 2;
            result.HargaKainA1 = Math.Round(kainMeterA1 * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA1), kainMeterA1, input.HargaKainB, result.HargaKainA1);

            double kainMeterA2 = 1.6 * result.Keping;
            result.HargaKainA2 = Math.Round(kainMeterA2 * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA2), kainMeterA2, input.HargaKainA, result.HargaKainA2);

            double kainMeterA3 = 1.6 * result.Keping;
            result.HargaKainA3 = Math.Round(kainMeterA3 * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA3), kainMeterA3, input.HargaKainA, result.HargaKainA3);

            double kainMeterA = Math.Round(result.HargaKainA1 + result.HargaKainA2 + result.HargaKainA3, 2);
            result.HargaKainA = kainMeterA;
            result.DetailedBreakdown += GetKainABreakdown(kainMeterA, nameof(Output.HargaKainA), result.HargaKainA1, result.HargaKainA2, result.HargaKainA3);

            double kainMeterB = 1.8 * result.Keping;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);
            result.HargaCincin = input.HargaCincin * result.Keping * 1.8;
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);

            result.Jumlah = Math.Round(result.UpahKainA + result.HargaCincin + result.UpahButang + result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaCincin, result.UpahButang, result.HargaKainA, result.HargaKainB, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorRenda1 = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorRenda2 = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorMeterA = 9999;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorKepingA = 9999;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39, 2);
                result.TailorKepingB = input.Set * result.TailorKeping;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorRenda1 = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
                result.TailorRenda2 = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
                result.TailorMeterA = 9999;
                result.TailorKepingA = 9999;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping / 2) + 5) * 2 / 39.0, 2);
                result.TailorKepingB = input.Set;
            }

            return result;
        }
    }
}
