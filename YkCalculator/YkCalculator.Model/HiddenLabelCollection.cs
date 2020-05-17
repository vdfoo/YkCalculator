using System;
using System.Collections.Generic;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.Model
{
    public class HiddenLabelCollection
    {
        public List<OutputLabel> Formula { get; set; }

        public HiddenLabelCollection()
        {
            Formula = new List<OutputLabel>();

            OutputLabel labelF47_1 = new OutputLabel("F47_1");
            labelF47_1.Fields.Add(Transform.ToJsonProperty(nameof(Output.UpahKainA)), null);

            Formula.Add(labelF47_1);
        }
    }
}
