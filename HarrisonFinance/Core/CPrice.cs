// ===========================================================
//   ACPrice.cs
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
    public class CPrice : IPrice
    {
        protected Money mPrice;

        public double Price 
        { 
            get => throw new NotImplementedException(); 

            set => throw new NotImplementedException(); 
        }

        protected Money mPurchasePrice;

        public double PurchasePrice 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        protected Money mSalePrice;

        public double SalePrice 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}
