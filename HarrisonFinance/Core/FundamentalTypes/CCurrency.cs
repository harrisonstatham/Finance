// ===========================================================
//   Currency.cs
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
    public class CCurrency
    {

        private eCurrency mType = eCurrency.USD;

        public eCurrency Type { get; set; }


        private double mConversionToUSDRate = 1.0;

        public double ConversionToUSDRate { get; set; }
    }
}
