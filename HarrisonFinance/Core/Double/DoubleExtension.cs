// ===========================================================
//   DoubleExtension.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;

using HarrisonFinance;
using HarrisonFinance.Core.Enums;

namespace HarrisonFinance
{
    public static class DoubleExtension
    {
        public static double ConvertToDifferentCurrency(this double TheAmount, eCurrency FromCurrency, eCurrency ToCurrency)
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

            double ToUSDRate = FromCurrency.GetConversionToUSD();
            double FromUSDRate = ToCurrency.GetConversionToUSD();

            return (TheAmount * ToUSDRate) * FromUSDRate;                
        }
    }
}
