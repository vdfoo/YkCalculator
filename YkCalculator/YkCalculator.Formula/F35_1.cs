﻿using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F35_1 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling((double)input.Lebar * input.Lipat / 60) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round(Math.Round(1.6 * result.Keping / 2 * input.HargaKainB, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2) +
                                Math.Round(1.6 * result.Keping * input.HargaKainA, 2), 2);
            result.HargaKainB = Math.Round((input.HargaKainB + 7) * 1.6 * result.Keping, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);

            result.JumlahA = Math.Round(result.UpahKainA + result.UpahButang + result.HargaKainA, 2);
            result.JumlahB = Math.Round(result.HargaKainB, 2);
            result.Jumlah = Math.Round(result.JumlahA + result.JumlahB, 2);

            result.TailorKeping = result.Keping;
            result.TailorTinggi = 0;
            result.TailorTinggiB = 3;
            result.TailorRenda = 6;
            result.TailorTotalKeping = result.TailorKeping;

            return result;
        }
    }
}