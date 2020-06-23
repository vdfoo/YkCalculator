using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class F98ProductCollection
    {
        public Product Initialize(Product p)
        {
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.1", "Rail 2.5''", Constant.SendiriPasang, 11.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.2", "Rail 2.5''", Constant.KedaiPasang, 15.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.3", "Rail 3.5''", Constant.SendiriPasang, 15.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.4", "Rail 3.5''", Constant.KedaiPasang, 21.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.5", "Rail 4''", Constant.SendiriPasang, 17.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.6", "Rail 4''", Constant.KedaiPasang, 24.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.7", "Rail 5''", Constant.SendiriPasang, 22.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.8", "Rail 5''", Constant.KedaiPasang, 30.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.9", "Rail 6''", Constant.SendiriPasang, 26.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.10", "Rail 6''", Constant.KedaiPasang, 36.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.11", "Rail 7''", Constant.SendiriPasang, 30.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.12", "Rail 7''", Constant.KedaiPasang, 42.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.13", "Rail 8''", Constant.SendiriPasang, 35.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.14", "Rail 8''", Constant.KedaiPasang, 48.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.15", "Rail 9''", Constant.SendiriPasang, 39.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.16", "Rail 9''", Constant.KedaiPasang, 54));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.17", "Rail 10''", Constant.SendiriPasang, 44.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.18", "Rail 10''", Constant.KedaiPasang, 60.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.19", "Rail 12''", Constant.SendiriPasang, 52.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.20", "Rail 12''", Constant.KedaiPasang, 72.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.21", "Rail 14''", Constant.SendiriPasang, 61.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.22", "Rail 14''", Constant.KedaiPasang, 84.00));

            return p;
        }
    }
}
