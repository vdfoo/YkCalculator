using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F11_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((double)(input.Lebar + 10) / 39 * 2 * input.HargaKainA * input.Set, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorKeping = 1;
                result.TailorMeterA = Math.Round((double)(input.Lebar + 5) / 39, 2);
                result.TailorKepingA = Math.Floor(result.TailorKeping * 2.0 * input.Set);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKeping = Math.Floor(result.Keping / 2.0 / input.Set);
                result.TailorMeterA = Math.Round((double)(input.Lebar + 5) * 2 / 39, 2);
                result.TailorKepingA = input.Set;
            }

            return result;
        }
    }
}
