// ===========================================================
//   CMutableTuple.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
namespace HarrisonFinance.Common
{
    public class CPair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public CPair(T TheFirst, T TheSecond)
        {
            First = TheFirst;
            Second = TheSecond;
        }
    }
}
