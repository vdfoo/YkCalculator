﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F68_1 : FormulaBase, IFormula
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
            result.HargaTariScallet = Math.Round(120 / 30.0 * 5 * input.TariScalletQuantity, 2);
            result.UpahHook = input.Lebar / 4 * input.HargaHook * input.Set;

            if (input.Tinggi > 24)
            {
                result.HargaKainA = Math.Round((input.Lebar * 3.5) / 39.0 * input.HargaKainA * input.Set, 2);
            }
            else
            {
                result.HargaKainA = Math.Round((input.Lebar * 3.5) / 39.0 / 2 * input.HargaKainA * input.Set, 2);
            }

            result.HargaKainB = Math.Round((input.Lebar + 15) / 39.0 * input.HargaKainA * input.Set, 2);
            result.HargaKainC = Math.Round(2 * input.HargaKainA * input.Set, 2);
            result.HargaRenda = Math.Round(input.Lebar * 3.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaRenda2 = Math.Round(input.Lebar * 1.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaRenda3 = Math.Round(1.5 * 2 * input.HargaRenda * input.Set, 2);
            result.HargaButang = Math.Round(input.Lebar / 3 * input.HargaButang * input.Set, 2);
            result.HargaCincin = Math.Round(120 / 30 * 2 * input.HargaCincin * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaRainbow + result.UpahKainA + result.HargaTariScallet + result.UpahHook +
                result.HargaKainA + result.HargaKainB + result.HargaKainC + result.HargaRenda + result.HargaRenda2 +
                result.HargaRenda3 + result.HargaButang + result.HargaCincin + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorMeterA = 9999;
            result.TailorMeterB = 9999;
            result.TailorMeterC = 9999;
            result.TailorRenda1 = Math.Round((input.Lebar - 10) / 39.0 * 3, 2);
            result.TailorRenda2 = Math.Round((input.Lebar + 10) / 39.0, 2);
            result.TailorRenda3 = 2;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
