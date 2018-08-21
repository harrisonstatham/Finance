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
    // An empty object used for signaling that some currency needs to be updated.
    public class CCurrencyUpdate {}


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
        private static Dictionary<eCurrency, CCurrency> mInstances = new Dictionary <eCurrency, CCurrency>
        {
            {eCurrency.USD, new CCurrency(eCurrency.USD, 1.0)},
            {eCurrency.EUR, new CCurrency(eCurrency.EUR, 0.5)}
        };


        /// <summary>
        /// Get the instance of the currency that corresponds to the type of currency
        /// the user wishes.
        /// </summary>
        /// <returns>The currency.</returns>
        /// <param name="WhichCurrency">Which currency.</param>
        public static CCurrency GetCurrency(eCurrency WhichCurrency)
        {
            if(!mInstances.ContainsKey(WhichCurrency))
            {
                throw new Exception("Failed to retrieve currency.");
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
            this.Subscribe<CCurrencyUpdate>(NothingHere =>
            {
                // TODO Update the currency conversion to USD here.
                // This involves querying some database and finding out what the
                // current exchange rate is and updating the currency accordingly.
                Update();
            });
        }


        private CCurrency(eCurrency TheType) : this()
        {
            // Call update to get the conversion rate.    
            //Update();
        }


        private CCurrency(eCurrency TheType, double ConversionToUSD) : this()
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


        #region Operator Overloads

        #region Inequality & Equality Operators

        public static bool operator ==(CCurrency A, CCurrency B)
        {
            return A.Type == B.Type;
        }

        public static bool operator !=(CCurrency A, CCurrency B)
        {
            return A.Type != B.Type;
        }

        #endregion


        #region Cast Operator


        /// <summary>
        /// Easily convert a eCurrency into a CCurrency object.
        /// Just for convenience.
        /// </summary>
        /// <returns>The explicit.</returns>
        /// <param name="TheCurrency">The currency.</param>
        public static explicit operator CCurrency(eCurrency TheCurrency)
        {
            return CCurrency.GetCurrency(TheCurrency);
        }

        #endregion


        #region Misc Overloads

        public override string ToString()
        {
            return string.Format("{0} ({1})\n", Type.GetCurrencyCode(), Type.GetCurrencySymbol());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion
    }
}
