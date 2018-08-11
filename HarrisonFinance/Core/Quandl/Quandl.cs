using System;

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
            if(Instance == null)
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


        #region Constructors

        private CQuandl(string ApiKey)
        {
            mApiKey = ApiKey;
        }


        #endregion


    }
}
