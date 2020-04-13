using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class OutputLabelCollection
    {
        public List<OutputLabel> Formula { get; set; }

        public OutputLabelCollection()
        {
            Formula = new List<OutputLabel>();

            OutputLabel label = new OutputLabel("F1_1");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("upahCincin", "Upah Cincin");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F1_2");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("upahCincin", "Upah Cincin");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F3_1");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F3_2");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F3_3");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorJalur", "Tailor Jalur");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F3_4");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F5_1");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("kepingB", "Keping B");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("upahButang", "Upah Butang");
            label.Fields.Add("upahHook", "Upah Hook");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F5_2");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("upahButang", "Upah Butang");
            label.Fields.Add("upahHook", "Upah Hook");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);

            label = new OutputLabel("F7_1");
            label.Fields.Add("keping", "Keping");
            label.Fields.Add("kepingB", "Keping B");
            label.Fields.Add("upahKainA", "Upah Kain A");
            label.Fields.Add("upahButang", "Upah Butang");
            label.Fields.Add("upahHook", "Upah Hook");
            label.Fields.Add("hargaKainA", "Harga Kain A");
            label.Fields.Add("tailorKeping", "Tailor Keping");
            label.Fields.Add("tailorTinggi", "Tailor Tinggi");
            label.Fields.Add("tailorTotalKeping", "Tailor Total Keping");
            Formula.Add(label);
        }
    }
}
