// ===========================================================
//   Money.cs
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
    public class CMoney : IMoney
    {

        #region IMoney Interface Implementation


        /// <summary>
        /// The m amount.
        /// </summary>
        protected double mAmount = 0.0;

        public double Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }


        /// <summary>
        /// The m currency.
        /// </summary>
        private CCurrency mCurrency;

        public CCurrency Currency 
        {
            get;
            set;
        }


        /// <summary>
        /// Converts to another currency.
        /// </summary>
        /// <param name="TheNewCurrency">The new currency.</param>
        public void ConvertToAnotherCurrency(CCurrency TheNewCurrency)
        {
            // Get the latest currency rates.
            /// TODO Implement the code that gets the current currency rate.

            // Convert the USD to the new currency.
            Amount *= Currency.ConversionToUSDRate * TheNewCurrency.ConversionToUSDRate;
            Currency = TheNewCurrency;

        }


        #endregion



        #region Constructor(s)

        public CMoney(double TheAmount, CCurrency TheCurrency)
        {
            Amount = TheAmount;
            Currency = TheCurrency;
        }


        #endregion

    }
}
