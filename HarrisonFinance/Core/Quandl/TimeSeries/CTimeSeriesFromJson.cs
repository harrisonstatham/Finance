﻿using System;
using System.Collections.Generic;
using System.Collections;
using HarrisonFinance.Core.Quandl.Enums;

using HarrisonFinance.Common.Utilities;

namespace HarrisonFinance.Core.Quandl
{
    /// <summary>
    /// This class is responsible for parsing a JSON result from Quandl and
    /// putting it into a nice CTimeSeries object.
    /// </summary>
    internal class CTimeSeriesFromJson
    {

        #region Public Members

        public string database_code { get; set; }

        public string dataset_code { get; set; }

        public IList<IList<string>> data { get; set; }


        #region Request Members

        public string limit { get; set; }

        public string column_index { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public string order { get; set; }

        public string collapse { get; set; }

        public string transform { get; set; }

        #endregion

        #region Meta Members

        public string name { get; set; }

        public string description { get; set; }

        public DateTime refreshed_at { get; set; }

        public DateTime newest_available_date { get; set; }

        public DateTime oldest_available_date { get; set; }

        public IList<string> column_names { get; set; }

        public string frequency { get; set; }

        public string type { get; set; }

        public string premium { get; set; }

        #endregion

        #endregion



        #region Constructor(s)

        #endregion


        #region Private Methods



        #endregion



        #region Public Methods


        public CTimeSeriesMeta ConvertToMeta()
        {
            CTimeSeriesMeta Result = new CTimeSeriesMeta();

            Result.Name = name;
            Result.Description = description;
            Result.ColumnNames = column_names;
            Result.Frequency = frequency;
            Result.Type = type;

            Result.RefreshedAt = refreshed_at;
            Result.NewestAvailableDate = newest_available_date;
            Result.OldestAvailableDate = oldest_available_date;

            if (premium != null)
            {
                Result.IsPremium = (premium.Trim().ToLower() == "true");
            }

            return Result;
        }


        public CTimeSeries ConvertToTimeSeries(CTimeSeriesRequest Request)
        {
            CTimeSeries Result = new CTimeSeries(Request);

            // Handle the data
            // We create a CTimeSeriesData object foreach list.
            foreach (var TheList in data)
            {
                //SCListUtilities.Print<string>(TheList);

                Result.Data.Add(CTimeSeriesData.ParseFromStringList(TheList));
            }

            return Result;
        }



        #endregion


        #region Override Methods

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
