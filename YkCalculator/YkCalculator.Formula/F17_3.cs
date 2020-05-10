using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F17_3 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = input.Keping;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)input.HargaKainA * input.KepingA * 1.6, 2);
            result.HargaKainB = Math.Round((double)input.HargaKainB * input.KepingB * 2.94, 2);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorKepingBreakdownA = Math.Round(input.KepingA / 2.0, 1);
            result.TailorKepingBreakdownB = Math.Round(input.KepingB / 2.0, 1);
            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round(1.5 * result.TailorKepingBreakdownA, 2);
                result.TailorMeterB = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingA = input.KepingB;
                result.TailorKepingB = input.KepingB;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round(1.5 * result.TailorKepingBreakdownA, 2);
                result.TailorMeterB = Math.Round((input.Tinggi + 10) * 2 / 39.0, 2);
                result.TailorKepingA = input.KepingB;
                result.TailorKepingB = result.TailorKepingBreakdownB;
            }

            return result;
        }
    }
}
