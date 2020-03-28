﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F3_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 60.0) * 3 * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.HargaKainA + 7) * 1.6 * result.Keping, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((double)4.44, 2);
            result.TailorTotal = result.TailorKeping;

            return result;
        }
    }
}