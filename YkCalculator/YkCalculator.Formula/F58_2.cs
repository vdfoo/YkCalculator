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

            double kainMeter = (input.Lebar + 15) / 39.0 * input.Set;
            result.HargaKainAB = Math.Round(kainMeter * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainAB), kainMeter, input.HargaKainA, result.HargaKainAB);
            
            double kainMeterC = 0.00;
            if (input.Tinggi > 24)
            {
                kainMeterC = input.Lebar * 3.5 / 39.0 / 2 * input.Set;
            }
            else
            {
                kainMeterC = input.Lebar * 3.5 / 39.0 / 3 * input.Set;
            }

            result.HargaKainC = Math.Round(kainMeterC * input.HargaKainC, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainC), kainMeterC, input.HargaKainC, result.HargaKainC);

            double rendaMeter = input.Lebar * 1.5 / 39.0 * input.RendaQuantity * input.Set;
            result.HargaRenda = Math.Round(rendaMeter * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda), rendaMeter, input.HargaRenda, result.HargaRenda);

            result.HargaButang = Math.Round(input.Lebar / input.ButangChoice * input.HargaButang * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainAB + result.HargaKainC + result.UpahHook + result.UpahKainA + 
                result.HargaRenda + result.HargaRainbow + result.HargaButang + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.HargaKainAB, result.HargaKainC, result.UpahHook, result.UpahKainA,
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
