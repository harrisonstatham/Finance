// ===========================================================
//   CNumberWithUnit.cs
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
    public class UnitIncorrectException : Exception {}

    public class CNumberWithUnit
    {
        public double Value
        {
            get; set;
        }

        public eUnit Unit
        {
            get; set;
        }

        public CNumberWithUnit(double TheValue, eUnit TheUnit)
        {
            Value = Value;
            Unit = TheUnit;
        }


        #region Public Static Methods

        private static void CheckUnitEqualityAndThrowException(eUnit UnitA, eUnit UnitB)
        {
            if (UnitA != UnitB)
            {
                throw new UnitIncorrectException();
            }
        }

        #endregion


        #region Mathematical Operator Overload

        #region Addition

        public static CNumberWithUnit operator +(CNumberWithUnit A, CNumberWithUnit B)
        {
            CheckUnitEqualityAndThrowException(A.Unit, B.Unit);

            return new CNumberWithUnit(A.Value + B.Value, A.Unit);
        }

        public static CNumberWithUnit operator +(CNumberWithUnit A, double B)
        {
            return A + (CNumberWithUnit)B;
        }

        public static CNumberWithUnit operator +(double A, CNumberWithUnit B)
        {
            return B + (CNumberWithUnit)A;
        }


        #endregion

        #region Subtraction

        public static CNumberWithUnit operator -(CNumberWithUnit A, CNumberWithUnit B)
        {
            CheckUnitEqualityAndThrowException(A.Unit, B.Unit);

            return new CNumberWithUnit(A.Value - B.Value, A.Unit);
        }


        public static CNumberWithUnit operator -(CNumberWithUnit A, double B)
        {
            return A - (CNumberWithUnit)B;
        }

        public static CNumberWithUnit operator -(double A, CNumberWithUnit B)
        {
            return (CNumberWithUnit)A - B;
        }

        #endregion


        #region Multiplication



        #endregion




        #endregion


        #region Cast Operators

        public static explicit operator CNumberWithUnit(double A)
        {
            return new CNumberWithUnit(A, eUnit.None);
        }

        #endregion
    }
}
