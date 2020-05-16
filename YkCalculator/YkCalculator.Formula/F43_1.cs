using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F43_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 3 / 60) * input.Set;
            result.HargaKainG = Math.Round((((input.HargaKainG + input.HargaCincinG) * 1.6) + 3) * input.KepingG, 2);
            result.HargaKainC = Math.Round(((input.HargaCincinC + input.HargaKainC) * 1.6 + 3) * input.KepingC, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainG + result.HargaKainC + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorTotalKeping = result.Keping;
            if (input.Layout.Equals("T"))
            {
                result.TailorKepingBreakdownC = input.KepingC / 2;
                result.TailorKepingBreakdownG = input.KepingG / 2;
                result.TailorMeterG = Math.Round(((56 * result.TailorKepingBreakdownG) + 3) / 39, 2);
                result.TailorKepingG = result.TailorKepingBreakdownG;
                result.TailorMeterC = 1.52;
                result.TailorKepingC = result.TailorKepingBreakdownC * 2;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKepingBreakdownC = 1;
                result.TailorKepingBreakdownG = input.KepingG / 2;
                result.TailorMeterG = Math.Round(((56 * result.TailorKepingBreakdownG) + 3) / 39.0, 2);
                result.TailorKepingG = result.TailorKepingBreakdownG;
                result.TailorMeterC = 3.03;
                result.TailorKepingC = result.TailorKepingBreakdownC;
            }

            return result;
        }
    }
}
