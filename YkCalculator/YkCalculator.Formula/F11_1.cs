﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F11_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 25) / 39 * 2 * input.HargaKainA * input.Set, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((double)(input.Tinggi + 20) / 39, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}
