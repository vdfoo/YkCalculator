using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F55_1 : FormulaBase, IFormula
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

            double kainMeterA = 0.00;
            double kainMeterB = 0.00;
            double kainMeterC = 0.00;
            if (input.Tinggi > 24)
            {
                kainMeterA = input.Lebar * 3.5 / 39.0 * input.Set;
                kainMeterB = input.Lebar * 3.5 / 39.0 * input.Set;
                kainMeterC = input.Lebar * 3.5 / 39.0 * input.Set;

            }
            else
            {
                kainMeterA = input.Lebar * 3.5 / 39.0 / 2 * input.Set;
                kainMeterB = input.Lebar * 3.5 / 39.0 / 2 * input.Set;
                kainMeterC = input.Lebar * 3.5 / 39.0 / 2 * input.Set;
            }

            result.HargaKainA = Math.Round(input.HargaKainA * kainMeterA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);
            result.HargaKainB = Math.Round(input.HargaKainB * kainMeterB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);
            result.HargaKainC = Math.Round(input.HargaKainC * kainMeterC, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainC), kainMeterC, input.HargaKainC, result.HargaKainC);

            double rendaMeter = input.Lebar * 3.5 / 39 * input.RendaQuantity * input.Set;
            result.HargaRenda = Math.Round(rendaMeter * input.HargaRenda, 2);
            result.HargaRenda = Math.Round(rendaMeter * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda), rendaMeter, input.HargaRenda, result.HargaRenda);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaKainC + result.UpahHook + 
                result.UpahKainA + result.HargaRenda + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.HargaKainA, result.HargaKainB, result.HargaKainC, result.UpahHook,
                result.UpahKainA, result.HargaRenda, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorRenda1 = Math.Round(((input.Lebar * 3) + 5) / 39.0, 2);
            result.TailorRenda2 = Math.Round(((input.Lebar * 3) + 5) / 39.0, 2);
            result.TailorMeterA = 9999;
            result.TailorMeterB = 9999;
            result.TailorMeterC = 9999;
            result.TailorRenda = Math.Round(((input.Lebar * 3) + 5) / 39.0 * input.RendaQuantity, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}

