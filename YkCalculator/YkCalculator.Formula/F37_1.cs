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
            result.KepingK = input.KepingK;
            result.KepingB = input.KepingB;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);

            double kainMeterK = (input.Tinggi + 15) / 39.0 * result.KepingK;
            result.HargaKainK = Math.Round(kainMeterK * input.HargaKainK, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainK), kainMeterK, input.HargaKainK, result.HargaKainK);

            double kainMeterB = result.KepingB * 1.8;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);

            result.HargaCincinK = result.KepingK * input.HargaCincinK;
            result.HargaCincinB = result.KepingB * 1.8 * input.HargaCincinB;
            
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaCincinK + result.HargaCincinB + result.HargaKainK + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaCincinK, result.HargaCincinB, result.HargaKainK, result.HargaKainB, result.HargaTaliLangsir);

            result.TailorInchLabel = "110'';60''";
            result.TailorTotalKeping = result.Keping;
            result.TailorKepingBreakdownK = Math.Round(result.KepingK / 2.0 / input.Set, 1);
            result.TailorKepingBreakdownB = Math.Round(result.KepingB / 2.0 / input.Set, 1);
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
