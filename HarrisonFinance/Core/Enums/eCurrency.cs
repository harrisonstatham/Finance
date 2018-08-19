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

namespace HarrisonFinance.Core
{

    public enum eCurrency
    {
        [CurrencyDescriptor(Code = "USD", Symbol = "$", Description = "United States Dollars")]
        USD,

        [CurrencyDescriptor(Code = "EUR", Symbol = "€", Description = "European Union Euro")]
        EUR
    }

    #region eCurrency Enum Decorators

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
        /// The symbol used to represent the currency.
        /// </summary>
        /// <value>The symbol.</value>
        public string Symbol { get; set; }

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
    }

    #endregion
}
