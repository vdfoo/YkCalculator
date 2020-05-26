using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F3_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 30.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahCincin = Math.Round(1.6 * result.Keping * input.HargaCincin, 2);
            double kainMeter = 1.6 * result.Keping;
            result.HargaKainA = Math.Round(kainMeter * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeter, input.HargaKainA, result.HargaKainA);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahCincin + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.UpahCincin, result.HargaKainA, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = 3;
                result.TailorKepingA = result.TailorKeping * input.Set;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = 5.88;
                result.TailorKepingA = input.Set;
            }

            return result;
        }
    }
}
