﻿using System;
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
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);
            result.HargaKainA = Math.Round((input.Tinggi + 15) / 39.0 * input.HargaKainA, 2);
            result.HargaKainB = Math.Round((input.HargaKainB + input.HargaCincinB) * 1.8, 2);
            result.UpahButang = Math.Round(input.HargaButang * result.Keping * 4, 2);
            result.UpahCincin = Math.Round(input.HargaCincin, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.JumlahA = Math.Round((result.HargaKainA + result.UpahCincin + 3) * input.KepingA, 2);
            result.JumlahB = Math.Round((result.HargaKainB + 3) * input.KepingB, 2);
            result.Jumlah = Math.Round(result.JumlahA + result.JumlahB + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);

            result.TailorTotalKeping = result.Keping;
            result.TailorKepingBreakdownK = input.KepingA / 2;
            result.TailorKepingBreakdownB = input.KepingB / 2;
            if (input.Layout.Equals("T"))
            {
                result.TailorMeterK = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingK = input.KepingA;
                result.TailorJalur = 4;
                result.TailorKepingB = input.KepingB;

            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorMeterK = Math.Round((input.Tinggi + 10) / 39.0, 2);
                result.TailorKepingK = input.KepingA / 2;
                result.TailorJalur = 8;
                result.TailorKepingB = result.TailorKepingBreakdownB;
            }
            
            return result;
        }
    }
}
