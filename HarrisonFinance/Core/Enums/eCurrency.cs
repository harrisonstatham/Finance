// ===========================================================
//   eCurrency.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//

using System;
using System.Reflection;
using HarrisonFinance;

namespace HarrisonFinance.Core.Enums
{
    
    public enum eCurrency
    {
        [CurrencyDescriptor(Code = "USD", Description = "Merica")]
        USD,

        [CurrencyDescriptor(Code = "EUR", Description = "Not Merica")]
        EUR
    }


    public static class eCurrencyExtensions
    {
        public static string GetCode(this eCurrency TheCurrency)
        {
            return TheCurrency.GetAttribute<CurrencyDescriptor>().Code;
        }

        public static string GetDescription(this eCurrency TheCurrency)
        {
            return TheCurrency.GetAttribute<CurrencyDescriptor>().Description;
        }
    }


    public class CurrencyDescriptor : Attribute
    {
        /// <summary>
        /// Gets or sets the string code used to abbreviate the currency.
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; set; }


        /// <summary>
        /// Gets or sets the description of the currency.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }


        /// <summary>
        /// Gets or sets the conversion to usd.
        /// </summary>
        /// <value>The conversion to usd.</value>
        public double ConversionToUSD { get; set; }
    }
}
