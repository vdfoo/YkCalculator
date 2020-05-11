using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F25_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 28) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(result.Keping * 1.6 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round(Math.Ceiling((input.Lebar + 10) / 39.0 * input.HargaKainB * 2) * input.Set, 2);
            result.UpahHook = Math.Round(input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahHook
                 + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;
            result.TailorMeterA = Math.Round(1.55 * 2, 2);
            result.TailorKepingA = Math.Round(result.Keping / 2.0, 1);

            if (input.Layout.Equals("T"))
            {
                result.TailorKeping = Math.Round(result.Keping / 2.0, 1);
                result.TailorMeterB = Math.Round((input.Lebar + 5) / 39.0, 2);
                result.TailorKepingB = result.Keping;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKeping = 1;
                result.TailorMeterB = Math.Round((input.Lebar + 5) * 2 / 39.0, 2);
                result.TailorKepingB = result.TailorKeping;
            }

            return result;
        }
    }
}
