// ===========================================================
//   CBalanceSheet.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
using System.Collections.Generic;

using HarrisonFinance.Core.AbstractClasses;

namespace HarrisonFinance.Core.FinancialStatements
{
    public class CBalanceSheet
    {
        /// <summary>
        /// The group of assets.
        /// </summary>
        public IList<ACAsset> Assets;


        /// <summary>
        /// The group of liabilities.
        /// </summary>
        public IList<ACLiability> Liabilities;


        /// <summary>
        /// The group of owner equities.
        /// </summary>
        public IList<ACOwnerEquity> OwnerEquities;


        public CBalanceSheet()
        {
        }
    }
}
