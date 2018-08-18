// ===========================================================
//   IPrice.cs
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
    public interface IPrice
    {
        double Price { get; set; }

        double PurchasePrice { get; set; }

        double SalePrice { get; set; }
    }
}
