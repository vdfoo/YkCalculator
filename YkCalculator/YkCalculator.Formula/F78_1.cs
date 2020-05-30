using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F78_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 60.0) * input.Set;
            result.HargaRibbon = Math.Round(input.RibbonQuantity * 5.0 * input.Set, 2);
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = input.Lebar / 4 * input.HargaHook * input.Set;

            double kainMeterA = (input.Lebar + 15) / 39.0 * input.Set;
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);

            double rendaMeter1 = input.Lebar * 1.5 / 39.0 * input.RendaQuantity * input.Set;
            result.HargaRenda = Math.Round(rendaMeter1 * input.HargaRenda, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaRenda), rendaMeter1, input.HargaRenda, result.HargaRenda);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaRibbon + result.UpahKainA + result.UpahHook + result.HargaKainA + 
                result.HargaRenda + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.HargaRibbon, result.UpahKainA, result.UpahHook, result.HargaKainA,
                result.HargaRenda, result.HargaTaliLangsir);

            result.TailorInchLabel = "60''";
            result.TailorMeterA = 9999;
            result.TailorRenda = Math.Round((input.Lebar + 10) / 39.0, 2);
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
