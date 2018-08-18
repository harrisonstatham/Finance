// ===========================================================
//   eAssetType.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
using System.Reflection;

using HarrisonFinance;

namespace HarrisonFinance.Core
{

    // ref: https://www.investopedia.com/terms/a/asset.asp
    // ref: https://corporatefinanceinstitute.com/resources/knowledge/accounting/types-of-assets/

    public enum eAssetType
    {
        [AssetMeta(Name = "Current Asset", Description = "A current asset is one that is expected to be converted to cash within one year.")]
        Current,

        [AssetMeta(Name = "Fixed Asset", Description = "A fixed assets are long-term assets such as buildings, equipment, etc.")]
        Fixed,

        [AssetMeta(Name = "Tangible Asset", Description = "An tangible asset is one that has a physical manifestation and holds value.")]
        Tangible,

        [AssetMeta(Name = "Intangible Asset", Description = "An intangible asset is one that has no physical manifestation but represents something valuable.")]
        Intangible,

        [AssetMeta(Name = "Operating Asset", Description = "An operating asset is one that is required for day-day operation of a business.")]
        Operating,

        [AssetMeta(Name = "Non-Operating Asset", Description = "A non-operating asset is one that is not required for daily use but can still generate revenue.")]
        NonOperating
    }





    public enum eAssetBalanceSheetDescriptor
    {

        // ref: https://www.investopedia.com/terms/c/cashandcashequivalents.asp

        [AssetMeta(Name = "Cash and Cash Equivalents", Description = "Assets that are cash or can be converted into cash immediately.")]
        CashAndEquivalents,


        AccountsReceivable,

        Inventory,

        Other,

        PropertyPlantEquipment,

        Goodwill,

        OtherIntangible,

        Investments,

        TaxDeferred

    }


    public enum eAssetRiskCategory
    {
        ZeroRisk,
        LowRisk,
        MidRisk,
        HighRisk,


        // ref: https://www.investopedia.com/terms/d/dangerous-asset.asp

        [AssetMeta(Name = "Dangerous", Description = "A dangerous asset is a piece of property or investment which poses a risk of liabilty to the owner.")]
        Dangerous,

        Troubled,

        Toxic,


    }


    #region Asset Meta

    public static class AssetDescriptorExtension
    {
        public static string GetAssetName<T>(this T TheEnum) where T : Enum
        {
            return TheEnum.GetAttribute<AssetMeta>().Name;
        }

        public static string GetAssetDescription<T>(this T TheEnum) where T : Enum
        {
            return TheEnum.GetAttribute<AssetMeta>().Description;
        }

    }

    public class AssetMeta : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    #endregion
}
