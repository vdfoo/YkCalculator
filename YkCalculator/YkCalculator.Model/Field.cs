using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Model
{
    public class Field
    {
        public string PropertyName { get; set; }
        public string DisplayName { get; set; }
        public bool Required { get; set; }
        public string PropertyType { get; set; }
        public int MaxValue { get; set; }
        public string ValidationError { get; set; }
    }
}
