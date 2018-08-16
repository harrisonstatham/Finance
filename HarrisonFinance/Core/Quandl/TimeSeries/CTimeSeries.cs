using System;
using System.Collections.Generic;

using HarrisonFinance.Core.Quandl.Enums;

namespace HarrisonFinance.Core.Quandl
{

    //--------------------------------------------------------------------------
    //
    //--------------------------------------------------------------------------

    public class CTimeSeries
    {
        #region Public Members


        /// <summary>
        /// The data.
        /// </summary>
        public List<CTimeSeriesData> Data { get; set; }


        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        public CTimeSeriesRequest Request { get; set; }


        /// <summary>
        /// Gets or sets the meta.
        /// </summary>
        /// <value>The meta.</value>
        public CTimeSeriesMeta Meta { get; set; }

        #endregion

        #region Constructors

        public CTimeSeries()
        {
            Data = new List<CTimeSeriesData>();
        }

        public CTimeSeries(CTimeSeriesRequest TheRequest)
        {
            Data = new List<CTimeSeriesData>();
            Request = TheRequest;
        }




        #endregion

        #region Override Methods

        public override string ToString()
        {
            var TheStr = "Date: \t\t Open: \t\t Close: \t\t High: \t\t Low: \t\t Volume: \n";


            foreach (var Item in Data)
            {
                TheStr += string.Format("{0} \t\t {1} \t\t {2} \t\t {3} \t\t {4} \t\t {5} \n", Item.Date, Item.Open, Item.Close, Item.High, Item.Low, Item.Volume);
            }

            return TheStr;
        }

        #endregion
    }
}
