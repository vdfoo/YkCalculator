using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class InputLabelCollection
    {
        public List<OutputLabel> Formula { get; set; }

        public InputLabelCollection()
        {
            Formula = new List<OutputLabel>();
            OutputLabel label = new OutputLabel(string.Empty);
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Set)), "Set");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Layout)), "Layout");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Lebar)), "Lebar");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Tinggi)), "Tinggi A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.TinggiB)), "Tinggi B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaKainA)), "Harga Kain A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaKainB)), "Harga Kain B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaKainC)), "Harga Kain C");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaKainG)), "Harga Kain G");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaKainK)), "Harga Kain K");

            Formula.Add(label);
        }
        
            

    }
}
