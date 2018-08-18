using System;

using HarrisonFinance.Common.Quandl;
using HarrisonFinance.Common.Quandl.Enums;

using HarrisonFinance.Common.Utilities;

using HarrisonFinance.Core;


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

            /*
            // Build a new Quandl object.
            var Quandl = new CQuandl(ApiKey);

            // Setup a new request.
            var TimeSeriesRequest = new CTimeSeriesRequest("WIKI", "FB");

            // Add parameters to the request.
            TimeSeriesRequest.Collapse = eTimeSeriesCollapse.Monthly;
            TimeSeriesRequest.Limit = 10;

            // Go fetch the results from Quandl.
            var Results = Quandl.GetTimeSeries(TimeSeriesRequest);

            Console.WriteLine(Results);
            */

            var asset = new CAsset();



        }
    }
}
