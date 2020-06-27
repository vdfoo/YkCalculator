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
            Product p1 = new Product("F1_1", "Eyelet 2 Kali Ganda", "https://i.postimg.cc/G27TFN7F/F1-1.jpg");
            p1.Field.AddCincinField();
            p1.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            p1.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            p1.TailorType = "L1T1";

            Product p2 = new Product("F1_2", "Eyelet 3 Kali Ganda", "https://i.postimg.cc/zBc3bhvp/F1-2.jpg");
            p2.Field.AddCincinField(true);
            p2.Field.AddLipatField(true);
            p2.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            p2.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            p2.TailorType = "L1T1";

            Product p3 = new Product("F3_1", "Eyelet 2 Kali Ganda", "https://i.postimg.cc/P53D0HL8/F3-1.jpg");
            p3.Field.SetTinggiLimit(105);
            p3.Field.AddCincinField(true);
            p3.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            p3.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            p3.TailorType = "L1T1";

            Product p4 = new Product("F3_2", "Eyelet 2 Kali Ganda", "https://i.postimg.cc/N0KXcnTC/F3-2.jpg");
            p4.Field.SetTinggiLimit(105);
            p4.Field.AddCincinField(true);
            p4.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            p4.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            p4.TailorType = "L1T1";

            Product p5 = new Product("F3_3", "Eyelet 2 Kali Ganda", "https://i.postimg.cc/bNq2Jrkt/F3-3.jpg");
            p5.Field.SetTinggiLimit(105);
            p5.Field.AddCincinField(true);
            p5.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            p5.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG"); 
            p5.TailorType = "L1T1";

            Product p6 = new Product("F3_4", "Eyelet 2 Kali Ganda", "https://i.postimg.cc/Hng8bsNF/F3-4.jpg");
            p6.Field.SetTinggiLimit(105);
            p6.Field.AddCincinField(true);
            p6.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            p6.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            p6.TailorType = "L1T1";

            Product p7 = new Product("F5_1", "Pleat Mati Butang (2 Kali Ganda)", "https://i.postimg.cc/sDKGZz40/F5-1.jpg");
            p7.Field.AddHargaButangField();
            p7.Field.AddHookField();
            p7.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p7.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p7.TailorType = "L2T2";

            Product p8 = new Product("F5_2", "Pleat Mati Butang (2 Kali Ganda)", "https://i.postimg.cc/zGBbCQdD/F5-2.jpg");
            p8.Field.AddHargaButangField();
            p8.Field.AddHookField();
            p8.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p8.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p8.TailorType = "L2T2";

            Product p9 = new Product("F7_1", "Pleat Mati 2 Kali Ganda", "https://i.postimg.cc/63RG7GMd/F7-1.jpg");
            p9.Field.AddHookField();
            p9.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p9.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p9.TailorType = "L2T2";

            Product p10 = new Product("F7_2", "Pleat Mati 2 Kali Ganda", "https://i.postimg.cc/JhSk4Q5r/F7-2.jpg");
            p10.Field.AddHookField();
            p10.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p10.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p10.TailorType = "L2T2";

            Product p11 = new Product("F9_1", "Pleat Mati 3 Kali Ganda", "https://i.postimg.cc/h4LdcTzn/F9-1.jpg");
            p11.Field.AddHookField();
            p11.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p11.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p11.TailorType = "L2T2";

            Product p12 = new Product("F9_2", "Pleat Mati 3 Kali Ganda", "https://i.postimg.cc/T1JL0vM1/F9-2.jpg");
            p12.Field.AddHookField();
            p12.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p12.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p12.TailorType = "L2T2";

            Product p13 = new Product("F11_1", "Short Name 11-1", "https://i.postimg.cc/3xcynZ6X/F11-1.jpg");
            p13.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p13.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p13.TailorType = "L2T2";

            Product p14 = new Product("F11_2", "Short Name 11-2", "https://i.postimg.cc/pd5m7Fbg/F11-2.jpg");
            p14.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p14.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p14.TailorType = "L2T2";

            Product p15 = new Product("F13_1", "Dawai", "https://i.postimg.cc/cHqvNLd6/F13-1.jpg");
            p15.Field.RemoveLayout();
            p15.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p15.TailorType = "L2";

            Product p16 = new Product("F13_2", "Dawai", "https://i.postimg.cc/QtpHNZMm/F13-2.jpg");
            p16.Field.RemoveLayout();
            p16.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p16.TailorType = "L2";

            Product p17 = new Product("F15_1", "Hook", "https://i.postimg.cc/90CzrgRh/F15-1.jpg");
            p17.Field.AddHookField();
            p17.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p17.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p17.TailorType = "L2T2";

            Product p18 = new Product("F15_2", "Hook", "https://i.postimg.cc/T101mjgW/F15-2.jpg");
            p18.Field.AddHookField();
            p18.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p18.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p18.TailorType = "L2T2";

            Product p19 = new Product("F17_1", "Hook Combine Kiri Kanan", "https://i.postimg.cc/025bv31G/F17-1.jpg");
            p19.Field.AddKepingABField(true);
            p19.Field.AddHookField(false);
            p19.TailorLPath = Transform.GenerateTailorBaseImage("L3.PNG");
            p19.TailorTPath = Transform.GenerateTailorBaseImage("T3.PNG");
            p19.TailorType = "L3T3";

            Product p20 = new Product("F17_2", "Hook Combine Kiri Kanan", "https://i.postimg.cc/J75G98v4/F17-2.jpg");
            p20.Field.AddHookField(false);
            p20.Field.AddHargaKainB(true);
            p20.TailorLPath = Transform.GenerateTailorBaseImage("L3.PNG");
            p20.TailorTPath = Transform.GenerateTailorBaseImage("T3.PNG");
            p20.TailorType = "L3T3";

            Product p21 = new Product("F17_3", "Hook Combine Kiri Kanan", "https://i.postimg.cc/bJWMY4s6/F17-3.jpg");
            p21.Field.AddKepingABField(true);
            p21.Field.AddHookField(false);
            p21.TailorLPath = Transform.GenerateTailorBaseImage("L3.PNG");
            p21.TailorTPath = Transform.GenerateTailorBaseImage("T3.PNG");
            p21.TailorType = "L3T3";

            Product p22 = new Product("F19_1", "Short Name 19-1", "https://i.postimg.cc/5NPj23fh/F19-1.jpg");
            p22.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p22.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p22.TailorType = "L2T2";

            Product p23 = new Product("F19_2", "Short Name 19-2", "https://i.postimg.cc/13fXnqtf/F19-2.jpg");
            p23.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p23.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p23.TailorType = "L2T2";

            Product p24 = new Product("F21_1", "Scallet Hook", "https://i.postimg.cc/ZqNqjz6m/F21-1.jpg");
            p24.Field.AddSeparateField(true);
            p24.Field.AddHargaKainB(true);
            p24.Field.AddHookField(false);
            p24.Field.AddTinggiAField(true);
            p24.TailorLPath = Transform.GenerateTailorBaseImage("L4.PNG");
            p24.TailorTPath = Transform.GenerateTailorBaseImage("T4.PNG");
            p24.TailorType = "L4T4";

            Product p25 = new Product("F21_2", "Scallet Hook", "https://i.postimg.cc/ht6j9tzM/F21-2.jpg");
            p25.Field.AddSeparateField(true);
            p25.Field.AddHargaKainB(true);
            p25.Field.AddHookField(false);
            p25.TailorLPath = Transform.GenerateTailorBaseImage("L4.PNG");
            p25.TailorTPath = Transform.GenerateTailorBaseImage("T4.PNG");
            p25.TailorType = "L4T4";

            Product p26 = new Product("F23_1", "Rail (Pattern Kayu)", "https://i.postimg.cc/sXRgNHJh/F23-1.jpg");
            p26.Field.AddHookField(false);
            p26.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            p26.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            p26.TailorType = "L2T2";

            Product p27 = new Product("F25_1", "Hook (Anak Langsir)", "https://i.postimg.cc/Ss7xFLZt/F25-1.jpg");
            p27.Field.AddHargaKainB(true);
            p27.Field.AddHookField(false);
            p27.TailorLPath = Transform.GenerateTailorBaseImage("L6.PNG");
            p27.TailorTPath = Transform.GenerateTailorBaseImage("T6.PNG");
            p27.TailorType = "L6T6";

            Product p28 = new Product("F25_2", "Hook (Anak Langsir)", "https://i.postimg.cc/Xqj7VZmN/F25-2.jpg");
            p28.Field.AddHargaKainB(true);
            p28.Field.AddHookField(false);
            p28.TailorLPath = Transform.GenerateTailorBaseImage("L6.PNG");
            p28.TailorTPath = Transform.GenerateTailorBaseImage("T6.PNG");
            p28.TailorType = "L6T6";

            Product p29 = new Product("F27_1_1", "Eyelet (Anak Langsir)", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");
            p29.Field.AddHargaKainB();
            p29.Field.AddCincinField();
            p29.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p29.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p29.TailorType = "L5T5";

            Product p30 = new Product("F27_1_2", "Eyelet (Anak Langsir)", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");
            p30.Field.AddHargaKainB();
            p30.Field.AddCincinField();
            p30.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p30.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p30.TailorType = "L5T5";

            Product p31 = new Product("F27_2_1", "Eyelet (Anak Langsir)", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");
            p31.Field.AddHargaKainB();
            p31.Field.AddCincinField();
            p31.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p31.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p31.TailorType = "L5T5";

            Product p32 = new Product("F27_2_2", "Eyelet (Anak Langsir)", "https://i.postimg.cc/BZpnmgPj/F27-1-1.jpg");
            p32.Field.AddHargaKainB();
            p32.Field.AddCincinField();
            p32.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p32.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p32.TailorType = "L5T5";

            Product p33 = new Product("F29_1", "Eyelet (Scallet Double Layer)", "https://i.postimg.cc/Prqr9w12/F29-1.jpg");
            p33.Field.AddHargaKainB();
            p33.Field.AddLipatField();
            p33.Field.AddCincinField();
            p33.Field.AddHookField();
            p33.TailorLPath = Transform.GenerateTailorBaseImage("L7.PNG");
            p33.TailorTPath = Transform.GenerateTailorBaseImage("T7.PNG");
            p33.TailorType = "L7T7";

            Product p34 = new Product("F31_1", "Eyelet (Scallet Double Layer)", "https://i.postimg.cc/Prqr9w12/F29-1.jpg");
            p34.Field.AddHargaKainB();
            p34.Field.AddLipatField();
            p34.Field.AddCincinField();
            p34.Field.AddHookField();
            p34.TailorLPath = Transform.GenerateTailorBaseImage("L7.PNG");
            p34.TailorTPath = Transform.GenerateTailorBaseImage("T7.PNG");
            p34.TailorType = "L7T7";

            Product p35 = new Product("F31_2", "Eyelet (Scallet Double Layer)", "https://i.postimg.cc/Prqr9w12/F29-1.jpg");
            p35.Field.AddHargaKainB();
            p35.Field.AddLipatField();
            p35.Field.AddCincinField();
            p35.Field.AddHookField();
            p35.TailorLPath = Transform.GenerateTailorBaseImage("L7.PNG");
            p35.TailorTPath = Transform.GenerateTailorBaseImage("T7.PNG");
            p35.TailorType = "L7T7";

            Product p36 = new Product("F33_1", "Eyelet Combine Atas (Butang)", "https://i.postimg.cc/htz4PRym/F35-1.jpg");
            p36.Field.AddHargaKainB();
            p36.Field.AddLipatField();
            p36.Field.AddCincinField();
            p36.Field.AddHargaButangField();
            p36.TailorLPath = Transform.GenerateTailorBaseImage("L8.PNG");
            p36.TailorTPath = Transform.GenerateTailorBaseImage("T8.PNG");
            p36.TailorType = "L8T8";

            Product p37 = new Product("F35_1", "Eyelet Combine Atas (Butang)", "https://i.postimg.cc/htz4PRym/F35-1.jpg");
            p37.Field.AddHargaKainB();
            p37.Field.AddLipatField();
            p37.Field.AddHargaButangField();
            p37.Field.AddCincinField();
            p37.TailorLPath = Transform.GenerateTailorBaseImage("L8.PNG");
            p37.TailorTPath = Transform.GenerateTailorBaseImage("T8.PNG");
            p37.TailorType = "L8T8";

            Product p38 = new Product("F35_2", "Eyelet Combine Atas (Butang)", "https://i.postimg.cc/dtStYVBv/F35-2.jpg");
            p38.Field.AddHargaKainB();
            p38.Field.AddLipatField();
            p38.Field.AddHargaButangField();
            p38.Field.AddCincinField();
            p38.TailorLPath = Transform.GenerateTailorBaseImage("L8.PNG");
            p38.TailorTPath = Transform.GenerateTailorBaseImage("T8.PNG");
            p38.TailorType = "L8T8";

            Product p39 = new Product("F37_1", "Eyelet Combine Kiri Kanan (3 Kali Ganda)", "https://i.postimg.cc/zGszy26c/F37-1.jpg");
            p39.Field.AddHargaKainB();
            p39.Field.AddKepingBField();
            p39.Field.AddHargaKKepingKField(true);
            p39.Field.AddCincinKField();
            p39.Field.AddCincinBField();
            p39.Field.RemoveHargaKainA();
            p39.TailorLPath = Transform.GenerateTailorBaseImage("L9.PNG");
            p39.TailorTPath = Transform.GenerateTailorBaseImage("T9.PNG");
            p39.TailorType = "L9T9";

            Product p40 = new Product("F39_1", "Eyelet Combine Kiri Kanan (2 Kali Ganda)", "https://i.postimg.cc/j5KRXws6/F39-1.jpg");
            p40.Field.OverwriteDisplayNameByPropertyName("HargaKainA", "Harga Kain K");
            p40.Field.AddHargaKainB();
            p40.Field.AddCincinField();
            p40.TailorLPath = Transform.GenerateTailorBaseImage("L9.PNG");
            p40.TailorTPath = Transform.GenerateTailorBaseImage("T9.PNG");
            p40.TailorType = "L9T9";

            Product p41 = new Product("F41_1", "Eyelet Combine (3 Kali Ganda)", "https://i.postimg.cc/sxgykkGv/F41-1.jpg");
            p41.Field.AddHargaKainC();
            p41.Field.AddHargaKainG();
            p41.Field.AddCincinCField();
            p41.Field.AddCincinGField();
            p41.Field.AddKepingCGField();
            p41.Field.RemoveHargaKainA();
            p41.TailorLPath = Transform.GenerateTailorBaseImage("L10.PNG");
            p41.TailorTPath = Transform.GenerateTailorBaseImage("T10.PNG");
            p41.TailorType = "L10T10";

            Product p42 = new Product("F43_1", "Eyelet Combine (3 Kali Ganda)", "https://i.postimg.cc/rmJMYVmB/F43-1.jpg");
            p42.Field.AddHargaKainC();
            p42.Field.AddHargaKainG();
            p42.Field.AddCincinCField();
            p42.Field.AddCincinGField();
            p42.Field.AddKepingCGField();
            p42.Field.RemoveHargaKainA();
            p42.TailorLPath = Transform.GenerateTailorBaseImage("L9.PNG");
            p42.TailorTPath = Transform.GenerateTailorBaseImage("T9.PNG");
            p42.TailorType = "L9T9";

            Product p43 = new Product("F45_1", "Eyelet Combine Atas (3 Kali Ganda)", "https://i.postimg.cc/vT2Mb05X/F45-1.jpg");
            p43.Field.AddTinggiBField();
            p43.Field.AddHargaKainB();
            p43.Field.AddCincinField();
            p43.Field.OverwriteDisplayNameByPropertyName("Tinggi", "Tinggi A");
            p43.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p43.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p43.TailorType = "L5T5";

            Product p44 = new Product("F45_2", "Eyelet Combine Atas (3 Kali Ganda)", "https://i.postimg.cc/vT2Mb05X/F45-1.jpg");
            p44.Field.AddTinggiBField();
            p44.Field.AddHargaKainB();
            p44.Field.AddCincinField();
            p44.Field.OverwriteDisplayNameByPropertyName("Tinggi", "Tinggi A");
            p44.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p44.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p44.TailorType = "L5T5";

            // Need to update image from here onward
            Product p45 = new Product("F47_1", "Eyelet Combine Atas (2 Kali Ganda)", "https://i.postimg.cc/jwJ4yY9n/F47-1.jpg");
            p45.Field.OverwriteDisplayNameByPropertyName("Tinggi", "Tinggi A");
            p45.Field.AddTinggiBField();
            p45.Field.AddHargaKainB();
            p45.Field.AddCincinField();
            p45.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p45.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p45.TailorType = "L5T5";

            Product p46 = new Product("F49_1", "Eyelet Combine Atas (3 Kali Ganda)", "https://i.postimg.cc/yDVjt5J2/F49-F51-F53.jpg");
            p46.Field.AddMeterDiscountAmountField();
            p46.Field.AddHargaKainB();
            p46.Field.AddCincinField();
            p46.TailorLPath = Transform.GenerateTailorBaseImage("L5.PNG");
            p46.TailorTPath = Transform.GenerateTailorBaseImage("T5.PNG");
            p46.TailorType = "L5T5";

            Product p47 = new Product("F51_1", "Hook Combine Atas", "https://i.postimg.cc/yDVjt5J2/F49-F51-F53.jpg");
            p47.Field.AddHargaKainB();
            p47.Field.AddHookField();
            p47.TailorLPath = Transform.GenerateTailorBaseImage("L6.PNG");
            p47.TailorTPath = Transform.GenerateTailorBaseImage("T6.PNG");
            p47.TailorType = "L6T6";

            Product p48 = new Product("F53_1", "Hook Combine Atas", "https://i.postimg.cc/yDVjt5J2/F49-F51-F53.jpg");
            p48.Field.AddHargaKainB();
            p48.Field.AddHookField();
            p48.Field.AddMeterDiscountAmountField();
            p48.TailorLPath = Transform.GenerateTailorBaseImage("L6.PNG");
            p48.TailorTPath = Transform.GenerateTailorBaseImage("T6.PNG");
            p48.TailorType = "L6T6";

            Product p49 = new Product("F55_1", "Scallet 3 Layer", "https://i.postimg.cc/SXRrNMfr/F55.jpg");
            p49.Field.AddHargaKainB();
            p49.Field.AddHargaKainC();
            p49.Field.AddMeterDiscountAmountField();
            p49.Field.AddHookField();
            p49.Field.AddRendaField();
            p49.Field.RemoveLayout();
            p49.TailorLPath = Transform.GenerateTailorBaseImage("L11.PNG");
            p49.TailorType = "L11";

            Product p50 = new Product("F55_2", "Scallet 2 Layer", "https://i.postimg.cc/SXRrNMfr/F55.jpg");
            p50.Field.AddHargaKainB();
            p50.Field.AddHargaKainC();
            p50.Field.AddMeterDiscountAmountField();
            p50.Field.AddHookField();
            p50.Field.AddRendaField();
            p50.Field.RemoveLayout();
            p50.TailorLPath = Transform.GenerateTailorBaseImage("L11.PNG");
            p50.TailorType = "L11";

            Product p51 = new Product("F57_1", "Scallet 3 Layer", "https://i.postimg.cc/94kB4Qxj/F57-1-F57-2.jpg");
            p51.Field.AddHargaKainB();
            p51.Field.AddHargaKainC();
            p51.Field.AddMeterDiscountAmountField();
            p51.Field.AddHookField();
            p51.Field.AddRendaField();
            p51.Field.AddRainbowField();
            p51.Field.RemoveLayout();
            p51.TailorLPath = Transform.GenerateTailorBaseImage("L11.PNG");
            p51.TailorType = "L11";

            Product p52 = new Product("F57_2", "Scallet 3 Layer", "https://i.postimg.cc/94kB4Qxj/F57-1-F57-2.jpg");
            p52.Field.AddHargaKainB();
            p52.Field.AddHargaKainC();
            p52.Field.AddMeterDiscountAmountField();
            p52.Field.AddHookField();
            p52.Field.AddRendaField();
            p52.Field.AddRainbowField();
            p52.Field.RemoveLayout();
            p52.TailorLPath = Transform.GenerateTailorBaseImage("L11.PNG");
            p52.TailorType = "L11";

            Product p53 = new Product("F58_1", "Scallet 3 Layer", "https://i.postimg.cc/BP9cgw9Y/F58-1-F58-2.jpg");
            p53.Field.AddHargaKainB();
            p53.Field.AddHargaKainC();
            p53.Field.AddHookField();
            p53.Field.AddRendaField();
            p53.Field.AddRainbowField();
            p53.Field.AddHargaButangField(true);
            p53.Field.AddButangChoiceField(true);
            p53.Field.RemoveLayout();
            p53.TailorLPath = Transform.GenerateTailorBaseImage("L12.PNG");
            p53.TailorType = "L12";

            Product p54 = new Product("F58_2", "Scallet 3 Layer", "https://i.postimg.cc/BP9cgw9Y/F58-1-F58-2.jpg");
            p54.Field.AddHargaKainB();
            p54.Field.AddHargaKainC();
            p54.Field.AddHookField();
            p54.Field.AddRendaField();
            p54.Field.AddRainbowField();
            p54.Field.AddHargaButangField(true);
            p54.Field.AddButangChoiceField(true);
            p54.Field.RemoveLayout();
            p54.TailorLPath = Transform.GenerateTailorBaseImage("L12.PNG");
            p54.TailorType = "L12";

            Product p55 = new Product("F60_1", "Scallet 2 Layer", "https://i.postimg.cc/8jGmf3bs/F-60-1-F60-2.jpg");
            p55.Field.AddCincinField();
            p55.Field.AddHookField();
            p55.Field.AddRendaField();
            p55.Field.AddRainbowField();
            p55.Field.RemoveLayout();
            p55.TailorLPath = Transform.GenerateTailorBaseImage("L13.PNG");
            p55.TailorType = "L13";

            Product p56 = new Product("F60_2", "Scallet 2 Layer", "https://i.postimg.cc/8jGmf3bs/F-60-1-F60-2.jpg");
            p56.Field.AddCincinField();
            p56.Field.AddHookField();
            p56.Field.AddRendaField();
            p56.Field.AddRainbowField();
            p56.Field.RemoveLayout();
            p56.TailorLPath = Transform.GenerateTailorBaseImage("L13.PNG");
            p56.TailorType = "L13";

            Product p57 = new Product("F62_1", "Scallet 2 Layer", "https://i.postimg.cc/7b0N6D0p/F62-1-F62-2.jpg");
            p57.Field.AddTaliScalletQuantityField();
            p57.Field.AddHargaButangField();
            p57.Field.AddHookField();
            p57.Field.AddRendaField();
            p57.Field.AddRainbowField();
            p57.Field.AddCincinField();
            p57.Field.RemoveLayout();
            p57.TailorLPath = Transform.GenerateTailorBaseImage("L14.PNG");
            p57.TailorType = "L14";

            Product p58 = new Product("F62_2", "Scallet 2 Layer", "https://i.postimg.cc/7b0N6D0p/F62-1-F62-2.jpg");
            p58.Field.AddTaliScalletQuantityField();
            p58.Field.AddHargaButangField();
            p58.Field.AddHookField();
            p58.Field.AddRendaField();
            p58.Field.AddRainbowField();
            p58.Field.AddCincinField();
            p58.Field.RemoveLayout();
            p58.TailorLPath = Transform.GenerateTailorBaseImage("L14.PNG");
            p58.TailorType = "L14";

            Product p59 = new Product("F64_1", "Scallet 1 Layer", "https://i.postimg.cc/6yhLr0Hc/F64.jpg");
            p59.Field.AddHargaButangField();
            p59.Field.AddHookField();
            p59.Field.AddRendaField();
            p59.Field.AddRainbowField();
            p59.Field.RemoveLayout();
            p59.TailorLPath = Transform.GenerateTailorBaseImage("L15.PNG");
            p59.TailorType = "L15";

            Product p60 = new Product("F64_2", "Scallet 1 Layer", "https://i.postimg.cc/6yhLr0Hc/F64.jpg");
            p60.Field.AddHargaButangField();
            p60.Field.AddHookField();
            p60.Field.AddRendaField();
            p60.Field.AddRainbowField();
            p60.Field.RemoveLayout();
            p60.TailorLPath = Transform.GenerateTailorBaseImage("L15.PNG");
            p60.TailorType = "L15";

            Product p61 = new Product("F66_1", "Scallet Telinga 2 Layer", "https://i.postimg.cc/3kJjnvVT/F66.jpg");
            p61.Field.AddHargaButangField();
            p61.Field.AddHookField();
            p61.Field.AddRendaField();
            p61.Field.AddRainbowField();
            p61.Field.RemoveLayout();
            p61.TailorLPath = Transform.GenerateTailorBaseImage("L16.PNG");
            p61.TailorType = "L16";

            Product p62 = new Product("F66_2", "Scallet Telinga 2 Layer", "https://i.postimg.cc/3kJjnvVT/F66.jpg");
            p62.Field.AddHargaButangField();
            p62.Field.AddHookField();
            p62.Field.AddRendaField();
            p62.Field.AddRainbowField();
            p62.Field.RemoveLayout();
            p62.TailorLPath = Transform.GenerateTailorBaseImage("L16.PNG");
            p62.TailorType = "L16";

            Product p63 = new Product("F68_1", "Scallet Telinga 2 Layer", "https://i.postimg.cc/ZW78gqzy/F68.jpg");
            p63.Field.AddHargaButangField();
            p63.Field.AddCincinField();
            //p63.Field.AddTaliScalletQuantityField();
            p63.Field.AddHargaTaliField();
            p63.Field.AddHookField();
            p63.Field.AddRendaField();
            p63.Field.AddRainbowField();
            p63.Field.RemoveLayout();
            p63.TailorLPath = Transform.GenerateTailorBaseImage("L17.PNG");
            p63.TailorType = "L17";

            Product p64 = new Product("F68_2", "Scallet Telinga 2 Layer", "https://i.postimg.cc/ZW78gqzy/F68.jpg");
            p64.Field.AddHargaButangField();
            p64.Field.AddCincinField();
            //p64.Field.AddTaliScalletQuantityField();
            p64.Field.AddHargaTaliField();
            p64.Field.AddHookField();
            p64.Field.AddRendaField();
            p64.Field.AddRainbowField();
            p64.Field.RemoveLayout();
            p64.TailorLPath = Transform.GenerateTailorBaseImage("L17.PNG");
            p64.TailorType = "L17";

            Product p65 = new Product("F70_1", "Scallet Telinga 3 Layer", "https://i.postimg.cc/nsX4ttnS/F70.jpg");
            p65.Field.AddHookField();
            p65.Field.AddRendaField();
            p65.Field.AddRainbowField();
            p65.Field.RemoveLayout();
            p65.TailorLPath = Transform.GenerateTailorBaseImage("L18.PNG");
            p65.TailorType = "L18";

            Product p66 = new Product("F70_2", "Scallet Telinga 3 Layer", "https://i.postimg.cc/nsX4ttnS/F70.jpg");
            p66.Field.AddHookField();
            p66.Field.AddRendaField();
            p66.Field.AddRainbowField();
            p66.Field.RemoveLayout();
            p66.TailorLPath = Transform.GenerateTailorBaseImage("L18.PNG");
            p66.TailorType = "L18";

            Product p67 = new Product("F72_1", "Scallet Telinga Single Layer", "https://i.postimg.cc/rd7SVYmV/F72.jpg");
            p67.Field.AddHargaButangField();
            p67.Field.AddHookField();
            p67.Field.AddRendaField();
            p67.Field.AddRainbowField();
            p67.Field.RemoveLayout();
            p67.TailorLPath = Transform.GenerateTailorBaseImage("L19.PNG");
            p67.TailorType = "L19";

            Product p68 = new Product("F72_2", "Scallet Telinga Single Layer", "https://i.postimg.cc/rd7SVYmV/F72.jpg");
            p68.Field.AddHargaButangField();
            p68.Field.AddHookField();
            p68.Field.AddRendaField();
            p68.Field.AddRainbowField();
            p68.Field.RemoveLayout();
            p68.TailorLPath = Transform.GenerateTailorBaseImage("L19.PNG");
            p68.TailorType = "L19";

            Product p69 = new Product("F74_1", "Scallet 3 Layer", "https://i.postimg.cc/7G7SfMGg/F74.jpg");
            p69.Field.AddHookField();
            p69.Field.AddRendaField();
            p69.Field.AddRainbowField();
            p69.Field.RemoveLayout();
            p69.TailorLPath = Transform.GenerateTailorBaseImage("L20.PNG");
            p69.TailorType = "L20";

            Product p70 = new Product("F74_2", "Scallet 3 Layer", "https://i.postimg.cc/7G7SfMGg/F74.jpg");
            p70.Field.AddHookField();
            p70.Field.AddRendaField();
            p70.Field.AddRainbowField();
            p70.Field.RemoveLayout();
            p70.TailorLPath = Transform.GenerateTailorBaseImage("L20.PNG");
            p70.TailorType = "L20";

            Product p71 = new Product("F76_1", "Scallet 2 Layer", "https://i.postimg.cc/XBkFgjgq/F76.jpg");
            p71.Field.AddHookField();
            p71.Field.AddRendaField();
            p71.Field.AddRainbowField();
            p71.Field.RemoveLayout();
            p71.TailorLPath = Transform.GenerateTailorBaseImage("L21.PNG");
            p71.TailorType = "L21";

            Product p72 = new Product("F76_2", "Scallet 2 Layer", "https://i.postimg.cc/XBkFgjgq/F76.jpg");
            p72.Field.AddHookField();
            p72.Field.AddRendaField();
            p72.Field.AddRainbowField();
            p72.Field.RemoveLayout();
            p72.TailorLPath = Transform.GenerateTailorBaseImage("L21.PNG");
            p72.TailorType = "L21";

            Product p73 = new Product("F78_1", "Scallet 1 Layer", "https://i.postimg.cc/jnbPNwPB/F78.jpg");
            p73.Field.AddRibbonField();
            p73.Field.AddHookField();
            p73.Field.AddRendaField();
            p73.Field.RemoveLayout();
            p73.TailorLPath = Transform.GenerateTailorBaseImage("L22.PNG");
            p73.TailorType = "L22";

            Product p74 = new Product("F78_2", "Scallet 1 Layer", "https://i.postimg.cc/jnbPNwPB/F78.jpg");
            p74.Field.AddRibbonField();
            p74.Field.AddHookField();
            p74.Field.AddRendaField();
            p74.Field.RemoveLayout();
            p74.TailorLPath = Transform.GenerateTailorBaseImage("L22.PNG");
            p74.TailorType = "L22";

            Product p81 = new Product("F88_1", "Hook (Anak Langsir)", Constant.DefaultCurtainImage);
            p81.Field.AddHookField();
            p81.Field.AddRendaField();
            p81.TailorLPath = Transform.GenerateTailorBaseImage("L23.PNG");
            p81.TailorTPath = Transform.GenerateTailorBaseImage("T23.PNG");
            p81.TailorType = "L23T23";

            Product p82 = new Product("F88_2", "Hook (Anak Langsir)", Constant.DefaultCurtainImage);
            p82.Field.AddHookField();
            p82.Field.AddRendaField();
            p82.TailorLPath = Transform.GenerateTailorBaseImage("L23.PNG");
            p82.TailorTPath = Transform.GenerateTailorBaseImage("T23.PNG");
            p82.TailorType = "L23T23";

            Product p83 = new Product("F90_1", "Langsir Pattern Tali", Constant.DefaultCurtainImage);
            p83.Field.RemoveLayout();
            p83.TailorLPath = Transform.GenerateTailorBaseImage("L24.PNG");
            p83.TailorType = "L24";

            Product p84 = new Product("F90_2", "Langsir Pattern Tali", Constant.DefaultCurtainImage);
            p84.Field.RemoveLayout();
            p84.TailorLPath = Transform.GenerateTailorBaseImage("L24.PNG");
            p84.TailorType = "L24";

            Product p85 = new Product("F97_1", "Eyelet Double Rod", Constant.DefaultCurtainImage);
            p85.Field.AddCincinField();
            p85.TailorLPath = Transform.GenerateTailorBaseImage("L25.PNG");
            p85.TailorTPath = Transform.GenerateTailorBaseImage("T25.PNG");
            p85.TailorType = "L25T25";

            Product p86 = new Product("F97_2_1", "Eyelet Double Rod", Constant.DefaultCurtainImage);
            p86.Field.AddCincinField();
            p86.TailorLPath = Transform.GenerateTailorBaseImage("L25.PNG");
            p86.TailorTPath = Transform.GenerateTailorBaseImage("T25.PNG");
            p86.TailorType = "L25T25";

            Product p87 = new Product("F97_2_2", "Eyelet Double Rod", Constant.DefaultCurtainImage);
            p87.Field.AddCincinField();
            p87.TailorLPath = Transform.GenerateTailorBaseImage("L25.PNG");
            p87.TailorTPath = Transform.GenerateTailorBaseImage("T25.PNG");
            p87.TailorType = "L25T25";

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
            products.Add(p43);
            products.Add(p44);
            products.Add(p45);
            products.Add(p46);
            products.Add(p47);
            products.Add(p48);
            products.Add(p49);
            products.Add(p50);
            products.Add(p51);
            products.Add(p52);
            products.Add(p53);
            products.Add(p54);
            products.Add(p55);
            products.Add(p56);
            products.Add(p57);
            products.Add(p58);
            products.Add(p59);
            products.Add(p60);
            products.Add(p61);
            products.Add(p62);
            products.Add(p63);
            products.Add(p64);
            products.Add(p65);
            products.Add(p66);
            products.Add(p67);
            products.Add(p68);
            products.Add(p69);
            products.Add(p70);
            products.Add(p71);
            products.Add(p72);
            products.Add(p73);
            products.Add(p74);
            products.Add(p81);
            products.Add(p82);
            products.Add(p83);
            products.Add(p84);
            products.Add(p85);
            products.Add(p86);
            products.Add(p87);
            return products;
        }

        [HttpGet("HiddenRail")]
        public List<string> GetHiddenProduct()
        {
            List<string> hiddenRail = new List<string>();
            hiddenRail.Add("F97_1");
            hiddenRail.Add("F97_2_1");
            hiddenRail.Add("F97_2_2");

            return hiddenRail;
        }

        [HttpGet("Rail")]
        public IEnumerable<Product> GetRailProduct()
        {
            Product p98 = new Product("F98", "Rail", Constant.DefaultCurtainImage, true);
            F98ProductCollection f98ProductCollection = new F98ProductCollection();
            p98 = f98ProductCollection.Initialize(p98);

            List<Product> products = new List<Product>();
            products.Add(p98);
            return products;
        }

        [HttpGet("Rod")]
        public IEnumerable<Product> GetRodProduct()
        {
            Product p85_1 = new Product("F92_1", "Rod Kayu Hitam", Constant.DefaultCurtainImage, true);
            F92_1ProductCollection f92_1ProductCollection = new F92_1ProductCollection();
            p85_1 = f92_1ProductCollection.Initialize(p85_1);

            Product p85_2 = new Product("F92_1", "Rod Kayu Coco", Constant.DefaultCurtainImage, true);
            p85_2 = f92_1ProductCollection.Initialize(p85_2);

            Product p86_1 = new Product("F92_2", "Rod Kayu Hitam (siap pasang)", Constant.DefaultCurtainImage, true);
            F92_2ProductCollection f92_2ProductCollection = new F92_2ProductCollection();
            p86_1 = f92_2ProductCollection.Initialize(p86_1);

            Product p86_2 = new Product("F92_2", "Rod Kayu Coco (siap pasang)", Constant.DefaultCurtainImage, true);
            p86_2 = f92_2ProductCollection.Initialize(p86_2);

            Product p87 = new Product("F93_1", "Rod Kayu Putih", Constant.DefaultCurtainImage, true);
            F93_1ProductCollection f93_1ProductCollection = new F93_1ProductCollection();
            p87 = f93_1ProductCollection.Initialize(p87);

            Product p88 = new Product("F93_2", "Rod Kayu Putih (siap pasang)", Constant.DefaultCurtainImage, true);
            F93_2ProductCollection f93_2ProductCollection = new F93_2ProductCollection();
            p88 = f93_2ProductCollection.Initialize(p88);

            Product p89_1 = new Product("F94_1", "Rod Aluminium Meroon", Constant.DefaultCurtainImage, true);
            F94_1ProductCollection f94_1ProductCollection = new F94_1ProductCollection();
            p89_1 = f94_1ProductCollection.Initialize(p89_1);

            Product p89_2 = new Product("F94_1", "Rod Aluminium Silver Rose", Constant.DefaultCurtainImage, true);
            p89_2 = f94_1ProductCollection.Initialize(p89_2);

            Product p89_3 = new Product("F94_1", "Rod Aluminium Putih", Constant.DefaultCurtainImage, true);
            p89_3 = f94_1ProductCollection.Initialize(p89_3);

            Product p89_4 = new Product("F94_1", "Rod Aluminium Koko Gelap", Constant.DefaultCurtainImage, true);
            p89_4 = f94_1ProductCollection.Initialize(p89_4);

            Product p89_5 = new Product("F94_1", "Rod Aluminium Hitam", Constant.DefaultCurtainImage, true);
            p89_5 = f94_1ProductCollection.Initialize(p89_5);

            Product p90_1 = new Product("F94_2", "Rod Aluminium Meroon (siap pasang)", Constant.DefaultCurtainImage, true);
            F94_2ProductCollection f94_2ProductCollection = new F94_2ProductCollection();
            p90_1 = f94_2ProductCollection.Initialize(p90_1);

            Product p90_2 = new Product("F94_2", "Rod Aluminium Silver Rose (siap pasang)", Constant.DefaultCurtainImage, true);
            p90_2 = f94_2ProductCollection.Initialize(p90_2);

            Product p90_3 = new Product("F94_2", "Rod Aluminium Putih (siap pasang)", Constant.DefaultCurtainImage, true);
            p90_3 = f94_2ProductCollection.Initialize(p90_3);

            Product p90_4 = new Product("F94_2", "Rod Aluminium Koko Gelap (siap pasang)", Constant.DefaultCurtainImage, true);
            p90_4 = f94_2ProductCollection.Initialize(p90_4);

            Product p90_5 = new Product("F94_2", "Rod Aluminium Hitam (siap pasang)", Constant.DefaultCurtainImage, true);
            p90_5 = f94_2ProductCollection.Initialize(p90_5);

            Product p91 = new Product("F97", "Rail", Constant.DefaultCurtainImage, true);
            F97ProductCollection f97ProductCollection = new F97ProductCollection();
            p91 = f97ProductCollection.Initialize(p91);

            List<Product> products = new List<Product>();
            products.Add(p85_1);
            products.Add(p85_2);
            products.Add(p86_1);
            products.Add(p86_2);
            products.Add(p87);
            products.Add(p88);
            products.Add(p89_1);
            products.Add(p89_2);
            products.Add(p89_3);
            products.Add(p89_4);
            products.Add(p89_5);
            products.Add(p90_1);
            products.Add(p90_2);
            products.Add(p90_3);
            products.Add(p90_4);
            products.Add(p90_5);
            products.Add(p91);
            return products;
        }

        [HttpGet("Panel")]
        public IEnumerable<Product> GetPanelProduct()
        {
            Product p75 = new Product("F80", "Panel 1", "https://i.postimg.cc/5jBwJgMJ/F80.jpg", true);
            p75.ReadyMadeProduct.Add(new ReadyMadeProduct("F80.1", "1 Panel Bunga", "27'' x 84", 125));
            p75.ReadyMadeProduct.Add(new ReadyMadeProduct("F80.2", "1 Panel Kosong", "27'' x 96", 125));
            p75.ReadyMadeProduct.Add(new ReadyMadeProduct("F80.3", "2 Panel", "51'' x 84", 175));
            p75.ReadyMadeProduct.Add(new ReadyMadeProduct("F80.4", "3 Panel", "75'' x 84", 235));

            Product p76 = new Product("F81", "Panel 2", "https://i.postimg.cc/GHbvmDcy/F81.jpg", true);
            p76.ReadyMadeProduct.Add(new ReadyMadeProduct("F81.1", "1 Panel", "60'' x 84", 130));
            p76.ReadyMadeProduct.Add(new ReadyMadeProduct("F81.2", "2 Panel", "72'' x 84", 150));
            p76.ReadyMadeProduct.Add(new ReadyMadeProduct("F81.3", "3 Panel", "84'' x 84", 170));
            p76.ReadyMadeProduct.Add(new ReadyMadeProduct("F81.4", "4 Panel", "96'' x 84", 190));

            Product p77 = new Product("F82", "Panel 3", "https://i.postimg.cc/WhSgF43f/F82.jpg", true);
            p77.ReadyMadeProduct.Add(new ReadyMadeProduct("F82.1", "1 Panel", "27'' x 60", 67));
            p77.ReadyMadeProduct.Add(new ReadyMadeProduct("F82.2", "2 Panel", "51'' x 60", 77));
            p77.ReadyMadeProduct.Add(new ReadyMadeProduct("F82.3", "3 Panel", "75'' x 84", 97));

            Product p78 = new Product("F83", "Panel 4", "https://i.postimg.cc/9DMTGjwX/F83.jpg", true);
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.1", "1 Panel", "27'' x 78", 72));
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.2", "1 Panel", "27'' x 96", 82));
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.3", "1 Panel", "27'' x 120", 108));
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.4", "2 Panel", "51'' x 78", 102));
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.5", "2 Panel", "51'' x 120", 158));
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.6", "3 Panel", "75'' x 78", 125));
            p78.ReadyMadeProduct.Add(new ReadyMadeProduct("F83.7", "3 Panel", "75'' x 120", 208));

            Product p79 = new Product("F84", "Panel 5", "https://i.postimg.cc/gxThsB3V/F84.jpg", true);
            p79.ReadyMadeProduct.Add(new ReadyMadeProduct("F84.1", "1 Panel", "27'' x 78", 95));
            p79.ReadyMadeProduct.Add(new ReadyMadeProduct("F84.2", "1 Panel", "27'' x 96", 95));
            p79.ReadyMadeProduct.Add(new ReadyMadeProduct("F84.3", "2 Panel", "51'' x 78", 124));
            p79.ReadyMadeProduct.Add(new ReadyMadeProduct("F84.4", "3 Panel", "75'' x 120", 144));

            Product p80 = new Product("F85", "Panel 6", "https://i.postimg.cc/w75FWHBh/F85.jpg", true);
            p80.ReadyMadeProduct.Add(new ReadyMadeProduct("F85.1", "1 Panel", "27'' x 66", 61.70));
            p80.ReadyMadeProduct.Add(new ReadyMadeProduct("F85.2", "2 Panel", "51'' x 66", 76.70));
            p80.ReadyMadeProduct.Add(new ReadyMadeProduct("F85.3", "3 Panel", "75'' x 66", 96));

            List<Product> products = new List<Product>();
            products.Add(p75);
            products.Add(p76);
            products.Add(p77);
            products.Add(p78);
            products.Add(p79);
            products.Add(p80);
            return products;
        }

        [HttpGet("Sheer")]
        public IEnumerable<Product> GetSheerProduct()
        {
            Product s1 = new Product("S1", "Sheer-Eyelet 2 Kali Ganda (x2)", Transform.GenerateSystemBaseImage("Sheer1.JPG"));
            s1.Field.AddCincinField();
            s1.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            s1.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            s1.TailorType = "L1T1";

            Product s2 = new Product("S2", "Sheer-Eyelet 2 Kali Ganda (x3)", Transform.GenerateSystemBaseImage("Sheer1.JPG"));
            s2.Field.AddCincinField();
            s2.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            s2.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            s2.TailorType = "L1T1";

            Product s3 = new Product("S3", "Sheer-Eyelet 2 Kali Ganda (x2)", Transform.GenerateSystemBaseImage("Sheer1.JPG"));
            s3.Field.AddCincinField();
            s3.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            s3.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            s3.TailorType = "L1T1";

            Product s4 = new Product("S4", "Sheer-Eyelet 2 Kali Ganda (x3)", Transform.GenerateSystemBaseImage("Sheer1.JPG"));
            s4.Field.AddCincinField();
            s4.TailorLPath = Transform.GenerateTailorBaseImage("L1.PNG");
            s4.TailorTPath = Transform.GenerateTailorBaseImage("T1.PNG");
            s4.TailorType = "L1T1";

            Product s5 = new Product("S5", "Sheer-Hook", Transform.GenerateSystemBaseImage("Sheer1.JPG"));
            s5.TailorLPath = Transform.GenerateTailorBaseImage("L2.PNG");
            s5.TailorTPath = Transform.GenerateTailorBaseImage("T2.PNG");
            s5.TailorType = "L2T2";
            s5.Field.AddHookField();

            List<Product> products = new List<Product>();
            products.Add(s1);
            products.Add(s2);
            products.Add(s3);
            products.Add(s4);
            products.Add(s5);

            return products;
        }
    }
}