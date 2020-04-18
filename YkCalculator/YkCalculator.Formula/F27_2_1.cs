using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F27_2_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar / 30) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(result.Keping * 1.8 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.HargaKainB + input.HargaCincin) * 1.6 * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.HargaKainB + result.UpahCincin
                 + result.HargaTaliLangsir, 2);

            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout);
            result.TailorTotalKeping = result.Keping;
            result.TailorJalur = result.Keping * 4;
            result.TailorMeter = result.TailorJalur / 2;
            result.TailorMeterB = Math.Round(1.5 * result.Keping / 2, 2);

            return result;
        }
    }
}
