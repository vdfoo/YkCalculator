using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class S5 : FormulaBase, IFormula
    {
        public Output Calculate(Input input)
        {
            Output result = new Output()
            {
                Input = input
            };

            result.Keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
            result.UpahKainA = Math.Round((double)result.Keping * 3, 2);

            double kainMeterA = Transform.RoundUp(((input.Lebar + 10) / 39.0) * 2 * input.Set, 2);
            result.HargaKainA = Math.Round(kainMeterA * input.HargaKainA, 2);
            result.DetailedBreakdown += GetHargaBreakdown(nameof(Output.HargaKainA), kainMeterA, input.HargaKainA, result.HargaKainA);

            result.UpahHook = Math.Round(input.HargaHook * result.Keping, 2);
            result.HargaTaliLangsir = Math.Round(10.0 * input.TaliLangsirQuantity, 2);
            result.Jumlah = Math.Round(result.UpahKainA + result.HargaKainA + result.UpahHook + result.HargaTaliLangsir, 2);
            AddOptionalItemsToJumlah(input, result);
            result.DetailedBreakdown += GetDetailBreakdown(result, result.UpahKainA, result.HargaKainA, result.UpahHook, result.HargaTaliLangsir);

            result.TailorInchLabel = "110''";
            
            result.TailorTotalKeping = result.Keping;

            if (input.Layout.Equals("T"))
            {
                result.TailorKeping = Transform.TailorKeping(result.Keping, input.Layout, input.Set);
                result.TailorMeterA = Math.Round((input.Lebar + 5) / 39.0, 2); 
                result.TailorKepingA = input.Set * 2;
                
            }
            else if (input.Layout.Equals("L"))
            {
                result.TailorKeping = Math.Round(result.Keping / 2.0 / input.Set, 2);
                result.TailorMeterA = Math.Round(((input.Lebar * 2) + 5) / 39.0, 2);
                result.TailorKepingA = input.Set;
            }

            return result;
        }
    }
}
