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
            Product p1 = new Product("F1_1", "Short Name 1", "https://i.postimg.cc/G27TFN7F/F1-1.jpg");
            p1.Field.AddCincinField();
            
            Product p2 = new Product("F1_2", "Short Name 2", "https://i.postimg.cc/zBc3bhvp/F1-2.jpg");
            p2.Field.AddCincinField();
            p2.Field.AddLipatField();

            Product p3 = new Product("F3_1", "Short Name 3", "https://i.postimg.cc/P53D0HL8/F3-1.jpg");

            Product p4 = new Product("F3_2", "Short Name 4", "https://i.postimg.cc/N0KXcnTC/F3-2.jpg");

            Product p5 = new Product("F3_3", "Short Name 5", "https://i.postimg.cc/bNq2Jrkt/F3-3.jpg");

            Product p6 = new Product("F3_4", "Short Name 6", "https://i.postimg.cc/Hng8bsNF/F3-4.jpg");

            Product p7 = new Product("F5_1", "Short Name 7", "https://i.postimg.cc/sDKGZz40/F5-1.jpg");
            p7.Field.AddButangField();
            p7.Field.AddHookField();

            Product p8 = new Product("F5_2", "Short Name 8", "https://i.postimg.cc/zGBbCQdD/F5-2.jpg");
            p8.Field.AddButangField();
            p8.Field.AddHookField();

            Product p9 = new Product("F7_1", "Short Name 9", "https://i.postimg.cc/63RG7GMd/F7-1.jpg");
            p9.Field.AddHookField();

            Product p10 = new Product("F7_2", "Short Name 10", "https://i.postimg.cc/JhSk4Q5r/F7-2.jpg");
            p10.Field.AddHookField();

            Product p11 = new Product("F9_1", "Short Name 11", "https://i.postimg.cc/h4LdcTzn/F9-1.jpg");
            p11.Field.AddHookField();

            Product p12 = new Product("F9_2", "Short Name 12", "https://i.postimg.cc/T1JL0vM1/F9-2.jpg");
            p12.Field.AddHookField();

            Product p13 = new Product("F11_1", "Short Name 13", "https://i.postimg.cc/3xcynZ6X/F11-1.jpg");

            Product p14 = new Product("F11_2", "Short Name 14", "https://i.postimg.cc/pd5m7Fbg/F11-2.jpg");

            Product p15 = new Product("F13_1", "Short Name 15", "https://i.postimg.cc/cHqvNLd6/F13-1.jpg");

            Product p16 = new Product("F13_2", "Short Name 16", "https://i.postimg.cc/QtpHNZMm/F13-2.jpg");

            Product p17 = new Product("F15_1", "Short Name 17", "https://i.postimg.cc/90CzrgRh/F15-1.jpg");
            p17.Field.AddHookField();

            Product p18 = new Product("F15_2", "Short Name 18", "https://i.postimg.cc/T101mjgW/F15-2.jpg");
            p18.Field.AddHookField();

            Product p19 = new Product("F17_1", "Short Name 19", "https://i.postimg.cc/025bv31G/F17-1.jpg");
            p19.Field.AddKepingABField(true);
            p19.Field.AddHookField(false);

            Product p20 = new Product("F17_2", "Short Name 20", "https://i.postimg.cc/J75G98v4/F17-2.jpg");
            p20.Field.AddHookField(false);
            p20.Field.AddHargaKainB(true); 

            Product p21 = new Product("F17_3", "Short Name 21", "https://i.postimg.cc/bJWMY4s6/F17-3.jpg");
            p21.Field.AddKepingABField(true);
            p21.Field.AddHookField(false);

            Product p22 = new Product("F19_1", "Short Name 22", "https://i.postimg.cc/5NPj23fh/F19-1.jpg");

            Product p23 = new Product("F19_2", "Short Name 23", "https://i.postimg.cc/13fXnqtf/F19-2.jpg");

            Product p24 = new Product("F21_1", "Short Name 24", "https://i.postimg.cc/ZqNqjz6m/F21-1.jpg");
            p24.Field.AddSeparateField(true);
            p24.Field.AddHargaKainB(true);
            p24.Field.AddHookField(false);

            Product p25 = new Product("F21_2", "Short Name 25", "https://i.postimg.cc/ht6j9tzM/F21-2.jpg");
            p25.Field.AddSeparateField(true);
            p25.Field.AddHargaKainB(true);
            p25.Field.AddHookField(false);

            Product p26 = new Product("F23_1", "Short Name 26", "https://i.postimg.cc/sXRgNHJh/F23-1.jpg");
            p26.Field.AddHookField(false);

            Product p27 = new Product("F25_1", "Short Name 27", "https://i.postimg.cc/Ss7xFLZt/F25-1.jpg");
            p27.Field.AddHargaKainB(true);
            p27.Field.AddHookField(false);

            Product p28 = new Product("F25_2", "Short Name 28", "https://i.postimg.cc/Xqj7VZmN/F25-2.jpg");
            p28.Field.AddHargaKainB(true);
            p28.Field.AddHookField(false);

            Product p29 = new Product("F27_1_1", "Short Name 29", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");

            Product p30 = new Product("F27_1_2", "Short Name 30", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");

            Product p31 = new Product("F27_2_1", "Short Name 31", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");

            Product p32 = new Product("F27_2_2", "Short Name 32", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");

            Product p33 = new Product("F29_1", "Short Name 33", "https://i.postimg.cc/Prqr9w12/F29-1.jpg");

            Product p34 = new Product("F31_1", "Short Name 34", "https://i.postimg.cc/Prqr9w12/F29-1.jpg");

            Product p35 = new Product("F31_2", "Short Name 35", "https://i.postimg.cc/Prqr9w12/F29-1.jpg");

            Product p36 = new Product("F35_1", "Short Name 36", "https://i.postimg.cc/htz4PRym/F35-1.jpg");

            Product p37 = new Product("F35_2", "Short Name 37", "https://i.postimg.cc/dtStYVBv/F35-2.jpg");

            Product p38 = new Product("F37_1", "Short Name 38", "https://i.postimg.cc/zGszy26c/F37-1.jpg");

            Product p39 = new Product("F39_1", "Short Name 39", "https://i.postimg.cc/j5KRXws6/F39-1.jpg");

            Product p40 = new Product("F41_1", "Short Name 40", "https://i.postimg.cc/sxgykkGv/F41-1.jpg");

            Product p41 = new Product("F43_1", "Short Name 41", "https://i.postimg.cc/rmJMYVmB/F43-1.jpg");

            Product p42 = new Product("F45_1", "Short Name 42", "https://i.postimg.cc/vT2Mb05X/F45-1.jpg");

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