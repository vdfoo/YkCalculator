using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class OutputLabelCollection
    {
        public List<OutputLabel> Formula { get; set; }

        public OutputLabelCollection()
        {
            Formula = new List<OutputLabel>();
            

            OutputLabel label = new OutputLabel(string.Empty);

            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaButang)), "Harga Butang");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaCincin)), "Harga Cincin");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaHanger)), "Harga Hanger");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaKainA)), "Harga Kain A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaKainB)), "Harga Kain B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaKainC)), "Harga Kain C");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaKainD)), "Harga Kain D");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaKainG)), "Harga Kain G");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaKainK)), "Harga Kain K");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaRainbow)), "Harga Rainbow");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaRenda)), "Harga Renda");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaRenda2)), "Harga Renda 2");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaRenda3)), "Harga Renda 3");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaRenda4)), "Harga Renda 4");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaRibbon)), "Harga Ribbon");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaTariScallet)), "Harga Tari Scallet");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.HargaTaliLangsir)), "Harga Tali Langsir");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.Image)), "Gambar");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.Jumlah)), "Jumlah");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.JumlahA)), "Jumlah A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.JumlahB)), "Jumlah B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.Keping)), "Keping");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.KepingA)), "Keping A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.KepingB)), "Keping B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.QuotationId)), "Quotation ID");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorJalur)), "Tailor Jaloh");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorKeping)), "Tailor Keping");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeterA)), "Tailor Meter A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeterB)), "Tailor Meter B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeterC)), "Tailor Meter C");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeterD)), "Tailor Meter D");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeterG)), "Tailor Meter G");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeterK)), "Tailor Meter K");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorRenda)), "Tailor Renda");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorRenda2)), "Tailor Renda 2");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorRenda3)), "Tailor Renda 3");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorRenda4)), "Tailor Renda 4");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorRendaKeping)), "Tailor Renda Keping");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorMeter)), "Tailor Meter");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorTotalKeping)), "Tailor Keping Jumlah");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.TailorInchLabel)), "Inch");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahButang)), "Upah Butang");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahHook)), "Upah Hook");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahKainA)), "Upah Kain");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahKainB)), "Upah Kain B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahCincin)), "Upah Cincin");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Output.RodSetTotal)), "Rod Set Total");

            Formula.Add(label);

        }


    }
}

