﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F57_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 12) * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = input.Lebar / 4 * input.HargaHook * input.Set;
            result.HargaRainbow = input.RainbowQuantity * 5 * input.Set;

            if (input.Tinggi > 24)
            {
                result.HargaKainA = Math.Round(input.Lebar * 3.5 / 39.0 / 2 * input.HargaKainA * input.Set, 2);
                result.HargaKainB = Math.Round(input.Lebar * 3.5 / 39.0 / 2 * input.HargaKainB * input.Set, 2);
                result.HargaKainC = Math.Round(input.Lebar * 3.5 / 39.0 / 2 * input.HargaKainC * input.Set, 2);
            }
            else
            {
                result.HargaKainA = Math.Round(input.Lebar * 3.5 / 39.0 / 3 * input.HargaKainA * input.Set, 2);
                result.HargaKainB = Math.Round(input.Lebar * 3.5 / 39.0 / 3 * input.HargaKainB * input.Set, 2);
                result.HargaKainC = Math.Round(input.Lebar * 3.5 / 39.0 / 3 * input.HargaKainC * input.Set, 2);
            }

            result.HargaRenda = Math.Round(input.Lebar * 3.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);

            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaKainC + result.UpahHook + result.UpahKainA + result.HargaRenda + result.HargaRainbow, 2);

            result.TailorMeterA = 9999;
            result.TailorMeterB = Math.Round(((input.Lebar * 3) + 5) / 39.0, 2) * input.RendaQuantity;
            result.TailorMeterC = Math.Round(((input.Lebar * 3) + 5) / 39.0, 2) * input.RendaQuantity;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
