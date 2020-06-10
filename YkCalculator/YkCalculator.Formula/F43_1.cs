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
            result.KepingG = input.KepingG;
            result.KepingC = input.KepingC;
            result.UpahKainA = result.Keping * 3;

            double kainMeterG = Math.Round(1.6 * result.KepingG, 2);
            result.HargaKainG = Math.Round(kainMeterG * input.HargaKainG, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainG), kainMeterG, input.HargaKainG, result.HargaKainG);

            double kainMeterC = Math.Round(1.6 * result.KepingC, 2);
            result.HargaKainC = Math.Round(kainMeterC * input.HargaKainC, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainC), kainMeterC, input.HargaKainC, result.HargaKainC);

            result.HargaCincinG = Math.Round(1.6 * input.HargaCincinG * result.KepingG, 2);
            result.HargaCincinC = Math.Round(1.6 * input.HargaCincinC * result.KepingC, 2);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainG + result.HargaKainC + result.HargaCincinG + result.HargaCincinC + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainG, result.HargaKainC, result.HargaCincinG, result.HargaCincinC, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorTotalKeping = result.Keping;
            if (input.Layout.Equals("T"))
            {
                result.TailorKepingBreakdownC = result.KepingC / 2 / input.Set;
                result.TailorKepingBreakdownG = result.KepingG / 2 / input.Set;
                result.TailorMeterG = Math.Round(((56 * result.TailorKepingBreakdownG) + 3) / 39, 2);
                result.TailorKepingG = result.TailorKepingBreakdownG * input.Set;
                result.TailorMeterC = 1.52;
                result.TailorKepingC = result.TailorKepingBreakdownC * 2 * input.Set;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKepingBreakdownC = 1;
                result.TailorKepingBreakdownG = result.KepingG / 2 / input.Set;
                result.TailorMeterG = Math.Round(((56 * result.TailorKepingBreakdownG) + 3) / 39.0, 2);
                result.TailorKepingG = result.TailorKepingBreakdownG * input.Set;
                result.TailorMeterC = 3.03;
                result.TailorKepingC = result.TailorKepingBreakdownC * input.Set;
            }

            return result;
        }
    }
}
