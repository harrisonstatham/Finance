// ===========================================================
//   CTriplet.cs
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
    public class CTriplet<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
        public T Third { get; set; }

        public CTriplet(T TheFirst, T TheSecond, T TheThird)
        {
            First = TheFirst;
            Second = TheSecond;
            Third = TheThird;
        }
    }
}
