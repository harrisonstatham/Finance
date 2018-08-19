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
using System.Collections.Generic;

namespace HarrisonFinance.Core
{
    public interface IPrice
    {

        /// <summary>
        /// The current price of the financial object.
        /// </summary>
        /// <value>The price.</value>
        double Price { get; set; }


        /// <summary>
        /// The initial purchase price of the financial object.
        /// </summary>
        /// <value>The purchase price.</value>
        double PurchasePrice { get; set; }


        /// <summary>
        /// The final sale price of the financial object.
        /// </summary>
        /// <value>The sale price.</value>
        double SalePrice { get; set; }


        /// <summary>
        /// The history of the price of the financial object.
        /// </summary>
        /// <value>The price history.</value>
        IDictionary<DateTime, IMoney> PriceHistory { get; set; }
    }
}
