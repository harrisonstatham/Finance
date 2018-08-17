// ===========================================================
//   ACFinancialObject.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
using System.Collections.Generic;

using HarrisonFinance.Core.Enums;

using MathNet.Numerics;

namespace HarrisonFinance.Core.AbstractClasses
{
    public abstract class ACFinancialObject
    {

        #region Protected Members

        /// <summary>
        /// The name of the object.
        /// </summary>
        protected string mName;


        /// <summary>
        /// The description of the object.
        /// </summary>
        protected string mDescription;


        /// <summary>
        /// The price of a financial object.
        /// </summary>
        protected double mPrice;


        /// <summary>
        /// An evolution of prices stored by date.
        /// </summary>
        protected IDictionary<DateTime, double> mPriceHistory;


        /// <summary>
        /// The currency.
        /// </summary>
        protected eCurrency mCurrency;


        /// <summary>
        /// The date of acquisition/sale.
        /// </summary>
        protected DateTime mDate;


        /// <summary>
        /// The depreciation rate of the asset.
        /// </summary>
        protected double mDepreciationRate = 0.0;


        /// <summary>
        /// The appreciation rate of the asset.
        /// </summary>
        protected double mAppreciationRate = 0.0;

        #endregion


        #region Public Members

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                if (value >= 0.0)
                {
                    mPrice = value;
                }
            }
        }


        /// <summary>
        /// Gets the price history.
        /// </summary>
        /// <value>The price history.</value>
        public IDictionary<DateTime, double> PriceHistory => mPriceHistory;


        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public eCurrency Currency
        {
            get
            {
                return mCurrency;
            }

            set
            {
                mCurrency = value;
            }
        }


        /// <summary>
        /// Gets or sets the depreciation rate.
        /// </summary>
        /// <value>The depreciation rate.</value>
        public double DepreciationRate
        {
            get
            {
                return mDepreciationRate;
            }

            set
            {
                // If the value is >= 0.0 then we have a depreciating asset.
                if (value >= 0.0)
                {

                    // If we have an appreciation rate in place, then we need to subtract
                    // the depreciation to find out how much the value is changing.
                    var Temp = mAppreciationRate - value;

                    // If the appreciation rate is greater than 
                    if (Temp >= 0.0)
                    {
                        mAppreciationRate = Temp;
                        mDepreciationRate = 0.0;
                    }
                    else
                    {
                        mDepreciationRate = -1.0 * Temp;
                        mAppreciationRate = 0.0;
                    }
                }
                else
                {
                    // A negatively increasing depreciation is an appreciation.
                    mAppreciationRate = -1.0 * value;
                    mDepreciationRate = 0.0;
                }
            }
        }


        /// <summary>
        /// Gets or sets the appreciation rate.
        /// </summary>
        /// <value>The appreciation rate.</value>
        public double AppreciationRate
        {
            get
            {
                return mAppreciationRate;
            }

            set
            {
                // If the value is >= 0.0 then we have an appreciating asset.
                if (value >= 0.0)
                {

                    // If we have an appreciation rate in place, then we need to subtract
                    // the depreciation to find out how much the value is changing.
                    var Temp = value - mDepreciationRate;

                    // If the appreciation rate is greater than 
                    if (Temp >= 0.0)
                    {
                        mAppreciationRate = Temp;
                        mDepreciationRate = 0.0;
                    }
                    else
                    {
                        mDepreciationRate = -1.0 * Temp;
                        mAppreciationRate = 0.0;
                    }
                }
                else
                {
                    // A negatively increasing appreciating is a depreciation.
                    mDepreciationRate = -1.0 * value;
                    mAppreciationRate = 0.0;
                }
            }
        }


        /// <summary>
        /// Gets or sets the date. 
        /// This is the date of acquiring/selling the financial object.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date
        {
            get
            {
                return mDate;
            }

            set
            {
                mDate = value;
            }
        }


        #endregion


        #region Public Methods

        public void ConvertToCurrency(eCurrency ConvertTo)
        {
            mPrice = mPrice.ConvertToDifferentCurrency(mCurrency, ConvertTo);
            mCurrency = ConvertTo;
        }

        #endregion

    }
}
