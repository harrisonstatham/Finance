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



namespace HarrisonFinance.Core
{
    public abstract class ACFinancialObject : IMeta, IPrice
    {

        //----------------------------------------------------------------------
        // Meta Information
        //
        // Meta information describes the current financial object in readable
        // form that might be used in conversation or documentation. 
        //

        #region IMeta Implementation

        #region Member(s)

        /// <summary>
        /// The name of the object.
        /// </summary>
        protected string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }



        /// <summary>
        /// The description of the object.
        /// </summary>
        protected string mDescription;

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        #endregion


        #endregion


        //----------------------------------------------------------------------
        // Price(s)
        //
        // Any price(s) related to the financial object is found here.
        //


        #region Price Implementation

        #region Members

        /// <summary>
        /// The current price of a financial object.
        /// </summary>
        protected IMoney mPrice;

        public double Price
        {
            get { return mPrice.Amount; }

            set
            {
                if (value >= 0.0)
                {
                    mPrice.Amount = value;
                }
                else
                {
                    mPrice.Amount = 0.0;
                }
            }
        }


        /// <summary>
        /// The purchase price of a financial object.
        /// </summary>
        protected IMoney mPurchasePrice;

        public double PurchasePrice
        {
            get { return mPurchasePrice.Amount; }

            set
            {
                if (value >= 0.0)
                {
                    mPurchasePrice.Amount = value;
                }
                else
                {
                    mPurchasePrice.Amount = 0.0;
                }
            }
        }



        /// <summary>
        /// The sale price of a financial object.
        /// </summary>
        protected IMoney mSalePrice;

        public double SalePrice
        {
            get { return mSalePrice.Amount; }

            set
            {
                if (value >= 0.0)
                {
                    mSalePrice.Amount = value;
                }
                else
                {
                    mSalePrice.Amount = 0.0;
                }
            }
        }



        /// <summary>
        /// An evolution of prices stored by date.
        /// </summary>
        protected IDictionary<DateTime, IMoney> mPriceHistory;

        public IDictionary<DateTime, IMoney> PriceHistory
        {
            get { return mPriceHistory; }

            set
            {
                mPriceHistory = value;
            }
        }

        #endregion

        #endregion



        //----------------------------------------------------------------------
        // Currency
        //
        // Anything related to the currency that represents the value of the 
        // financial object is found here.
        //

        #region Currency Information

        #region Members

        /// <summary>
        /// The currency used to represent the value of the financial object.
        /// </summary>
        protected CCurrency mCurrency;

        public CCurrency Currency
        {
            get { return mCurrency; }

            set 
            { 
                // Convert the price to a different currency.
                mPrice.Currency = value;

                mPrice.Amount.ConvertToDifferentCurrency(Currency, value);

                // Convert the purchase price
                mPurchasePrice.Currency = value;

                mPurchasePrice.Amount.ConvertToDifferentCurrency(Currency, value);

                // Convert the sale price
                mSalePrice.Currency = value;

                mSalePrice.Amount.ConvertToDifferentCurrency(Currency, value);


                // Convert the price history
                foreach (var KVP in mPriceHistory)
                {
                    mPriceHistory[KVP.Key].Amount = mPriceHistory[KVP.Key].Amount.ConvertToDifferentCurrency(Currency, value);
                }



                // Finally update the currency to the new value.
                mCurrency = value;
            }
        }

        #endregion

        #region Methods



        #endregion

        #endregion




        //----------------------------------------------------------------------
        // Appreciation and Depreciation
        //
        // Anything related to the appreciation or depreciation of a financial
        // object is found here.
        //

        #region Appreciation and Depreciation

        #region Members


        /// <summary>
        /// The depreciation rate of the financial object.
        /// </summary>
        protected double mDepreciationRate = 0.0;

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
        /// The appreciation rate of the financial object.
        /// </summary>
        protected double mAppreciationRate = 0.0;

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

        #endregion


        #region Methods

        void PopulatePriceHistoryUsingAppreciationDepreciation(TimeSpan TimeIncrement)
        {
            // Clear out any data that might exist.
            mPriceHistory.Clear();

            DateTime Current = PurchaseDate;
            CMoney TheValue;

            while(Current <= EndOfLifetime)
            {
                TheValue = new CMoney(Price, Currency);

                // Use the appreciation/depreciation equation to calculate the
                // current value of the asset at the given time.
                /// TODO Put formula for appreciation/depreciation here and update.

                mPriceHistory.Add(Current, TheValue);

                // Increment the current time by the time span given to us.
                Current += TimeIncrement;
            }
        }

        #endregion



        #endregion


        //----------------------------------------------------------------------
        // Dates
        //
        // Any date conveying important information is found here.
        //

        #region Dates

        #region Members

        /// <summary>
        /// The date of acquisition of a financial object.
        /// </summary>
        /// 
        protected DateTime mPurchaseDate;

        public DateTime PurchaseDate
        {
            get { return mPurchaseDate; }
            set { mPurchaseDate = value; }
        }


        /// <summary>
        /// The date of sale of a financial object.
        /// </summary>
        protected DateTime mSaleDate;

        public DateTime SaleDate
        {
            get { return mSaleDate; }
            set { mSaleDate = value; }
        }


        /// <summary>
        /// The end of the lifetime of the financial object.
        /// This is used in the 
        /// </summary>
        protected DateTime mEndOfLifetime;

        public DateTime EndOfLifetime
        {
            get { return mEndOfLifetime; }
            set { mEndOfLifetime = value; }
        }



        #endregion

        #endregion




        //----------------------------------------------------------------------
        // Cash Flows
        //
        // Any cash flows that are generated by the financial object
        // are found here.
        //

        #region Cash Flows

        #region Members

        /// <summary>
        /// The cash inflow an object creates.
        /// E.g. Interest collected from the purchase of a bond.
        /// </summary> 
        protected IDictionary<DateTime, double> mCashInflow;

        public IDictionary<DateTime, double> CashInflow
        {
            get { return mCashInflow; }
        }


        /// <summary>
        /// The cash outflow that an object creates.
        /// E.g. maintenance expenses for equipment.
        /// </summary>
        protected IDictionary<DateTime, double> mCashOutflow;

        public IDictionary<DateTime, double> CashOutflow
        {
            get { return mCashOutflow; }
        }


        /// <summary>
        /// The audit status of the financial object versus time.
        /// </summary>
        protected IDictionary<DateTime, bool> mAuditStatus;

        public IDictionary<DateTime, bool> AuditStatus
        {
            get { return mAuditStatus; }
        }

        #endregion

        #endregion





    }
}
