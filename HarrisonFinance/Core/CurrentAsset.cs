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


namespace HarrisonFinance.Core
{
    public class CurrentAsset : ACAsset
    {
        public CurrentAsset(double Amount, eCurrency CurrencyType)
        {
            mPrice.Amount = Amount;
            mCurrency = (CCurrency)CurrencyType;

            mLiquidity = eLiquidity.Instant;
            mAssetType = eAssetType.Current;
            mAssetBalanceSheetDescriptor = eAssetBalanceSheetDescriptor.CashAndEquivalents;
        }
    }
}
