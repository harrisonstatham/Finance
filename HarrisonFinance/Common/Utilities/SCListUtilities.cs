using System;
using System.Collections.Generic;

namespace HarrisonFinance.Common.Utilities
{
    public static class SCListUtilities
    {
        public static void Print<T>(IList<T> TheList)
        {
            Console.WriteLine("List => [");

            for (int i = 0; i < TheList.Count; i++)
            {
                Console.WriteLine("\t{0} => {1},", i, TheList[i]);    
            }

            Console.WriteLine("]");
        }

    }
}
