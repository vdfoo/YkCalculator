﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F19_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 5) / 60 * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeter = (input.Lebar * 6) / 39.0 * input.Set;
            result.HargaKainA = Math.Round(kainMeter * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeter, input.HargaKainA, result.HargaKainA);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round(((input.Lebar * 5 / 39.0) - 0.5) / 2, 2);
                result.TailorKepingA = Math.Round(result.Keping / 5.0, 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round(((input.Lebar * 5 / 39.0) - 0.5), 2);
                result.TailorKepingA = input.Set;
            }

            return result;
        }
    }
}
