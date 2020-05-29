using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F39_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            result.UpahKainA = result.Keping * 3;

            double kainMeterK = 1.8 * result.Keping / 2;
            result.HargaKainK = Math.Round(kainMeterK * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainK), kainMeterK, input.HargaKainA, result.HargaKainK);

            double kainMeterB = 1.6 * result.Keping / 2;
            result.HargaKainB = Math.Round(kainMeterB * input.HargaKainB, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainB), kainMeterB, input.HargaKainB, result.HargaKainB);

            result.HargaCincinK = Math.Round(1.8 * result.Keping / 2 * input.HargaCincin, 2);
            result.HargaCincinB = Math.Round(1.6 * result.Keping / 2 * input.HargaCincin, 2);

            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaCincinK + result.HargaCincinB + result.HargaKainK + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaCincinK, result.HargaCincinB, result.HargaKainK, result.HargaKainB, result.HargaTaliLangsir);

            result.TailorTotalKeping = result.Keping;
            if (input.Layout.Equals("T"))
            {
                result.TailorKepingBreakdownK = Math.Round(result.Keping / 4.0 / input.Set, 1);
                result.TailorKepingBreakdownB = Math.Round(result.Keping / 4.0 / input.Set, 1);
                result.TailorMeterK = 1.57;
                result.TailorKepingK = result.TailorKepingBreakdownK * 2 * input.Set;
                result.TailorJalur = 4;
                result.TailorKepingB = result.TailorKepingBreakdownB * 2 * input.Set;

            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKepingBreakdownK = 1;
                result.TailorKepingBreakdownB = Math.Round(result.Keping / 4.0 / input.Set, 1);
                result.TailorMeterK = 3.13;
                result.TailorKepingK = result.TailorKepingBreakdownK * input.Set;
                result.TailorJalur = 8;
                result.TailorKepingB = result.TailorKepingBreakdownB * input.Set;
            }

            return result;
        }
    }
}
