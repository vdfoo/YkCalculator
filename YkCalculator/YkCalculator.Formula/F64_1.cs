using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F64_1 : FormulaBase, IFormula
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

            double kainMeterA = 0.00;
            if (input.Tinggi > 24)
            {
                kainMeterA = (input.Lebar * 3.5) / 39.0 * input.Set;
            }
            else
            {
                kainMeterA = (input.Lebar * 3.5) / 39.0 / 2 * input.Set;
            }

            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);

            double rendaMeter1 = input.Lebar * 3.5 / 39.0 * input.RendaQuantity * input.Set;
            result.HargaRenda = Math.Round(rendaMeter1 * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda), rendaMeter1, input.HargaRenda, result.HargaRenda);

            result.HargaButang = Math.Round(input.Lebar / 3 * input.HargaButang * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaRainbow + result.UpahKainA + result.UpahHook + result.HargaKainA +
                result.HargaRenda + result.HargaButang + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.HargaRainbow, result.UpahKainA, result.UpahHook, result.HargaKainA,
                result.HargaRenda, result.HargaButang, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorMeterA = 9999;
            result.TailorRenda = Math.Round((input.Lebar * 3) / 39.0, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
