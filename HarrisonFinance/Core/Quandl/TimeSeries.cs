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
        /// Gets or sets the database code.
        /// </summary>
        /// <value>The database code.</value>
        public string DatabaseCode { get; set; }


        /// <summary>
        /// Gets or sets the dataset code.
        /// </summary>
        /// <value>The dataset code.</value>
        public string DatasetCode { get; set; }


        /// <summary>
        /// The number of rows of the dataset.
        /// </summary>
        /// <value>The limit.</value>
        public int Limit { get; set; }


        /// <summary>
        /// Gets or sets the index of the column.
        /// </summary>
        /// <value>The index of the column.</value>
        public int ColumnIndex { get; set; }


        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; set; }


        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime EndDate { get; set; }


        /// <summary>
        /// Gets or sets the collapse.
        /// </summary>
        /// <value>The collapse.</value>
        public eTimeSeriesCollapse Collapse { get; set; }


        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>The order.</value>
        public eTimeSeriesOrder Order { get; set; }


        /// <summary>
        /// Gets or sets the transform.
        /// </summary>
        /// <value>The transform.</value>
        public eTimeSeriesTransform Transform { get; set; }


        //----------------------------------------------------------------------
        // Meta data
        //----------------------------------------------------------------------


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }


        /// <summary>
        /// Gets or sets the refreshed at.
        /// </summary>
        /// <value>The refreshed at.</value>
        public DateTime RefreshedAt { get; set; }


        /// <summary>
        /// Gets or sets the newest available date.
        /// </summary>
        /// <value>The newest available date.</value>
        public DateTime NewestAvailableDate { get; set; }


        /// <summary>
        /// Gets or sets the oldest available date.
        /// </summary>
        /// <value>The oldest available date.</value>
        public DateTime OldestAvailableDate { get; set; }


        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>The column names.</value>
        public IList<string> ColumnNames { get; set; }


        /// <summary>
        /// Gets or sets the frequency.
        /// </summary>
        /// <value>The frequency.</value>
        public string Frequency { get; set; }


        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:HarrisonFinance.Core.Quandl.CTimeSeries"/> is premium.
        /// </summary>
        /// <value><c>true</c> if is premium; otherwise, <c>false</c>.</value>
        public bool IsPremium { get; set; }

        #endregion

        #region Constructors

        public CTimeSeries()
        {
        }



        #endregion


    }
}
