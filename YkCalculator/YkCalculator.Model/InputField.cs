using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class InputField
    {
        public List<Field> FieldDetail { get; set; }
        

        public InputField()
        {
            InitializeDefaultField();
        }

        public InputField(List<Field> additionalField)
        {
            InitializeDefaultField(); 
            FieldDetail.AddRange(additionalField);
        }

        public void OverwriteDisplayNameByPropertyName(string propertyName, string displayName)
        {
            foreach (var fieldDetail in FieldDetail)
            {
                if(fieldDetail.PropertyName == propertyName)
                {
                    fieldDetail.DisplayName = displayName;
                }
            }
        }

        public void AddHargaButangField(bool required = false)
        {
            FieldDetail.Add(new Field() 
            { 
                DisplayName = "Harga Butang", 
                PropertyName = "HargaButang", 
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddButangChoiceField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Pilihan Butang",
                PropertyName = "ButangChoice",
                PropertyType = "int",
                ValueOption = "Full Butang:2;Half Butang:4",
                Required = required
            }) ;
        }

        public void AddHookField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Hook",
                PropertyName = "HargaHook",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddRendaField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Renda",
                PropertyName = "HargaRenda",
                PropertyType = "decimal",
                Required = required
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Renda Kuantiti",
                PropertyName = "RendaQuantity",
                PropertyType = "int",
                Required = required
            });
        }

        public void AddRainbowField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Rainbow Kuantiti",
                PropertyName = "RainbowQuantity",
                PropertyType = "int",
                Required = required
            });
        }

        public void AddRibbonField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Ribbon Kuantiti",
                PropertyName = "RibbonQuantity",
                PropertyType = "int",
                Required = required
            });
        }

        public void AddTaliScalletQuantityField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Tali Scallet Kuantity",
                PropertyName = "TariScalletQuantity",
                PropertyType = "int",
                Required = required
            });
        }

        public void AddHargaTaliField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Tali",
                PropertyName = "HargaTali",
                PropertyType = "decimal",
                Required = false
            });
        }

        public void AddCincinField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Cincin",
                PropertyName = "HargaCincin",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddCincinBField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Cincin B",
                PropertyName = "HargaCincinB",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddCincinKField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Cincin K",
                PropertyName = "HargaCincinK",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddCincinCField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Cincin C",
                PropertyName = "HargaCincinC",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddMeterDiscountAmountField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Meter Discount Amount",
                PropertyName = "MeterDiscountAmount",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddCincinGField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Cincin G",
                PropertyName = "HargaCincinG",
                PropertyType = "decimal",
                Required = required
            });
        }

        public void AddLipatField(bool required = false)
        {
            FieldDetail.Add(new Field() 
            { 
                DisplayName = "Lipat", 
                PropertyName = "Lipat", 
                PropertyType = "int",
                Required = required
            });
        }

        public void AddSeparateField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Menjahit Bersama",
                PropertyName = "Separate",
                PropertyType = "bool",
                Required = required
            });
        }

        public void AddHargaKainB(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Kain B",
                PropertyName = "HargaKainB",
                Required = true,
                PropertyType = "decimal"
            });
        }

        public void AddHargaKainC(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Kain C",
                PropertyName = "HargaKainC",
                Required = true,
                PropertyType = "decimal"
            });
        }

        public void AddHargaKainG(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Kain G",
                PropertyName = "HargaKainG",
                Required = true,
                PropertyType = "decimal"
            });
        }

        public void AddKepingABField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Keping A",
                PropertyName = "KepingA",
                PropertyType = "int",
                Required = required
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Keping B",
                PropertyName = "KepingB",
                PropertyType = "int",
                Required = required
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Kain B",
                PropertyName = "HargaKainB",
                Required = required,
                PropertyType = "decimal"
            });
        }

        public void AddKepingBField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Keping B",
                PropertyName = "KepingB",
                PropertyType = "int",
                Required = required
            });
        }

        public void AddHargaKKepingKField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Keping K",
                PropertyName = "KepingK",
                PropertyType = "int",
                Required = required
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Kain K",
                PropertyName = "HargaKainK",
                Required = required,
                PropertyType = "decimal"
            });
        }

        public void AddKepingCGField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Keping C",
                PropertyName = "KepingC",
                PropertyType = "int",
                Required = required
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Keping G",
                PropertyName = "KepingG",
                PropertyType = "int",
                Required = required
            });
        }

        public void AddTinggiBField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Tinggi B",
                PropertyName = "TinggiB",
                Required = required,
                PropertyType = "int"
            });
        }

        public void AddTinggiAField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Tinggi A",
                PropertyName = "TinggiA",
                Required = required,
                PropertyType = "int"
            });
        }

        public void RemoveLayout()
        {
            FieldDetail.RemoveAll(x => x.PropertyName == "Layout");
        }

        public void SetTinggiLimit(int tinggi)
        {
            Field tinggiWithLimit = new Field()
            {
                DisplayName = "Tinggi",
                PropertyName = "Tinggi",
                Required = true,
                PropertyType = "int",
                MaxValue = tinggi,
                ValidationError = $"Tinggi lebih daripada {tinggi} inches, tidak dapat teruskan."
            };

            FieldDetail[FieldDetail.FindIndex(ind => ind.PropertyName.Equals("Tinggi"))] = tinggiWithLimit;
            
        }

        public void RemoveHargaKainA()
        {
            FieldDetail.RemoveAll(x => x.PropertyName == "HargaKainA");
        }

        public void InitializeDefaultField()
        {
            FieldDetail = new List<Field>();
            FieldDetail.Add(new Field()
            {
                DisplayName = "Set",
                PropertyName = "Set",
                Required = true,
                PropertyType = "int"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Lebar",
                PropertyName = "Lebar",
                Required = true,
                PropertyType = "int"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Tinggi",
                PropertyName = "Tinggi",
                Required = true,
                PropertyType = "int"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Harga Kain A",
                PropertyName = "HargaKainA",
                Required = true,
                PropertyType = "decimal"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Tingkat Bawah",
                PropertyName = "TingkatBawah",
                Required = false,
                PropertyType = "string"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Tempat",
                PropertyName = "Tempat",
                Required = false,
                PropertyType = "string"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Sliding",
                PropertyName = "Sliding",
                Required = false,
                PropertyType = "string"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Tingkap",
                PropertyName = "Tingkap",
                Required = false,
                PropertyType = "string"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Tali Langsir Kuantity",
                PropertyName = "TaliLangsirQuantity",
                Required = false,
                PropertyType = "int"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Layout",
                PropertyName = "Layout",
                Required = true,
                PropertyType = "string"
            });

            FieldDetail.Add(new Field()
            {
                DisplayName = "Hanger",
                PropertyName = "Hanger",
                Required = false,
                PropertyType = "bool"
                
            });
        }
    }
}
