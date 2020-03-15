using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YkCalculator.DAL;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IEnumerable<Product> Get()
        {
            Product p1 = new Product()
            {
                Name = "Short Name 1",
                ImagePath = "https://i.postimg.cc/G27TFN7F/F1-1.jpg",
                FormulaCode = "F1_1",
                Field = new List<Field>()
                {
                    new Field()
                    {
                        DisplayName = "Set", PropertyName = "Set", Required = true, PropertyType = "int"
                    },
                    new Field()
                    {
                        DisplayName = "Lebar", PropertyName = "Lebar", Required = true, PropertyType = "int"
                    },
                    new Field()
                    {
                        DisplayName = "Tinggi", PropertyName = "Tinggi", Required = true, PropertyType = "int"
                    },
                    new Field()
                    {
                        DisplayName = "Harga Kain A", PropertyName = "HargaKainA", Required = true, PropertyType = "decimal"
                    },
                    new Field()
                    {
                        DisplayName = "Harga Cincin", PropertyName = "HargaCincin", PropertyType = "decimal"
                    },
                    new Field()
                    {
                        DisplayName = "Harga Hook", PropertyName = "HargaHook", PropertyType = "decimal"
                    },
                }
            };

            Product p2 = new Product()
            {
                Name = "Short Name 2",
                ImagePath = "https://i.postimg.cc/zBc3bhvp/F1-2.jpg",
                FormulaCode = "F1_2",
                Field = new List<Field>()
                {
                    new Field()
                    {
                        DisplayName = "Set", PropertyName = "Set", Required = true, PropertyType = "int"
                    },
                    new Field()
                    {
                        DisplayName = "Lebar", PropertyName = "Lebar", Required = true, PropertyType = "int"
                    },
                    new Field()
                    {
                        DisplayName = "Tinggi", PropertyName = "Tinggi", Required = true, PropertyType = "int"
                    },
                    new Field()
                    {
                        DisplayName = "Harga Kain A", PropertyName = "HargaKainA", Required = true, PropertyType = "decimal"
                    },
                    new Field()
                    {
                        DisplayName = "Harga Cincin", PropertyName = "HargaCincin", PropertyType = "decimal"
                    },
                    new Field()
                    {
                        DisplayName = "Harga Hook", PropertyName = "HargaHook", PropertyType = "decimal"
                    },
                    new Field()
                    {
                        DisplayName = "Lipat", PropertyName = "Lipat", PropertyType = "int"
                    },
                }
            };

            Product p3 = new Product()
            {
                Name = "Short Name 3",
                ImagePath = "https://i.postimg.cc/P53D0HL8/F3-1.jpg",
                FormulaCode = "F3_1"
            };

            Product p4 = new Product()
            {
                Name = "Short Name 4",
                ImagePath = "https://i.postimg.cc/N0KXcnTC/F3-2.jpg",
                FormulaCode = "F3_2"
            };

            Product p5 = new Product()
            {
                Name = "Short Name 5",
                ImagePath = "https://i.postimg.cc/bNq2Jrkt/F3-3.jpg",
                FormulaCode = "F3_3"
            };

            Product p6 = new Product()
            {
                Name = "Short Name 6",
                ImagePath = "https://i.postimg.cc/Hng8bsNF/F3-4.jpg",
                FormulaCode = "F3_4"
            };

            Product p7 = new Product()
            {
                Name = "Short Name 7",
                ImagePath = "https://i.postimg.cc/sDKGZz40/F5-1.jpg",
                FormulaCode = "F5_1"
            };

            Product p8 = new Product()
            {
                Name = "Short Name 8",
                ImagePath = "https://i.postimg.cc/zGBbCQdD/F5-2.jpg",
                FormulaCode = "F5_2"
            };

            Product p9 = new Product()
            {
                Name = "Short Name 9",
                ImagePath = "https://i.postimg.cc/63RG7GMd/F7-1.jpg",
                FormulaCode = "F7_1"
            };

            Product p10 = new Product()
            {
                Name = "Short Name 10",
                ImagePath = "https://i.postimg.cc/JhSk4Q5r/F7-2.jpg",
                FormulaCode = "F7_2"
            };

            Product p11 = new Product()
            {
                Name = "Short Name 11",
                ImagePath = "https://i.postimg.cc/h4LdcTzn/F9-1.jpg",
                FormulaCode = "F9_1"
            };

            Product p12 = new Product()
            {
                Name = "Short Name 12",
                ImagePath = "https://i.postimg.cc/T1JL0vM1/F9-2.jpg",
                FormulaCode = "F9_2"
            };

            Product p13 = new Product()
            {
                Name = "Short Name 13",
                ImagePath = "https://i.postimg.cc/3xcynZ6X/F11-1.jpg",
                FormulaCode = "F11_1"
            };

            Product p14 = new Product()
            {
                Name = "Short Name 14",
                ImagePath = "https://i.postimg.cc/pd5m7Fbg/F11-2.jpg",
                FormulaCode = "F11_2"
            };

            Product p15 = new Product()
            {
                Name = "Short Name 15",
                ImagePath = "https://i.postimg.cc/cHqvNLd6/F13-1.jpg",
                FormulaCode = "F13_1"
            };

            Product p16 = new Product()
            {
                Name = "Short Name 16",
                ImagePath = "https://i.postimg.cc/QtpHNZMm/F13-2.jpg",
                FormulaCode = "F13_2"
            };

            Product p17 = new Product()
            {
                Name = "Short Name 17",
                ImagePath = "https://i.postimg.cc/90CzrgRh/F15-1.jpg",
                FormulaCode = "F15_1"
            };

            Product p18 = new Product()
            {
                Name = "Short Name 18",
                ImagePath = "https://i.postimg.cc/T101mjgW/F15-2.jpg",
                FormulaCode = "F15_2"
            };

            Product p19 = new Product()
            {
                Name = "Short Name 19",
                ImagePath = "https://i.postimg.cc/025bv31G/F17-1.jpg",
                FormulaCode = "F17_1"
            };

            Product p20 = new Product()
            {
                Name = "Short Name 20",
                ImagePath = "https://i.postimg.cc/J75G98v4/F17-2.jpg",
                FormulaCode = "F17_2"
            };

            Product p21 = new Product()
            {
                Name = "Short Name 21",
                ImagePath = "https://i.postimg.cc/bJWMY4s6/F17-3.jpg",
                FormulaCode = "F17_3"
            };

            Product p22 = new Product()
            {
                Name = "Short Name 22",
                ImagePath = "https://i.postimg.cc/5NPj23fh/F19-1.jpg",
                FormulaCode = "F19_1"
            };

            Product p23 = new Product()
            {
                Name = "Short Name 23",
                ImagePath = "https://i.postimg.cc/13fXnqtf/F19-2.jpg",
                FormulaCode = "F19_2"
            };

            Product p24 = new Product()
            {
                Name = "Short Name 24",
                ImagePath = "https://i.postimg.cc/ZqNqjz6m/F21-1.jpg",
                FormulaCode = "F21_1"
            };

            Product p25 = new Product()
            {
                Name = "Short Name 25",
                ImagePath = "https://i.postimg.cc/ht6j9tzM/F21-2.jpg",
                FormulaCode = "F21_2"
            };

            Product p26 = new Product()
            {
                Name = "Short Name 26",
                ImagePath = "https://i.postimg.cc/sXRgNHJh/F23-1.jpg",
                FormulaCode = "F23_1"
            };

            Product p27 = new Product()
            {
                Name = "Short Name 27",
                ImagePath = "https://i.postimg.cc/Ss7xFLZt/F25-1.jpg",
                FormulaCode = "F25_1"
            };

            Product p28 = new Product()
            {
                Name = "Short Name 28",
                ImagePath = "https://i.postimg.cc/Xqj7VZmN/F25-2.jpg",
                FormulaCode = "F25_2"
            };

            Product p29 = new Product()
            {
                Name = "Short Name 29",
                ImagePath = "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg",
                FormulaCode = "F27_1_1"
            };

            Product p30 = new Product()
            {
                Name = "Short Name 30",
                ImagePath = "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg",
                FormulaCode = "F27_1_2"
            };

            Product p31 = new Product()
            {
                Name = "Short Name 31",
                ImagePath = "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg",
                FormulaCode = "F27_2_1"
            };

            Product p32 = new Product()
            {
                Name = "Short Name 32",
                ImagePath = "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg",
                FormulaCode = "F27_2_2"
            };

            Product p33 = new Product()
            {
                Name = "Short Name 33",
                ImagePath = "https://i.postimg.cc/Prqr9w12/F29-1.jpg",
                FormulaCode = "F29_1"
            };

            Product p34 = new Product()
            {
                Name = "Short Name 34",
                ImagePath = "https://i.postimg.cc/Prqr9w12/F29-1.jpg",
                FormulaCode = "F31_1"
            };

            Product p35 = new Product()
            {
                Name = "Short Name 35",
                ImagePath = "https://i.postimg.cc/Prqr9w12/F29-1.jpg",
                FormulaCode = "F31_2"
            };

            Product p36 = new Product()
            {
                Name = "Short Name 36",
                ImagePath = "https://i.postimg.cc/htz4PRym/F35-1.jpg",
                FormulaCode = "F35_1"
            };

            Product p37 = new Product()
            {
                Name = "Short Name 37",
                ImagePath = "https://i.postimg.cc/dtStYVBv/F35-2.jpg",
                FormulaCode = "F35_2"
            };

            Product p38 = new Product()
            {
                Name = "Short Name 38",
                ImagePath = "https://i.postimg.cc/zGszy26c/F37-1.jpg",
                FormulaCode = "F37_1"
            };

            Product p39 = new Product()
            {
                Name = "Short Name 39",
                ImagePath = "https://i.postimg.cc/j5KRXws6/F39-1.jpg",
                FormulaCode = "F39_1"
            };

            Product p40 = new Product()
            {
                Name = "Short Name 40",
                ImagePath = "https://i.postimg.cc/sxgykkGv/F41-1.jpg",
                FormulaCode = "F41_1"
            };

            Product p41 = new Product()
            {
                Name = "Short Name 41",
                ImagePath = "https://i.postimg.cc/rmJMYVmB/F43-1.jpg",
                FormulaCode = "F43_1"
            };

            Product p42 = new Product()
            {
                Name = "Short Name 42",
                ImagePath = "https://i.postimg.cc/vT2Mb05X/F45-1.jpg",
                FormulaCode = "F45_1"
            };

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);
            products.Add(p6);
            products.Add(p7);
            products.Add(p8);
            products.Add(p9);
            products.Add(p10);
            products.Add(p11);
            products.Add(p12);
            products.Add(p13);
            products.Add(p14);
            products.Add(p15);
            products.Add(p16);
            products.Add(p17);
            products.Add(p18);
            products.Add(p19);
            products.Add(p20);
            products.Add(p21);
            products.Add(p22);
            products.Add(p23);
            products.Add(p24);
            products.Add(p25);
            products.Add(p26);
            products.Add(p27);
            products.Add(p28);
            products.Add(p29);
            products.Add(p30);
            products.Add(p31);
            products.Add(p32);
            products.Add(p33);
            products.Add(p34);
            products.Add(p35);
            products.Add(p36);
            products.Add(p37);
            products.Add(p38);
            products.Add(p39);
            products.Add(p40);
            products.Add(p41);
            products.Add(p42);

            return products;
        }
    }
}