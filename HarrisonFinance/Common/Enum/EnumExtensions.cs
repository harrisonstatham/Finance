// ===========================================================
//   EnumExtensions.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//

using System;
using System.Reflection;

namespace HarrisonFinance
{
    public static class EnumExtensions
    {

        // Ref: https://codereview.stackexchange.com/questions/5352/getting-the-value-of-a-custom-attribute-from-an-enum

        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);

            return type.GetField(name).GetCustomAttribute<TAttribute>();
        }

        public static string GetName(this Enum value)
        {
            return value.GetAttribute<EnumMeta>().Name;
        }

        public static string GetDescription(this Enum value)
        {
            return value.GetAttribute<EnumMeta>().Description;
        }
    }

    public class EnumMeta : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
