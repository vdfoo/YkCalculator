﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F25_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((result.Keping * 1.6) * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.Tinggi + 15) / 39.0 * input.HargaKainB * result.Keping, 2);
            result.UpahHook = Math.Round(input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorMeterA = Math.Round(1.55 * 2, 2);
            result.TailorMeterB = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorKepingA = Math.Round(result.Keping / 2.0 / input.Set, 1);
            result.TailorKepingB = Math.Round((double)(result.Keping / input.Set), 1);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
