using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F88_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 30.0) * input.Set;
            result.UpahKainA = result.Keping * 3;
            result.UpahHook = result.Keping * input.HargaHook;
            result.HargaKainA = Math.Round((result.Keping / 2) * 1.6 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.Tinggi + 10) / 39.0 * result.Keping / 2 * input.HargaKainA, 2);
            result.HargaRenda = Math.Round(result.Keping * 1.6 * input.HargaRenda * input.RendaQuantity, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.UpahHook + result.HargaKainA + result.HargaKainB +
                result.HargaRenda + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "110''";
            result.TailorHeaderKepingA = Math.Round((double)(result.Keping / input.Set / 4), 1);
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorMeterA = Math.Round(result.Keping / 2 * 1.53 / input.Set, 2);
            result.TailorKepingA = result.TailorHeaderKepingA;
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterB = Math.Round((input.Lebar + 5) / 39.0, 2);
                result.TailorKepingB = result.TailorKeping * 2;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterB = Math.Round((input.Lebar + 5) * 2 / 39.0, 2);
                result.TailorKepingB = Math.Round(result.TailorKeping / 4.0, 0);
            }

            return result;
        }
    }
}
