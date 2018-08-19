using System;

using HarrisonFinance.Common.Quandl;
using HarrisonFinance.Common.Quandl.Enums;

using HarrisonFinance.Common.Utilities;

using HarrisonFinance.Core;

using PubSub;

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

            var M1 = new CMoney(100.0, eCurrency.USD);
            var C1 = CCurrency.GetCurrency(eCurrency.USD);


            Console.WriteLine("These two lines should be the same.");
            Console.WriteLine(M1.Currency.ConversionToUSDRate);
            Console.WriteLine(C1.ConversionToUSDRate);


            var Temp = "String";
            Temp.Publish(new CCurrencyUpdate());


            Console.WriteLine("The lines below should be the same BUT different from above.");
            Console.WriteLine(M1.Currency.ConversionToUSDRate);
            Console.WriteLine(C1.ConversionToUSDRate);


        }
    }
}
