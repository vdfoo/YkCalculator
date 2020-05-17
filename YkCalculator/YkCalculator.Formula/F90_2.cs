﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F90_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Tinggi / 60.0) * input.Set;
            result.UpahKainA = result.Keping * 43;
            result.HargaKainA = Math.Round((input.Lebar + 15) / 39.0 * input.HargaKainA, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "110''";
            result.TailorMeterA = Math.Round((input.Lebar + 10) / 39.0, 2);
            result.TailorKepingA = Math.Round(result.Keping * 5.0 / input.Set, 1);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
