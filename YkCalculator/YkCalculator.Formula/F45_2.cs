using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F45_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            if (input.Tinggi > 27)
            {
                result.HargaKainA = Math.Round(1.8 * result.Keping * input.HargaKainA, 2);
            }
            else
            {
                result.HargaKainA = Math.Round(1.8 * result.Keping / 2 * input.HargaKainA, 2);
            }
                
            result.HargaKainB = Math.Round(((input.HargaKainB + input.HargaCincin) * 1.8 + 3) * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorTotalKeping = result.Keping;
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorHeaderKepingA = 9999;
            result.TailorMeterA = 9999;
            result.TailorKepingA = 9999;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39, 2);
                result.TailorKepingB = Math.Round(result.Keping / 2.0 / input.Set, 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterB = Math.Round((((56 * result.TailorKeping / 2) * 2) + 5) / 39, 2);
                result.TailorKepingB = 1;
            }

            return result;
        }
    }
}
