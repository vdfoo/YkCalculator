using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public interface IFormula
    {
        public Output Calculate(Input input);
    }
}
