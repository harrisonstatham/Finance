using System;
using System.Threading;
using System.Threading.Tasks;

using System.IO;

using System.Net.Http;
using Newtonsoft.Json;

namespace HarrisonFinance.Core.Quandl
{
    public class CQuandl
    {
        #region Singleton

        /// <summary>
        /// The instance.
        /// </summary>
        private static CQuandl Instance = null;


        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>The instance.</returns>
        public static CQuandl GetInstance()
        {
            if (Instance == null)
            {
                // Here we pull the ApiKey from a file. This prevents Github from
                // seeing my ApiKey. Ideally, this would just be hardcoded in.
                var ApiKey = System.IO.File.ReadAllText(@"/Users/harrison/Projects/HarrisonFinance/HarrisonFinance/QuandlApiKey.txt");

                Instance = new CQuandl(ApiKey.Trim());
            }

            return Instance;
        }

        #endregion

        #region Private Members

        private string mApiKey = "";

        #endregion


        #region Public Members

        public string ApiKey => mApiKey;

        #endregion


        #region Constructors

        private CQuandl(string ApiKey)
        {
            mApiKey = ApiKey;
        }


        #endregion


        #region Public Methods

        /// <summary>
        /// Gets the time series.
        /// </summary>
        /// <returns>The time series.</returns>
        /// <param name="QueryBuilder">Query builder.</param>
        public CTimeSeries GetTimeSeries(CQuandlQueryBuilder QueryBuilder)
        {
            var Result = QueryTimeSeries(QueryBuilder);

            var Json = Result.Result;

            CTimeSeriesFromJson Deserialized = null;

            if(Json != null)
            {
                // Remove some text to make it easier for the JSON parser.

                Json = Json.Replace("{\"dataset_data\":", "");

                Json = Json.Remove(Json.Length - 1);

                Deserialized = JsonConvert.DeserializeObject<CTimeSeriesFromJson>(Json);
            }

            return (Deserialized == null) ? new CTimeSeries() : Deserialized.ConvertToTimeSeries();
        }


        #endregion


        #region Private Methods


        /// <summary>
        /// Queries the time series.
        /// </summary>
        /// <returns>The time series.</returns>
        /// <param name="QueryBuilder">Query builder.</param>
        private async Task<string> QueryTimeSeries(CQuandlQueryBuilder QueryBuilder)
        {
            var client = new HttpClient();

            try 
            {
                // Get the response.
                HttpResponseMessage response = await client.GetAsync(QueryBuilder.GetURL());

                // Get the response content.
                HttpContent responseContent = response.Content;

                var reader = new StreamReader(await responseContent.ReadAsStreamAsync());

                return await reader.ReadToEndAsync();
            } 
            catch(HttpRequestException e)
            {
                Console.WriteLine(e.Message);

            }

            return null;
        }

        #endregion

    }
}
