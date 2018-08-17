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

namespace HarrisonFinance.Core.Enums
{
    public enum eAssetType
    {
        CurrentAsset,

        LongTermAsset
    }


    public enum eAssetDescriptor
    {

        // ref: https://www.investopedia.com/terms/c/cashandcashequivalents.asp

        [AssetDescriptor(Name = "Cash and Cash Equivalents", Description = "Assets that are cash or can be converted into cash immediately.")]
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


    public static class AssetDescriptorExtension
    {
        public static string GetName(this eAssetDescriptor TheDescriptor)
        {
            return TheDescriptor.GetAttribute<AssetDescriptor>().Name;
        }

        public static string GetDescription(this eAssetDescriptor TheDescriptor)
        {
            return TheDescriptor.GetAttribute<AssetDescriptor>().Description;
        }

    }

    public class AssetDescriptor : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }



}
