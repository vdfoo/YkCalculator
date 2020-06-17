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

            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Keping)), "Keping");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.KepingA)), "Keping A");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.KepingB)), "Keping B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.KepingC)), "Keping C");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.KepingG)), "Keping G");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.KepingK)), "Keping K");

            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaCincin)), "Harga Cincin");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaCincinB)), "Harga Cincin B");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaCincinC)), "Harga Cincin C");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaCincinG)), "Harga Cincin G");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaCincinK)), "Harga Cincin K");

            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaHook)), "Harga Hook");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaButang)), "Harga Butang");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaRenda)), "Harga Renda");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.HargaTali)), "Harga Tali");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.TariScalletQuantity)), "Tali Scallet Kuantiti");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.TaliLangsirQuantity)), "Tali Langsir Kuantiti");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.RendaQuantity)), "Renda Kuantity");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.RainbowQuantity)), "Rainbow Kuantiti");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.RibbonQuantity)), "Ribbon Kuantiti");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.ButangChoice)), "Pilihan Butang");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.MeterDiscountAmount)), "Meter Discount Amount");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Lipat)), "Lipat");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Separate)), "Menjahit Bersama");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Hanger)), "Hanger");

            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Location.Sliding)), "Sliding");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Location.Tempat)), "Tempat");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Location.Tingkap)), "Tingkat");
            label.Fields.Add(Transform.ToJsonProperty(nameof(Input.Location.TingkatBawah)), "Tingkat Bawah");
            
            Formula.Add(label);
        }
        
            

    }
}

