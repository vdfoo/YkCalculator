using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F99ProductCollection
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F99.1", "Rail 10''", Constant.SendiriPasang, 75.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F99.2", "Rail 10''", Constant.KedaiPasang, 95.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F99.3", "Rail 14''", Constant.SendiriPasang, 105.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F99.4", "Rail 14''", Constant.KedaiPasang, 133.00));

            return p;
        }
    }
}
