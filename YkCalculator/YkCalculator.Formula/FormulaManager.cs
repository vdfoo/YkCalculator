using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using YkCalculator.Model;

namespace YkCalculator.Logic
{
    public class FormulaManager
    {
        public Output Identify(Input input)
        {
            try
            { 
                Type type = Type.GetType("YkCalculator.Logic." + input.FormulaCode);
                ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
                object classObject = constructor.Invoke(new object[] { });
                MethodInfo method = type.GetMethod("Calculate");
                Output result = (Output)method.Invoke(classObject, new object[] { input });
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} {Environment.NewLine} Could not resolve {input.FormulaCode}");
            }
        }

        public RodSetOutput Identify(RodSetInput input)
        {
            try
            {
                Type type = Type.GetType("YkCalculator.Logic." + input.FormulaCode);
                ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
                object classObject = constructor.Invoke(new object[] { });
                MethodInfo method = type.GetMethod("Calculate");
                RodSetOutput result = (RodSetOutput)method.Invoke(classObject, new object[] { input });
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message} {Environment.NewLine} Could not resolve {input.FormulaCode}");
            }
        }
    }
}
