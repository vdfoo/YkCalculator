using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F58_2 : FormulaBase, IFormula
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
            result.HargaKainA = Math.Round((input.Lebar + 15) / 39.0 * input.HargaKainA * input.Set, 2);

            if (input.Tinggi > 24)
            {
                result.HargaKainC = Math.Round(input.Lebar * 3.5 / 39.0 / 2 * input.HargaKainC * input.Set, 2);
            }
            else
            {
                result.HargaKainC = Math.Round(input.Lebar * 3.5 / 39.0 / 3 * input.HargaKainC * input.Set, 2);
            }

            result.HargaRenda = Math.Round(input.Lebar * 1.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaButang = Math.Round(input.Lebar / input.ButangChoice * input.HargaButang * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainC + result.UpahHook + result.UpahKainA + 
                result.HargaRenda + result.HargaRainbow + result.HargaButang + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.HargaKainA, result.HargaKainC, result.UpahHook, result.UpahKainA,
                result.HargaRenda, result.HargaRainbow, result.HargaButang, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;
            result.TailorRenda1 = Math.Round((input.Lebar + 10) / 39.0, 2);
            result.TailorMeterA = 9999;
            result.TailorMeterB = 9999;
            result.TailorRenda = Math.Round((input.Lebar + 10) / 39.0 * 2, 2);


            return result;
        }
    }
}
