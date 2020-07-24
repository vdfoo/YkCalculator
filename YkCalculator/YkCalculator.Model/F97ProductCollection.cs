using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F97ProductCollection
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.1", Constant.RodKayuHitam, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.2", Constant.RodKayuCoco, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.3", Constant.RodKayuPutih, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.4", Constant.RodAluminiumMeroon, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.5", Constant.RodAluminiumSilverRose, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.6", Constant.RodAluminiumPutih, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.7", Constant.RodAluminiumKokoGelap, string.Empty, 0));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F97.8", Constant.RodAluminiumHitam, string.Empty, 0));
            return p;
        }
    }
}
