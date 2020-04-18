﻿using System;
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

        public static double TailorKeping(int keping, string layout)
        {
            double tailorKeping = keping;
            if (!string.IsNullOrEmpty(layout))
            { 
                if(layout.Equals("T") || layout.Equals("L"))
                { 
                    if(layout.Equals("T"))
                    { 
                        tailorKeping = keping / 2.0;
                    }
                }
                else
                {
                    throw new Exception("Layout input should be T or L");
                }
            }
            else
            {
                throw new Exception("Layout input should not be empty or null");
            }

            return Math.Round(tailorKeping, 1);
        }
    }
}
