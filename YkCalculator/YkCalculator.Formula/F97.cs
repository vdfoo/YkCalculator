using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Logic
{
    public class F97 : FormulaBase
    {
        // Only for kedai pasang
        public RodSetOutput Calculate(RodSetInput input)
        {
            RodSetOutput result = new RodSetOutput();
            result.Set = input.Set;
            

            if (input.ReadyMadeProduct != null && input.ReadyMadeProduct.Count != 0)
            {
                result.ReadyMadeProduct = new List<ReadyMadeProduct>();
                ReadyMadeProduct product = input.ReadyMadeProduct[0];

                if (input.Sequence == 1)
                {
                    product.Subtotal = Math.Round(product.Quantity * product.Meter * 13, 2);
                }
                else if (input.Sequence == 2)
                {
                    product.Subtotal = Math.Round(product.Quantity * product.Meter * 10, 2);
                }

                result.ReadyMadeProduct.Add(product);

                result.RodQuantity = input.ReadyMadeProduct[0].Quantity;
                result.RodOnlySubtotal = Math.Round(product.Subtotal, 2);

                result = HandleEndcapBracket(result, product);

                result.RodSetTotal = result.RodOnlySubtotal + result.EndCapSubtotal + result.BracketSubtotal;
            }

            return result;
        }

        private RodSetOutput HandleEndcapBracket(RodSetOutput result, ReadyMadeProduct product)
        {
            int option = 0;
            Product p = new Product(null, null, null, true);

            switch (product.Name)
            {
                case Constant.RodKayuHitam:
                case Constant.RodKayuCoco:
                    option = 1;
                    F92_1ProductCollection f92_1ProductCollection = new F92_1ProductCollection();
                    p = f92_1ProductCollection.Initialize(p, true);
                    break;
                case Constant.RodKayuPutih:
                    option = 2;
                    F93_1ProductCollection f93_1ProductCollection = new F93_1ProductCollection();
                    p = f93_1ProductCollection.Initialize(p, true);
                    break;
                case Constant.RodAluminiumMeroon:
                case Constant.RodAluminiumHitam:
                case Constant.RodAluminiumKokoGelap:
                case Constant.RodAluminiumPutih:
                case Constant.RodAluminiumSilverRose:
                    option = 3;
                    F94_1ProductCollection f94_1ProductCollection = new F94_1ProductCollection();
                    p = f94_1ProductCollection.Initialize(p, true);
                    break;
            }
            
            ReadyMadeProduct bracket = p.ReadyMadeProduct.Find(x => x.Name == Constant.Bracket);
            ReadyMadeProduct endcap = p.ReadyMadeProduct.Find(x => x.Name == Constant.EndCap);

            // A hack to make name become meter for using CalculateEndcapBracket method
            string tempNameStorage = result.ReadyMadeProduct[0].Name;
            result.ReadyMadeProduct[0].Name = result.ReadyMadeProduct[0].Meter.ToString();

            result = CalculateEndcapBracket(result, option, bracket, endcap);
            result.ReadyMadeProduct[0].Name = tempNameStorage;

            return result; 
        }
    }
}
