using System;
using System.Collections.Generic;
using System.Text;

namespace YkCalculator.Utility
{
    public static class Transform
    {
        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

        public static string GenerateTailorBaseImage(string fileName)
        {
            return Constant.TailorImageHostBase + fileName;
        }

        public static string GenerateSystemBaseImage(string fileName)
        {
            return Constant.SystemImageHostBase + fileName;
        }

        public static string ToJsonProperty(string propertyName)
        {
            if (propertyName != string.Empty && char.IsUpper(propertyName[0]))
            {
                propertyName = char.ToLower(propertyName[0]) + propertyName.Substring(1);
            }

            return propertyName;
        }

        public static double TailorKeping(int keping, string layout, int set)
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

            return Math.Round(tailorKeping / set, 1);
        }


        public static bool WithRing(string description)
        {
            bool withRing = false;
            if(description.Contains("with ring"))
            {
                withRing = true;
            }

            return withRing;
        }
    }
}
