using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F15_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Lebar + 10) / 39 * input.HargaKainA * result.Keping / 2, 2);
            result.UpahHook = Math.Round((double)input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Math.Round(result.Keping / 2.0 / input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round((double)(input.Lebar + 5) / 39, 2);
                result.TailorKepingA = Math.Round(result.Keping / 2.0, 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round((double)(input.Lebar + 5) * 2 / 39, 2);
                result.TailorKepingA = input.Set;
            }

            return result;
        }
    }
}
