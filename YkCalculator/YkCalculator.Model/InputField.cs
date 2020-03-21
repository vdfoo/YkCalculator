using System;
using System.Collections.Generic;
using System.Text;

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

        public void AddButangField(bool required = false)
        {
            FieldDetail.Add(new Field() 
            { 
                DisplayName = "Harga Butang", 
                PropertyName = "HargaButang", 
                PropertyType = "decimal",
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
        }
    }
}
