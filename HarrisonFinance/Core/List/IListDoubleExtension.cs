// ===========================================================
//   IListDoubleExtension.cs
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
    public static class ListExtension
    {
        public static IList<double> ConvertToDifferentCurrency(this IList<double> TheList, eCurrency FromCurrency, eCurrency ToCurrency)
        {
            // Example 
            // TheAmount = 10.0
            // FromCurrency = EUR
            // ToCurrency = RUP
            // 
            // 1 EUR = 2 USD
            // 1 USD = 10 RUP
            //
            // ToUSDRate = 2
            // FromUSDRate = 10
            //
            // 10.0 EUR | 1 USD / 0.5 EUR | 1 RUP / 0.1 USD = 200 RUP
            // 

            for (int i = 0; i < TheList.Count; i++)
            {
                TheList[i] = TheList[i].ConvertToDifferentCurrency(FromCurrency, ToCurrency);
            }

            return TheList;
        }
    }
}
