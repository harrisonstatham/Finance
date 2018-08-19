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
        public CCash(double Amount, CCurrency CurrencyType)
        {
            Price = Amount;
            Currency = CurrencyType;

            mLiquidity = eLiquidity.Instant;
            mAssetType = eAssetType.Current;
            mAssetBalanceSheetDescriptor = eAssetBalanceSheetDescriptor.CashAndEquivalents;
        }
    }
}
