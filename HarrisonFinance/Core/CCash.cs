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


namespace HarrisonFinance.Core
{
    public class CCash : ACAsset
    {
        public CCash(double Amount, eCurrency CurrencyType)
        {
            Price = Amount;
            Currency = CurrencyType;

            mLiquidity = eLiquidity.Instant;
            mAssetType = eAssetType.Current;
            mAssetBalanceSheetDescriptor = eAssetBalanceSheetDescriptor.CashAndEquivalents;
        }
    }
}
