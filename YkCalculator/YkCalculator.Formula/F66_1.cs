﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F66_1 : FormulaBase, IFormula
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
                result.HargaKainA = Math.Round((input.Lebar * 3.5) / 39.0 * input.HargaKainA * input.Set, 2);
                result.HargaKainB = Math.Round((input.Lebar * 3.5) / 39.0 * input.HargaKainA * input.Set, 2);
            }
            else
            {
                result.HargaKainA = Math.Round((input.Lebar * 3.5) / 39.0 / 2 * input.HargaKainA * input.Set, 2);
                result.HargaKainB = Math.Round((input.Lebar * 3.5) / 39.0 / 2 * input.HargaKainA * input.Set, 2);
            }

            result.HargaKainC = Math.Round(2 *input.HargaKainA * input.Set, 2);
            result.HargaRenda = Math.Round(input.Lebar * 3.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaRenda2 = Math.Round(input.Lebar * 3.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaRenda3 = Math.Round(1.5 * 2 * input.HargaRenda * input.Set, 2);
            result.HargaButang = Math.Round(input.Lebar / 3 * input.HargaButang * input.Set, 2);

            result.Jumlah = Math.Round(result.HargaRainbow + result.UpahKainA + result.UpahHook + result.HargaKainA +
                result.HargaKainB + result.HargaKainC + result.HargaRenda + result.HargaRenda2 + result.HargaRenda3 + 
                result.HargaButang, 2);

            result.TailorMeterA = 9999;
            result.TailorRenda = Math.Round((input.Lebar - 10) / 39.0 * 3 * input.RendaQuantity, 2);
            result.TailorRenda2 = Math.Round((input.Lebar - 10) / 39.0 * 3 * input.RendaQuantity, 2);
            result.TailorRenda3 = 2;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}