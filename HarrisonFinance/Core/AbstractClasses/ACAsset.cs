// ===========================================================
//   ACAsset.cs
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
    public abstract class ACAsset : ACFinancialObject
    {

        //----------------------------------------------------------------------
        //
        //

        #region Asset Type

        /// <summary>
        /// The type of the asset.
        /// </summary>
        protected eAssetType mAssetType;

        public eAssetType AssetType => mAssetType;

        #endregion



        //----------------------------------------------------------------------
        //
        //

        #region Balance Sheet

        /// <summary>
        /// The asset's balance sheet descriptor.
        /// </summary>
        protected eAssetBalanceSheetDescriptor mAssetBalanceSheetDescriptor;

        public eAssetBalanceSheetDescriptor AssetBalanceSheetDescriptor => mAssetBalanceSheetDescriptor;

        #endregion



        //----------------------------------------------------------------------
        //
        //

        #region Liquidity

        /// <summary>
        /// The liquidity of an asset.
        /// </summary>
        protected eLiquidity mLiquidity;

        public eLiquidity Liquidity => mLiquidity;

        #endregion


    }
}
