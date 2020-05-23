using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F37_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 3 / 60) * input.Set;
            result.KepingK = input.Set * 4;
            result.KepingB = input.Set * 2;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainK = Math.Round((input.Tinggi + 15) / 39.0 * input.HargaKainK, 2);
            result.HargaKainB = Math.Round((input.HargaKainB + input.HargaCincinB) * 1.8, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);
            result.UpahCincin = Math.Round(input.HargaCincinK, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.JumlahK = Math.Round((result.HargaKainK + result.UpahCincin + 3) * result.KepingK, 2);
            result.JumlahB = Math.Round((result.HargaKainB + 3) * result.KepingB, 2);
            result.Jumlah = Math.Round(result.JumlahK + result.JumlahB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.JumlahK, result.JumlahB, result.HargaTaliLangsir);

            result.TailorTotalKeping = result.Keping;
            result.TailorKepingBreakdownK = result.KepingK / 2 / input.Set;
            result.TailorKepingBreakdownB = result.KepingB / 2 / input.Set;
            if (input.Layout.Equals("T"))
            {
                result.TailorMeterK = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingK = result.KepingK;
                result.TailorJalur = 4;
                result.TailorKepingB = result.KepingB;

            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterK = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingK = result.KepingK / 2;
                result.TailorJalur = 8;
                result.TailorKepingB = input.Set * result.TailorKepingBreakdownB;
            }
            
            return result;
        }
    }
}
