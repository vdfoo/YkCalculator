using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F68_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 12.0) * input.Set;
            result.HargaRainbow = input.RainbowQuantity * 5 * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.HargaTariScallet = Math.Round(120 / 30.0 * input.HargaTali, 2);
            result.UpahHook = input.Lebar / 4 * input.HargaHook * input.Set;

            double kainMeterA = 0.00;
            if (input.Tinggi > 24)
            {
                kainMeterA = (input.Lebar * 3.5) / 39.0 / 2 * input.Set;
            }
            else
            {
                kainMeterA = (input.Lebar * 3.5) / 39.0 / 3 * input.Set;
            }

            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);

            double kainMeterB = (input.Lebar + 15) / 39.0 * input.Set;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainA, result.HargaKainB);

            double kainMeterC = input.Set;
            result.HargaKainC = Math.Round(kainMeterC * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainC), kainMeterC, input.HargaKainA, result.HargaKainC);

            double rendaMeter1 = input.Lebar * 3.5 / 39.0 * input.RendaQuantity * input.Set;
            result.HargaRenda = Math.Round(rendaMeter1 * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda), rendaMeter1, input.HargaRenda, result.HargaRenda);

            double rendaMeter2 = input.Lebar * 1.5 / 39.0 * input.RendaQuantity * input.Set;
            result.HargaRenda2 = Math.Round(rendaMeter2 * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda2), rendaMeter2, input.HargaRenda, result.HargaRenda2);

            double rendaMeter3 = 1.5 * 2 * input.Set;
            result.HargaRenda3 = Math.Round(rendaMeter3 * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda3), rendaMeter3, input.HargaRenda, result.HargaRenda3);

            result.HargaButang = Math.Round(input.Lebar / 3 * input.HargaButang * input.Set, 2);
            result.HargaCincin = Math.Round(120 / 30 * 2 * input.HargaCincin * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaRainbow + result.UpahKainA + result.HargaTariScallet + result.UpahHook +
                result.HargaKainA + result.HargaKainB + result.HargaKainC + result.HargaRenda + result.HargaRenda2 +
                result.HargaRenda3 + result.HargaButang + result.HargaCincin + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.HargaRainbow, result.UpahKainA, result.HargaTariScallet, result.UpahHook,
                result.HargaKainA, result.HargaKainB, result.HargaKainC, result.HargaRenda, result.HargaRenda2,
                result.HargaRenda3, result.HargaButang, result.HargaCincin, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
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
