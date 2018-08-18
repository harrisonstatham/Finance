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
    public class Money : IMoney
    {

        #region IMoney Interface Implementation

        protected double mAmount = 0.0;

        public double Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }


        private CCurrency mCurrency;

        public CCurrency Currency 
        {
            get;
            set;
        }



        #endregion

        #region Constructor(s)

        public Money(double TheAmount, CCurrency TheCurrency)
        {
            Amount = TheAmount;
            Currency = TheCurrency;
        }


        #endregion

    }
}
