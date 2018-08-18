// ===========================================================
//   CurrentAsset.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;

using HarrisonFinance.Core.AbstractClasses;

using HarrisonFinance.Core.Enums;


namespace HarrisonFinance.Core
{
    public class CurrentAsset : ACAsset
    {
        public CurrentAsset(double Amount, eCurrency CurrencyType)
        {
            mPrice = Amount;
            mCurrency = CurrencyType;

            mLiquidity = eLiquidity.Instant;
            mAssetType = eAssetType.Current;
            mAssetBalanceSheetDescriptor = eAssetBalanceSheetDescriptor.CashAndEquivalents;
        }
    }
}
