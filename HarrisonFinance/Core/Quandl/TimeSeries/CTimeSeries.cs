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


    }
}
