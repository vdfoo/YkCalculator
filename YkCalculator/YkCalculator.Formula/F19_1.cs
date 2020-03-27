﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F19_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 5) / 60 * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 20) / 39 * input.HargaKainA * result.Keping, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((double)(input.Tinggi + 15) / 39, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}
