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

using HarrisonFinance.Core.Enums;

namespace HarrisonFinance.Core.AbstractClasses
{
    public abstract class ACAsset : ACFinancialObject
    {
        #region Protected Members

        /// <summary>
        /// The type of the m asset.
        /// </summary>
        protected eAssetType mAssetType;


        /// <summary>
        /// The m asset descriptor.
        /// </summary>
        protected eAssetDescriptor mAssetDescriptor;


        /// <summary>
        /// The liquidity of an asset.
        /// </summary>
        protected eLiquidity mLiquidity;

        #endregion


        #region Public Members

        public eAssetType AssetType => mAssetType;

        public eAssetDescriptor AssetDescriptor => mAssetDescriptor;

        public eLiquidity Liquidity => mLiquidity;

        #endregion
    }
}
