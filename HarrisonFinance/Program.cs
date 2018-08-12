using System;

using HarrisonFinance.Core.Quandl;

namespace HarrisonFinance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Quandl = CQuandl.GetInstance();

            var QB = new CQuandlQueryBuilder(Quandl.ApiKey);

            var Results = Quandl.GetTimeSeries(QB);

            Console.WriteLine(Results);
        }
    }
}
