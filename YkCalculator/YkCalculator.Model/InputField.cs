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
                Required = required
            });
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
                DisplayName = "Renda Quantity",
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

        public void AddTariScalletField(bool required = false)
        {
            FieldDetail.Add(new Field()
            {
                DisplayName = "Tari Scallet Quantity",
                PropertyName = "TariScalletQuantity",
                PropertyType = "int",
                Required = required
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
                DisplayName = "Separate",
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
                DisplayName = "Tali Langsir Quantity",
                PropertyName = "TaliLangsirQuantity",
                Required = false,
                PropertyType = "int"
            });

            
        }
    }
}
