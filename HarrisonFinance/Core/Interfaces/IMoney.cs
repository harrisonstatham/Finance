// ===========================================================
//   IPrice.cs
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
    public interface IMoney
    {
        /// <summary>
        /// The price of a financial object is its current value.
        /// </summary>
        /// <value>The price.</value>
        double Amount { get; set; }


        /// <summary>
        /// Gets or sets the currency used to represent the value.
        /// </summary>
        /// <value>The currency.</value>
        CCurrency Currency { get; set; }


        /// <summary>
        /// Converts to another currency.
        /// </summary>
        /// <param name="TheNewCurrency">The new currency.</param>
        void ConvertToAnotherCurrency(CCurrency TheNewCurrency);
    }
}
