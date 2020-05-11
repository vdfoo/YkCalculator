using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F41_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 3 / 60) * input.Set;
            result.HargaKainA = Math.Round((((input.Tinggi + 15) / 39.0 * input.HargaKainA) + input.HargaCincinG + 3) * input.KepingG, 2);
            result.HargaKainC = Math.Round(((input.HargaCincinC + input.HargaKainC) * 1.6 + 3) * input.KepingC, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainC + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorTotalKeping = result.Keping;
            if (input.Layout.Equals("T"))
            {
                result.TailorKepingBreakdownC = input.KepingC / 2;
                result.TailorKepingBreakdownG = input.KepingG / 4;
                result.TailorMeterG = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingG = result.TailorKepingBreakdownG * 4;
                result.TailorMeterC = 1.57;
                result.TailorKepingC = result.TailorKepingBreakdownC * 2;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKepingBreakdownC = input.KepingC / 2;
                result.TailorKepingBreakdownG = input.KepingG / 4;
                result.TailorKepingBreakdownG2 = input.KepingG / 2;
                result.TailorMeterG = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingG = result.TailorKepingBreakdownG * 4;
                result.TailorMeterC = 1.57;
                result.TailorKepingC = result.TailorKepingBreakdownC * 2;
            }         

            return result;
        }
    }
}


