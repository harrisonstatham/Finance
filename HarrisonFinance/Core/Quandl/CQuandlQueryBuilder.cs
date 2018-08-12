using System;
namespace HarrisonFinance.Core.Quandl
{
    public class CQuandlQueryBuilder
    {
        private string mApiKey;

        public string ApiKey => mApiKey;

        public CQuandlQueryBuilder(string TheApiKey)
        {
            mApiKey = TheApiKey;
        }

        public string GetURL()
        {
            return string.Format("https://www.quandl.com/api/v3/datasets/WIKI/FB/data.json?api_key={0}", ApiKey);
        }
    }
}
