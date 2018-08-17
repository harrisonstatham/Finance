using System;
using System.Threading;
using System.Threading.Tasks;

using System.IO;

using System.Net.Http;
using Newtonsoft.Json;

using HarrisonFinance.Common.Quandl.Interfaces;

namespace HarrisonFinance.Common.Quandl
{
    public class CQuandl
    {
        #region Private Members

        private string mApiKey = "";

        #endregion


        #region Public Members

        public string ApiKey => mApiKey;

        #endregion


        #region Constructors

        public CQuandl(string ApiKey)
        {
            mApiKey = ApiKey;
        }


        #endregion


        #region Public Methods

        /// <summary>
        /// Gets the time series.
        /// </summary>
        /// <returns>The time series.</returns>
        ///
        public CTimeSeries GetTimeSeries(CTimeSeriesRequest Request)
        {
            var Result = QueryTimeSeries(Request.GetURL());

            var Json = Result.Result;

            //Console.WriteLine(Json);

            CTimeSeriesFromJson Deserialized = null;

            if (Json != null)
            {
                // Remove some text to make it easier for the JSON parser.

                Json = Json.Replace("{\"dataset_data\":", "");

                Json = Json.Remove(Json.Length - 1);

                Deserialized = JsonConvert.DeserializeObject<CTimeSeriesFromJson>(Json);


            }

            if(Deserialized == null)
            {
                return new CTimeSeries(Request);
            }
            else
            {
                return SCTimeSeriesUtilities.ConvertToTimeSeries(Deserialized, Request);
            }
        }


        #if DEBUG
        public string BuildURL(IQuandlRequest Request)
        {
            string NewURL = Request.GetURL();

            if (NewURL.Contains("?") && NewURL.Contains("&"))
            {
                NewURL += "&api_key=" + mApiKey;
            }
            else
            {
                NewURL += "?api_key=" + mApiKey;
            }

            return NewURL;
        }
        #endif



        #endregion




        #region Private Methods


        /// <summary>
        /// Queries the time series.
        /// </summary>
        /// <returns>The time series.</returns>
        /// <param name="URL">URL.</param>
        private async Task<string> QueryTimeSeries(string URL)
        {
            // Append the API key.

            string NewURL = URL;

            if (URL.Contains("?") && URL.Contains("&"))
            {
                NewURL += "&api_key=" + mApiKey;
            }
            else
            {
                NewURL += "?api_key=" + mApiKey;
            }


            var client = new HttpClient();

            try
            {
                // Get the response.
                HttpResponseMessage response = await client.GetAsync(NewURL);

                // Get the response content.
                HttpContent responseContent = response.Content;

                var reader = new StreamReader(await responseContent.ReadAsStreamAsync());

                return await reader.ReadToEndAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);

            }

            return null;
        }



        #endregion

    }
}
