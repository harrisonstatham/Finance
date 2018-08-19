// ===========================================================
//   Currency.cs
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
    public class CCurrency : ICurrency
    {

        #region ICurrecy implementation

        /// <summary>
        /// The type of currency.
        /// </summary>
        private eCurrency mType = eCurrency.USD;

        public eCurrency Type 
        {
            get { return mType; }
            set { mType = value; }
        }


        /// <summary>
        /// The conversion rate to USD. 
        /// </summary>
        private double mConversionToUSDRate = 1.0;

        public double ConversionToUSDRate 
        { 
            get { return mConversionToUSDRate; } 
            set { mConversionToUSDRate = value; }
        }

        #endregion


        #region Constructors

        public CCurrency(eCurrency TheType, double ConversionToUSD)
        {
            Type = TheType;
            ConversionToUSDRate = ConversionToUSD;
        }

        #endregion
    }
}
