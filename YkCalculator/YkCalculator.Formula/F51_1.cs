﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F51_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 30) * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = result.Keping * input.HargaHook;

            result.HargaKainA = Math.Round((input.Tinggi + 10) / 39.0 * 2 * input.Set * input.HargaKainA / 4, 2);
            result.HargaKainB = Math.Round((input.Tinggi + 10) / 39.0 * 2 * input.Set * input.HargaKainB, 2);

            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.UpahHook + result.UpahKainA, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = 0;
            result.TailorTinggiB = Math.Round((input.Tinggi + 5) / 39.0, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}