using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObfuscationSample
{
    [System.Reflection.ObfuscationAttribute(ApplyToMembers = true, Exclude = true)]
    public class MathematicalGenius
    {
        // Original code for the chapter walkthrough
        //public static Int32 GenerateMagicNumber(Int32 age, Int32 height)
        //{
        //    return SecretGenerateMagicNumber(age, height);
        //}

        //private static Int32 SecretGenerateMagicNumber(Int32 age, Int32 height)
        //{
        //    return (age * height) + DateTime.Now.DayOfYear;
        //}

        public static Int32 GenerateMagicNumber(Int32 age, Int32 height)
        {
            return HiddenGenius.GenerateMagicNumber(age, height);
        }

        public static Boolean EvaluatePerson(Int32 age, Int32 height)
        {
            return HiddenGenius.EvaluatePerson(age, height);
        }
    }

    [System.Reflection.ObfuscationAttribute(ApplyToMembers = false, Exclude = true)]
    public class HiddenGenius
    {
        public static Int32 GenerateMagicNumber(Int32 age, Int32 height)
        {
            return (age * height) + DateTime.Now.DayOfYear;
        }

        [System.Reflection.ObfuscationAttribute(Exclude = true)]
        public static Boolean EvaluatePerson(Int32 age, Int32 height)
        {
            return GenerateMagicNumber(age, height) > 6000;
        }
    }
}
