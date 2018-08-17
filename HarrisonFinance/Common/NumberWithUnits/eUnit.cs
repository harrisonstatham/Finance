// ===========================================================
//   eUnit.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
namespace HarrisonFinance.Common.NumberWithUnits
{
    public enum eUnit
    {
        // Just some scalar number.
        [UnitDescriptor(Symbol = "None", Name = "None", Description = "No unit.")]
        None,

        // Wierd unit.
        Other,

        [UnitDescriptor(Symbol = "Money", Name = "Money", Description = "Some arbitrary currency.")]
        // Money units
        Money,

        [UnitDescriptor(Symbol = "$", Name = "Dollars", Description = "Money is in Dollars")]
        USD,

        [UnitDescriptor(Symbol = "€", Name = "Euros", Description = "Money is in Euros")]
        EUR,
        RUP,


        // SI Units
        // ...

        // etc
    }


    public class UnitDescriptor : Attribute
    {
        public string Symbol;
        public string Name;
        public string Description;
    }



}
