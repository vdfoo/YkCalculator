﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F17_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 30.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Lebar + 15) / 39 * input.HargaKainA * input.Set, 2);
            result.HargaKainB = Math.Round((double)(input.Lebar + 15) / 39 * input.HargaKainB * input.Set, 2);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout);
            result.TailorMeter = Math.Round((double)(input.Lebar + 10) / 39, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
