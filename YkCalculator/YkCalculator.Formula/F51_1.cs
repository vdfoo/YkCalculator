﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

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

            double kainMeterA = (input.Tinggi + 10) / 39.0 * 2 * input.Set / 4;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            
            double kainMeterB = (input.Tinggi + 10) / 39.0 * 2 * input.Set;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.UpahHook + result.UpahKainA + 
                result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.HargaKainA, result.HargaKainB, result.UpahHook, result.UpahKainA,
                result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorHeaderKepingA = 9999;
            result.TailorMeterA = 9999;
            result.TailorKepingA = 9999;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterB = Math.Round((input.Lebar + 5) / 39.0, 2);
                result.TailorKepingB = result.TailorKeping * input.Set;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterB = Math.Round((input.Lebar * 2 + 5) / 39.0, 2);
                result.TailorKepingB = input.Set;
            }

            return result;
        }
    }
}
