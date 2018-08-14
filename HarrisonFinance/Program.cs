using System;

using HarrisonFinance.Core.Quandl;
using HarrisonFinance.Core.Quandl.Enums;

namespace HarrisonFinance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var ApiKey = System.IO.File.ReadAllText(@"/Users/harrison/Projects/HarrisonFinance/HarrisonFinance/QuandlApiKey.txt").Trim();


            // Build a new Quandl object.
            var Quandl = new CQuandl(ApiKey);

            var TimeSeriesRequest = new CTimeSeriesRequest("WIKI", "FB");

            TimeSeriesRequest.Collapse = eTimeSeriesCollapse.Monthly;
            TimeSeriesRequest.Limit = 1;

            #if DEBUG
            Console.WriteLine(Quandl.BuildURL(TimeSeriesRequest));
            #endif


            // Go fetch the results from Quandl.
            var Results = Quandl.GetTimeSeries(TimeSeriesRequest);


            Console.WriteLine(Results);
        }
    }
}
