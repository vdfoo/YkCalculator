using System;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F1_1 : FormulaBase
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };
            
            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.Upah1 = Math.Round((double)result.Keping * 3, 2);
            result.Upah2Cincin = Math.Round(result.Keping * input.HargaCincin, 2);
            result.Kain = Math.Round((double)(input.Tinggi + 15) / 39 * result.Keping * input.HargaKainA, 2);
            result.Jumlah = Math.Round(result.Upah1 + result.Upah2Cincin + result.Kain, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = Math.Round((double)(input.Tinggi + 10) / 39, 2);

            return result;
        }
    }
}
