﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F13_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 60.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeter = (input.Tinggi + 15) / 39.0 * input.Set;
            result.HargaKainA = Math.Round(kainMeter * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeter, input.HargaKainA, result.HargaKainA);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Math.Round((double)(result.Keping / input.Set), 1);
            result.TailorMeterA = Math.Round((double)(input.Tinggi + 12) / 39, 2);
            result.TailorKepingA = result.Keping;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
