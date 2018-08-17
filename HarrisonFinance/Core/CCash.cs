// ===========================================================
//   CCash.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;

using HarrisonFinance.Core.Enums;
using HarrisonFinance.Core.AbstractClasses;


namespace HarrisonFinance.Core
{
    public class CCash : ACAsset
    {
        public CCash(double Amount, eCurrency CurrencyType)
        {
            mPrice = Amount;
            mCurrency = CurrencyType;

            mLiquidity = eLiquidity.Instant;
            mAssetType = eAssetType.CurrentAsset;
            mAssetDescriptor = eAssetDescriptor.CashAndEquivalents;
        }
    }
}
