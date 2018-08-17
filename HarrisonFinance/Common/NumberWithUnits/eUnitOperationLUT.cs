// ===========================================================
//   eUnitOperationLUT.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//

using System;
using System.Collections.Generic;
using System.Collections.Specialized;


namespace HarrisonFinance.Common.NumberWithUnits
{

    public enum eUnitOperator
    {
        Division,
        Multiplication
    }

    public static class eUnitOperationLUT
    {
        private static readonly eUnit[,] MultiplicationLUT = new eUnit[,]
        {
            // None,        Other,          Money,         $,              euro, 
            {eUnit.None,    eUnit.Other,    eUnit.Money,   eUnit.USD,      eUnit.EUR,   },          // None
            {eUnit.Other,   eUnit.Other,    eUnit.Other,   eUnit.Other,    eUnit.Other  },          // Other
            {eUnit.Money,   eUnit.Other,    eUnit.Money,   eUnit.USD,      eUnit.EUR    },          // Money
            {eUnit.USD,     eUnit.Other,    eUnit.USD,     eUnit.USD,      eUnit.Other  },          // $
            {eUnit.EUR,     eUnit.Other,    eUnit.EUR,     eUnit.Other,    eUnit.EUR    },          // euro
        };

        private static readonly eUnit[,] DivisionLUT = new eUnit[,]
        {
            // None,        Other,          Money,         $,              euro, 
            {eUnit.None,    eUnit.Other,    eUnit.Money,   eUnit.USD,      eUnit.EUR,   },          // None
            {eUnit.Other,   eUnit.Other,    eUnit.Other,   eUnit.Other,    eUnit.Other  },          // Other
            {eUnit.Money,   eUnit.Other,    eUnit.Money,   eUnit.USD,      eUnit.EUR    },          // Money
            {eUnit.USD,     eUnit.Other,    eUnit.USD,     eUnit.USD,      eUnit.Other  },          // $
            {eUnit.EUR,     eUnit.Other,    eUnit.EUR,     eUnit.Other,    eUnit.EUR    },          // euro
        };

        public static eUnit Get(eUnitOperator TheOperation, eUnit A, eUnit B)
        {
            if(TheOperation == eUnitOperator.Division)
            {
                return DivisionLUT[(int)A, (int)B];
            }
            else
            {
                return MultiplicationLUT[(int)A, (int)B];
            }
        }
    }
}
