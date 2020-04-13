using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace YkCalculator.Model
{
    public class OutputLabelCollection
    {
        public List<OutputLabel> Formula { get; set; }

        public OutputLabelCollection()
        {
            Formula = new List<OutputLabel>();
            

            OutputLabel label = new OutputLabel(string.Empty);

            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaButang)), "Harga Butang");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaCincin)), "Harga Cincin");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaKainA)), "Harga Kain A");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaKainB)), "Harga Kain B");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaKainC)), "Harga Kain C");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaKainD)), "Harga Kain D");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaRainbow)), "Harga Rainbow");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaRenda)), "Harga Renda");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaRenda2)), "Harga Renda 2");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaRenda3)), "Harga Renda 3");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaRenda4)), "Harga Renda 4");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaRibbon)), "Harga Ribbon");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.HargaTali)), "Harga Tali");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.Image)), "Gambar");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.Jumlah)), "Jumlah");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.JumlahA)), "Jumlah A");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.JumlahB)), "Jumlah B");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.Keping)), "Keping");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.KepingA)), "KepingA");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.KepingB)), "KepingB");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.QuotationId)), "Quotation ID");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorJalur)), "Tailor Jalur");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorKeping)), "Tailor Keping");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorMeterA)), "Tailor Meter A");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorMeterB)), "Tailor Meter B");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorMeterC)), "Tailor Meter C");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorMeterD)), "Tailor Meter D");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorMeterG)), "Tailor Meter G");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorMeterK)), "Tailor Meter K");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorRenda)), "Tailor Renda");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorRenda2)), "Tailor Renda 2");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorRenda3)), "Tailor Renda 3");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorRenda4)), "Tailor Renda 4");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorRendaKeping)), "Tailor Renda Keping");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorTinggi)), "Tailor Tinggi");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorTinggiB)), "Tailor Tinggi B");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.TailorTotalKeping)), "Tailor Keping Jumlah");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.UpahButang)), "Upah Butang");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.UpahHook)), "Upah Hook");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.UpahKainA)), "Upah Kain");
            label.Fields.Add(ToLowerFirstChar(nameof(Output.UpahKainB)), "Upah Kain B");

            Formula.Add(label);

        }

        public string ToLowerFirstChar(string s)
        {
            if (s != string.Empty && char.IsUpper(s[0]))
            {
                s = char.ToLower(s[0]) + s.Substring(1);
            }

            return s;
        }
    }
}

