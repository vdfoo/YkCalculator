using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F76_1 : FormulaBase, IFormula
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
            result.HargaKainA = Math.Round((input.Lebar + 15) / 39.0 * input.HargaKainA * input.Set, 2);
            result.HargaKainB = Math.Round((input.Lebar + 15) / 39.0 * input.HargaKainA * input.Set, 2);

            result.HargaRenda = Math.Round(input.Lebar * 1.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaRenda2 = Math.Round(input.Lebar * 1.5 / 39.0 * input.HargaRenda * input.RendaQuantity * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.UpahHook + result.HargaKainA + result.HargaKainB + 
                result.HargaRenda + +result.HargaRenda2 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.UpahKainA, result.UpahHook, result.HargaKainA, result.HargaKainB,
                result.HargaRenda, +result.HargaRenda2, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorMeterA = 9999;
            result.TailorMeterB = 9999;
            result.TailorRenda1 = Math.Round((input.Lebar + 10) / 39.0, 2);
            result.TailorRenda2 = Math.Round((input.Lebar + 10) / 39.0, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
