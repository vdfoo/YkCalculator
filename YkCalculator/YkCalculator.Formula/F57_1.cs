﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F57_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 12) * input.Set;
            result.HargaRainbow = input.RainbowQuantity * 5 * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = input.Lebar / 4 * input.HargaHook * input.Set;

            if (input.Tinggi > 24)
            {
                result.HargaKainA = Math.Round(input.Lebar * 3.5 / 39 * input.HargaKainA * input.Set, 2);
                result.HargaKainB = Math.Round(input.Lebar * 3.5 / 39 * input.HargaKainB * input.Set, 2);
                result.HargaKainC = Math.Round(input.Lebar * 3.5 / 39 * input.HargaKainC * input.Set, 2);
            }
            else
            {
                result.HargaKainA = Math.Round(input.Lebar * 3.5 / 39 / 2 * input.HargaKainA * input.Set, 2);
                result.HargaKainB = Math.Round(input.Lebar * 3.5 / 39 / 2 * input.HargaKainB * input.Set, 2);
                result.HargaKainC = Math.Round(input.Lebar * 3.5 / 39 / 2 * input.HargaKainC * input.Set, 2);
            }

            result.HargaRenda = Math.Round(input.Lebar * 3.5 / 39 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaKainC + result.UpahHook + 
                result.UpahKainA + result.HargaRenda + result.HargaRainbow + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorMeterA = 9999;
            result.TailorMeterB = Math.Round(((input.Lebar * 3) + 5) / 39.0, 2) * input.RendaQuantity;
            result.TailorMeterC = Math.Round(((input.Lebar * 3) + 5) / 39.0, 2) * input.RendaQuantity;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
