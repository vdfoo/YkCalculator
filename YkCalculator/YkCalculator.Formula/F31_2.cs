﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F31_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.KepingB = (int)Math.Ceiling((double)input.Lebar / 30) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahKainB = Math.Round((double)result.KepingB * 3, 2);

            double kainMeterA1 = 1.8 * result.Keping / 2;
            result.HargaKainA1 = Math.Round(kainMeterA1 * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA1), kainMeterA1, input.HargaKainB, result.HargaKainA1);

            double kainMeterA2 = 1.8 * result.Keping / 2;
            result.HargaKainA2 = Math.Round(kainMeterA2 * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA2), kainMeterA2, input.HargaKainB, result.HargaKainA2);

            double kainMeterA3 = 1.8 * result.Keping;
            result.HargaKainA3 = Math.Round(kainMeterA3 * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA3), kainMeterA3, input.HargaKainA, result.HargaKainA3);

            double kainMeterA4 = 1.8 * result.Keping;
            result.HargaKainA4 = Math.Round(kainMeterA4 * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA4), kainMeterA4, input.HargaKainA, result.HargaKainA4);

            double kainMeterA = Math.Round(result.HargaKainA1 + result.HargaKainA2 + result.HargaKainA3 + result.HargaKainA4, 2);
            result.HargaKainA = kainMeterA;
            result.DetailedBreakdown += GetKainABreakdown(kainMeterA, nameof(Output.HargaKainA), result.HargaKainA1, result.HargaKainA2, result.HargaKainA3, result.HargaKainA4);

            double kainMeterB = (input.Lebar + 10) / 39.0 * result.KepingB / 2;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);

            result.UpahCincin = Math.Round(input.HargaCincin * result.Keping, 2);
            result.UpahHook = Math.Round(input.HargaHook * result.KepingB, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahKainB + result.HargaKainB + 
                result.UpahHook + result.UpahCincin + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.UpahKainB, result.HargaKainB,
                result.UpahHook, result.UpahCincin, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping + result.KepingB;
            result.TailorKeping = Transform.TailorKeping(result.KepingB, input.Layout, input.Set);
            result.TailorRenda1 = 14.49;
            result.TailorRenda2 = 14.49;
            result.TailorMeterA = 9999;
            result.TailorMeterB = 9999;
            result.TailorKepingA = input.Set;
            result.TailorKepingB = input.Set;
            result.TailorHeaderKepingA = Math.Round((double)(result.Keping / input.Set), 1);
            result.TailorHeaderKepingB = Math.Round((double)(result.Keping / input.Set), 1);
            if (input.Layout.Equals("T"))
            {
                result.TailorBodyMeter = Math.Round((input.Lebar + 5) / 39.0, 2);
                result.TailorBodyKeping = Math.Round(result.KepingB / 2.0, 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorBodyMeter = Math.Round((input.Lebar + 5) * 2 / 39.0, 2);
                result.TailorBodyKeping = input.Set;
            }

            return result;
        }
    }
}
