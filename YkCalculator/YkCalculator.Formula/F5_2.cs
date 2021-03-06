﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F5_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 12.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            double kainMeter = (input.Lebar * 2.5) / 39 * input.Set;
            result.HargaKainA = Math.Round(kainMeter * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeter, input.HargaKainA, result.HargaKainA);
            result.UpahButang = Math.Round(Math.Ceiling((double)input.Lebar / 4) * input.HargaButang * input.Set, 2);
            result.UpahHook = Math.Round(Math.Ceiling(input.Lebar / 3.5) * input.HargaHook * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahButang + 
                result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.UpahButang,
                result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorKeping = Math.Round(result.Keping / 2.0 / 2.0 / input.Set, 2);
                result.TailorMeterA = Math.Round((input.Lebar * 2.4) / 39 / 2, 2);
                result.TailorKepingA = Math.Round(result.Keping / 5.0);
                
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKeping = 1;
                result.TailorMeterA = Math.Round((input.Lebar * 2.4) / 39, 2);
                result.TailorKepingA = result.TailorKeping * input.Set;
            }

            return result;
        }
    }
}
