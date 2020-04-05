﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F53_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = result.Keping * input.HargaHook;

            result.HargaKainA = Math.Round(result.Keping / 2.0 * 1.6 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.Tinggi - 24 + 15) / 39.0 * result.Keping * input.HargaKainB, 2);

            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.UpahHook + result.UpahKainA, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = 9999;
            result.TailorTinggiB = Math.Round((input.Tinggi - input.MeterDiscountAmount + 10) / 39.0, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}