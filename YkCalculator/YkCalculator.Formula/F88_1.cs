using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F88_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = result.Keping * input.HargaHook;
            result.HargaKainA = Math.Round((result.Keping / 2) * 1.6 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.Tinggi + 15) / 39.0 * result.Keping * input.HargaKainA, 2);
            result.HargaRenda = Math.Round(result.Keping * 1.6 * input.HargaRenda * input.RendaQuantity, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.UpahHook + result.HargaKainA + result.HargaKainB +
                result.HargaRenda + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorHeaderKepingA = Math.Round((double)(result.Keping / input.Set / 4), 1);
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorMeterA = Math.Round(result.Keping / 2 * 1.53 / input.Set, 2);
            result.TailorMeterB = Math.Round((input.Tinggi + 10) / 39.0, 2);
            result.TailorKepingA = Math.Round(result.Keping / 4.0, 0);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorKepingB = result.TailorKeping * 2 * input.Set;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKepingB = result.TailorKeping * input.Set;
            }

            return result;
        }
    }
}

