using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

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
            result.HargaKainA = Math.Round((((input.HargaKainA + input.HargaCincinG) * 1.6) + 3) * input.KepingG, 2);
            result.HargaKainC = Math.Round(((input.HargaCincinC + input.HargaKainC) * 1.6 + 3) * input.KepingC, 2);

            result.Jumlah = Math.Round(result.HargaKainA + result.HargaKainC, 2);

            result.TailorKeping = result.Keping;
            result.TailorMeterG = 1.51;
            result.TailorMeterC = 2.95;
            result.TailorTotalKeping = result.Keping;

            return result;
        }
    }
}
