using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class KepingManager
    {
        public int Identify(Input input)
        {
            int keping = 0;
            switch (input.FormulaCode)
            {
                case "F17_1":
                    keping = (int)Math.Ceiling(input.Lebar / 28.0) * input.Set;
                    break;
                default:
                    throw new Exception("KeepingManager cannot identify formula code");
            }

            return keping;
        }
    }
}
