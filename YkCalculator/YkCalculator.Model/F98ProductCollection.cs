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
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.1", "2.5''", Constant.SendiriPasang, 11.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.2", "2.5''", Constant.KedaiPasang, 15.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.3", "3.5''", Constant.SendiriPasang, 15.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.4", "3.5''", Constant.KedaiPasang, 21.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.5", "4''", Constant.SendiriPasang, 17.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.6", "4''", Constant.KedaiPasang, 24.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.7", "5", Constant.SendiriPasang, 22.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.8", "5", Constant.KedaiPasang, 30.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.9", "6", Constant.SendiriPasang, 26.40));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.10", "6", Constant.KedaiPasang, 36.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.11", "7", Constant.SendiriPasang, 30.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.12", "7", Constant.KedaiPasang, 42.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.13", "8", Constant.SendiriPasang, 35.20));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.14", "8", Constant.KedaiPasang, 48.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.15", "9", Constant.SendiriPasang, 39.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.16", "9", Constant.KedaiPasang, 54));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.17", "10", Constant.SendiriPasang, 44.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.18", "10", Constant.KedaiPasang, 60.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.19", "12", Constant.SendiriPasang, 52.80));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.20", "12", Constant.KedaiPasang, 72.00));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.21", "14", Constant.SendiriPasang, 61.60));
            p.ReadyMadeProduct.Add(new ReadyMadeProduct("F98.22", "14", Constant.KedaiPasang, 84.00));

            return p;
        }
    }
}
