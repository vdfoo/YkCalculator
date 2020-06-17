using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class CustomerSummaryLabelCollection
    {
        public List<OutputLabel> Formula { get; set; }
        public Dictionary<string, string> InputGeneral { get; set; }
        public Dictionary<string, string> OutputGeneral { get; set; }

        public CustomerSummaryLabelCollection()
        {
            InputGeneral = new Dictionary<string, string>();
            InputGeneral.Add(Transform.ToJsonProperty(nameof(Input.Set)), "Set");
            InputGeneral.Add(Transform.ToJsonProperty(nameof(Input.RainbowQuantity)), "Rainbow Quantity");
            InputGeneral.Add(Transform.ToJsonProperty(nameof(Input.RendaQuantity)), "Renda Quantity");
            InputGeneral.Add(Transform.ToJsonProperty(nameof(Input.RibbonQuantity)), "Ribbon Quantity");
            InputGeneral.Add(Transform.ToJsonProperty(nameof(Input.TaliLangsirQuantity)), "Tali Langsir Kuantiti");
            InputGeneral.Add(Transform.ToJsonProperty(nameof(Input.TariScalletQuantity)), "Tali Scallet Kuantiti");

            OutputGeneral = new Dictionary<string, string>();
            OutputGeneral.Add(Transform.ToJsonProperty(nameof(Output.Jumlah)), "Jumlah");

            //Formula = new List<OutputLabel>();

            //OutputLabel labelF47_1 = new OutputLabel("F47_1");
            //labelF47_1.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahKainA)), null);

            //Formula.Add(labelF47_1);
        }
    }
}
