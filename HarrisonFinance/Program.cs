using System;

using HarrisonFinance.Core.Quandl;
using HarrisonFinance.Core.Quandl.Enums;

using HarrisonFinance.Common.Utilities;

namespace HarrisonFinance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Read the API key from a file. This prevents my personal API key
            // from being uploaded to Github.
            // Normally, I would just do this:
            // var ApiKey = "<My API Key Here>";
            var ApiKey = System.IO.File.ReadAllText(@"/Users/harrison/Projects/HarrisonFinance/HarrisonFinance/QuandlApiKey.txt").Trim();


            // Build a new Quandl object.
            var Quandl = new CQuandl(ApiKey);

            // Setup a new request.
            var TimeSeriesRequest = new CTimeSeriesRequest("WIKI", "FB");

            // Add parameters to the request.
            TimeSeriesRequest.Collapse = eTimeSeriesCollapse.Monthly;
            TimeSeriesRequest.Limit = 10;



            #if DEBUG
            Console.WriteLine(Quandl.BuildURL(TimeSeriesRequest));
            #endif


            // Go fetch the results from Quandl.
            var Results = Quandl.GetTimeSeries(TimeSeriesRequest);

            Console.WriteLine(Results);

        }
    }
}
