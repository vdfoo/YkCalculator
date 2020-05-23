using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F35_2 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(Math.Round(1.8 * result.Keping / 2 * input.HargaKainB, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2), 2);
            result.HargaKainB = Math.Round((input.HargaKainB + 7) * 1.8 * result.Keping, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.JumlahA = Math.Round(result.UpahKainA + result.UpahButang + result.HargaKainA, 2);
            result.JumlahB = Math.Round(result.HargaKainB, 2);
            result.Jumlah = Math.Round(result.JumlahA + result.JumlahB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown = GetDetailBreakdown(result, result.JumlahA, result.JumlahB, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorRenda1 = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorRenda2 = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorMeterA = 9999;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39.0, 2);
                result.TailorKepingA = 9999;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping) + 5) / 39, 2);
                result.TailorKepingB = input.Set * result.TailorKeping;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorRenda1 = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
                result.TailorRenda2 = Math.Round(((56 * result.TailorKeping / 2) + 5) / 39.0, 2);
                result.TailorMeterA = 9999;
                result.TailorKepingA = 9999;
                result.TailorMeterB = Math.Round(((56 * result.TailorKeping / 2) + 5) * 2 / 39.0, 2);
                result.TailorKepingB = input.Set;
            }

            return result;
        }
    }
}
