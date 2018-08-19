// ===========================================================
//   ICurrency.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
namespace HarrisonFinance.Core
{
    public interface ICurrency
    {

        /// <summary>
        /// The type of currency described by an enum.
        /// </summary>
        /// <value>The type.</value>
        eCurrency Type { get; set; }


        /// <summary>
        /// The conversion rate of the currency to US dollars.
        /// We normalize to USD for convenience when cross converting currency.
        /// </summary>
        /// <value>The conversion to USDR ate.</value>
        double ConversionToUSDRate { get; set; }

    }
}
