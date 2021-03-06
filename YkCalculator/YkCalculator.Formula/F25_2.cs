﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F25_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeterA = result.Keping * 1.6;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            double kainMeterB = (input.Lebar + 10) / 39 * 2 * input.Set;
            result.HargaKainB = Math.Round(Math.Ceiling((input.Lebar + 10) / 39.0 * input.HargaKainB * 2) * input.Set, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            result.UpahHook = Math.Round(input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaKainB, result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;
            result.TailorHeaderKepingA = result.Keping / input.Set;
            result.TailorMeterA = Math.Round(1.55 * 2, 2);
            result.TailorKepingA = Math.Round(result.Keping / 2.0, 1);

            if (input.Layout.Equals("T"))
            {
                result.TailorKeping = Math.Round(result.Keping / 2.0 / input.Set, 1);
                result.TailorMeterB = Math.Round((input.Lebar + 5) / 39.0, 2);
                result.TailorKepingB = Math.Round((double)(result.Keping), 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKeping = 1;
                result.TailorMeterB = Math.Round((input.Lebar + 5) * 2 / 39.0, 2);
                result.TailorKepingB = result.TailorKeping * input.Set;
            }

            return result;
        }
    }
}
