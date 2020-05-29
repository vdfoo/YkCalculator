using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F33_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahKainB = Math.Round((double)result.Keping * 3, 2);

            double kainMeterA1 = 1.6 * result.Keping / 2;
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

            double kainMeterB = (input.Tinggi + 15) / 39.0 * result.Keping;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);

            result.UpahCincin = Math.Round(input.HargaCincin * result.Keping, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);

            result.Jumlah = Math.Round(result.UpahKainA + result.UpahKainB + result.UpahCincin + result.UpahButang + result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.JumlahA, result.JumlahB, result.UpahKainA, result.UpahKainB,
                result.UpahCincin, result.UpahButang, result.HargaKainA, result.HargaKainB, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorTotalKeping = result.Keping;
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorHeaderKepingA = 1;
            result.TailorMeterB = Math.Round((input.Tinggi + 10) / 39.0, 2);
            result.TailorKepingA = input.Set;
            result.TailorKepingB = Math.Round((double)(result.Keping), 1);

            if (input.Layout.Equals("T"))
            {
                result.TailorRenda1 = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorRenda2 = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorMeterA = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorRenda1 = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
                result.TailorRenda2 = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
                result.TailorMeterA = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
            }

            return result;
        }
    }
}
