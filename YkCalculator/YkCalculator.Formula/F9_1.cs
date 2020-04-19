﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F9_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 12.0) * input.Set;
            result.KepingB = 6 * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 15) / 39 * input.HargaKainA * result.KepingB, 2);
            result.UpahHook = Math.Round(Math.Ceiling((double)input.Lebar / 3.5) * input.HargaHook * input.Set, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook, 2);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.KepingB, input.Layout);
            result.TailorMeter = Math.Round((double)(input.Tinggi + 10) / 39, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
