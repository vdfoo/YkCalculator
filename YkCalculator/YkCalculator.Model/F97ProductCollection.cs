using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class F97ProductCollection
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.1", "Rod Kayu", string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.2", "Aluminium Rail", string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.3", "Rail (Lengkuk)", string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.4", "Rail (Kayu)", string.Empty, 0));
            return p;
        }
    }
}
