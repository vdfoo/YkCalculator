using System;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F1_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.UpahCincin = Math.Round(result.Keping * input.HargaCincin, 2);
            result.HargaKainA = Math.Round((double)(input.Tinggi + 15) / 39 * result.Keping * input.HargaKainA, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.UpahCincin + result.HargaKainA + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorInchLabel = "60''";
            result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorMeterA = Math.Round((double)(input.Tinggi + 10) / 39, 2);
                result.TailorKepingA = Math.Round((double)(result.Keping / input.Set), 1);
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterA = Math.Round((double)(input.Tinggi + 10) / 39, 2);
                result.TailorKepingA = Math.Round((double)(result.Keping / input.Set), 1);
            }

            return result;
        }
    }
}
