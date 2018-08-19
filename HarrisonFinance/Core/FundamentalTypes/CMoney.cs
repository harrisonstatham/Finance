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

using PubSub;


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

        public CCurrency Currency => mCurrency;


        /// <summary>
        /// Converts to another currency.
        /// </summary>
        /// <param name="TheNewCurrency">The new currency.</param>
        public void ConvertToCurrency(eCurrency TheNewCurrency)
        {
            // Get the latest currency rates.
            this.Publish<CCurrencyUpdate>();

            // Cache the current conversion rate.
            double CurrentConversionRate = Currency.ConversionToUSDRate;

            // Get the instance of the currency.
            mCurrency = CCurrency.GetCurrency(TheNewCurrency);

            // Convert the USD to the new currency.
            Amount *= CurrentConversionRate * Currency.ConversionToUSDRate;
        }


        #endregion



        #region Constructor(s)

        public CMoney(double TheAmount, eCurrency TheCurrency)
        {
            mAmount = TheAmount;
            mCurrency = CCurrency.GetCurrency(TheCurrency);
        }


        #endregion

        #region Operator Overloads



        // We can add and subtract money easily.

        #region Addition

        public static CMoney operator +(CMoney A, CMoney B)
        {
            // We need an apples-to-apples comparison.
            // The currencies must be of the same to be able to add them.
            //
            // If given two different currencies, return USD no matter what.

            if(A.Currency != B.Currency)
            {
                A.ConvertToAnotherCurrency(eCurrency.USD);
                B.ConvertToAnotherCurrency(eCurrency.USD);
            }

            // Now that the monies are in the same currencies, we can
            // successfully add both of them.

            return new CMoney(A.Amount + B.Amount, A.Currency.Type);
        }



        #endregion


        #endregion

    }
}
