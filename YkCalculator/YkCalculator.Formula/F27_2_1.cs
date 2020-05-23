using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F27_2_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 30) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(result.Keping * 1.8 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.HargaKainB + input.HargaCincin) * 1.6 * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahCincin
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahCincin, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorJalur = Math.Round(result.Keping * 4.0 / 2 / input.Set, 1);
                result.TailorKepingA = 2 * input.Set;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorKepingB = 2 * input.Set;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorJalur = Math.Round(result.Keping * 4.0 / input.Set, 1);
                result.TailorKepingA = 1 * input.Set;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorKepingB = 1 * input.Set;
            }

            return result;
        }
    }
}
