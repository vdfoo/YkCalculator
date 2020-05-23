using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F17_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = input.Keping;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 15) / 39 * input.HargaKainA * input.KepingA, 2);
            result.HargaKainB = Math.Round((double)(input.Tinggi + 15) / 39 * input.HargaKainB * input.KepingB, 2);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook + 
                result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook,
                result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKepingBreakdownA = Math.Round(input.KepingA / 2.0 / input.Set, 1);
            result.TailorKepingBreakdownB = Math.Round(input.KepingB / 2.0 / input.Set, 1);
            result.TailorMeterA = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorMeterB = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorKepingA = input.KepingA;
            result.TailorKepingB = input.KepingB;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}

