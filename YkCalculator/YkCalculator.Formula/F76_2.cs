using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class F76_2 : F76_1, IFormula
    {
        public new Output Calculate(Input input)
        {
            Output result = base.Calculate(input);
            result.TailorInchLabel = "110''";
            return result;
        }
    }
}
