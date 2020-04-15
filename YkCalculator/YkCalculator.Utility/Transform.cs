using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Utility
{
    public static class Transform
    {
        public static string ToJsonProperty(string propertyName)
        {
            if (propertyName != string.Empty && char.IsUpper(propertyName[0]))
            {
                propertyName = char.ToLower(propertyName[0]) + propertyName.Substring(1);
            }

            return propertyName;
        }
    }
}
