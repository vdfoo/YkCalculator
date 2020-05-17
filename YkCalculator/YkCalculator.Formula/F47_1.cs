using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F47_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.UpahKainA = 3;
            result.Keping = (int)Math.Ceiling((double)input.Lebar * 2 / 60) * input.Set;
            input.KepingA = result.Keping;
            input.KepingB = (int)Math.Ceiling(result.Keping / 4.0);
            if (input.Tinggi > 27)
            {
                result.HargaKainA = Math.Round(1.8 * input.HargaKainB * (result.Keping / 2), 2);
            }
            else
            {
                result.HargaKainA = Math.Round(1.8 * input.HargaKainB * (result.Keping / 4), 2);
            }
            
            result.HargaKainB = Math.Round(((32 + input.HargaCincin) * 1.8 + result.UpahKainA) * result.Keping, 2); 
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "110''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout);
            result.TailorTotalKeping = result.Keping;
            result.TailorHeaderKepingA = 9999;
            result.TailorMeterA = 9999;
            result.TailorKepingA = 9999;
            if (input.Layout.Equals("T"))
            {
                result.TailorJalur = result.Keping * 2;
                result.TailorKepingB = result.TailorKeping;
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorJalur = result.Keping * 4;
                result.TailorKepingB = 1;
            }

            return result;
        }
    }
}
