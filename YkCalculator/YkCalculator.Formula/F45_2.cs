﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F45_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            result.HargaKainA = Math.Round(1.8 * result.Keping / 2 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round(((input.HargaKainB + input.HargaCincin) * 1.8 + 3) * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = 9999;
            result.TailorTinggiB = 3;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
