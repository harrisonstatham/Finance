// ===========================================================
//   CTimeSeriesMeta.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
using System.Collections.Generic;


namespace HarrisonFinance.Common.Quandl
{
    public class CTimeSeriesMeta
    {
        #region Public Members


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



        public CTimeSeriesMeta()
        {
        }
    }
}
