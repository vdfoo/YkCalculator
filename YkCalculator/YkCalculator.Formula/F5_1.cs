﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F5_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 12.0) * input.Set;
            result.KepingB = (int)Math.Ceiling(input.Lebar * 2.5 / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((input.Tinggi + 15) / 39.0 * input.HargaKainA * result.KepingB, 2);
            result.UpahButang = Math.Round(Math.Ceiling(input.Lebar / 4.0) * input.HargaButang * input.Set, 2);
            result.UpahHook = Math.Round(Math.Ceiling(input.Lebar / 3.5) * input.HargaHook * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahButang + 
                result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.KepingB, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorKepingA = Math.Round((double)(result.KepingB / input.Set), 1);
                result.TailorMeterA = Math.Round((input.Tinggi + 10) / 39.0, 2);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKepingA = Math.Round((double)(result.KepingB / input.Set), 1);
                result.TailorMeterA = Math.Round((input.Tinggi + 10) / 39.0, 2);
            }

            return result;
        }
    }
}
