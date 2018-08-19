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
using System.Collections.Generic;

using PubSub;

namespace HarrisonFinance.Core
{
    public interface ICurrencyUpdate {}


    public class CCurrency : ICurrency
    {

        #region Singleton

        // By implementing the currencies as a dictionary of instances, we prevent
        // numerous instances of the same currency from being created.
        //
        // When we, eventually, use a pub/sub pattern to update all the
        // conversion rates of all the currencies, it will help to only have
        // one instance for each currency.


        /// <summary>
        /// A dictionary of instances for each type of currency in eCurrency.
        /// </summary>
        private static Dictionary<eCurrency, CCurrency> mInstances = null;

        /// <summary>
        /// Get the instance of the currency that corresponds to the type of currency
        /// the user wishes.
        /// </summary>
        /// <returns>The currency.</returns>
        /// <param name="WhichCurrency">Which currency.</param>
        public static CCurrency GetCurrency(eCurrency WhichCurrency)
        {
            bool NeedToAddCurrency = false;

            if (mInstances == null)
            {
                mInstances = new Dictionary<eCurrency, CCurrency>();
                NeedToAddCurrency = true;
            }
            else
            {
                // Is the currency already in the list of instances??
                // If not, then lets add it here.

                if (!mInstances.ContainsKey(WhichCurrency))
                {
                    NeedToAddCurrency = true;
                }
            }

            // Now we add the currency (all in one spot) to the list.
            if (NeedToAddCurrency)
            {
                mInstances[WhichCurrency] = new CCurrency(WhichCurrency);
            }

            return mInstances[WhichCurrency];
        }

        #endregion


        #region ICurrency implementation

        /// <summary>
        /// The type of currency.
        /// Assume USD by default.
        /// </summary>
        private eCurrency mType = eCurrency.USD;

        public eCurrency Type => mType;


        /// <summary>
        /// The conversion rate to USD. 
        /// </summary>
        private double mConversionToUSDRate = 1.0;

        public double ConversionToUSDRate => mConversionToUSDRate;

        #endregion


        #region Constructors

        private CCurrency()
        {
            this.Subscribe<ICurrencyUpdate>(NothingHere => {

                // TODO Update the currency conversion to USD here.
                // This involves querying some database and finding out what the
                // current exchange rate is and updating the currency accordingly.
                Update();
            });
        }


        private CCurrency(eCurrency TheType) : base()
        {
            // Call update to get the conversion rate.    
            Update();
        }


        private CCurrency(eCurrency TheType, double ConversionToUSD) : base()
        {
            mType = TheType;
            mConversionToUSDRate = ConversionToUSD;
        }

        #endregion


        #region Private Methods

        private void Update()
        {
            
        }


        #endregion
    }
}
