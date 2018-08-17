// ===========================================================
//   SCTimeSeriesUtilities.cs
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
    internal static class SCTimeSeriesUtilities
    {
        internal static CTimeSeriesMeta ConvertToMeta(CTimeSeriesFromJson FromJson)
        {
            CTimeSeriesMeta Result = new CTimeSeriesMeta();

            Result.Name = FromJson.name;
            Result.Description = FromJson.description;
            Result.ColumnNames = FromJson.column_names;
            Result.Frequency = FromJson.frequency;
            Result.Type = FromJson.type;

            Result.RefreshedAt = FromJson.refreshed_at;
            Result.NewestAvailableDate = FromJson.newest_available_date;
            Result.OldestAvailableDate = FromJson.oldest_available_date;

            if (FromJson.premium != null)
            {
                Result.IsPremium = (FromJson.premium.Trim().ToLower() == "true");
            }

            return Result;
        }


        internal static CTimeSeries ConvertToTimeSeries(CTimeSeriesFromJson FromJson, CTimeSeriesRequest Request)
        {
            CTimeSeries Result = new CTimeSeries(Request);

            // Setup the meta data if any.
            Result.Meta = ConvertToMeta(FromJson);

            // Handle the data
            // We create a CTimeSeriesData object foreach list.
            foreach (var TheList in FromJson.data)
            {
                //SCListUtilities.Print<string>(TheList);

                Result.Data.Add(SCTimeSeriesUtilities.ParseFromStringList(TheList));
            }

            return Result;
        }


        /// <summary>
        /// Parses from string list.
        /// </summary>
        /// <returns>The from string list.</returns>
        /// <param name="SomeList">Some list.</param>
        internal static CTimeSeriesData ParseFromStringList(IList<string> SomeList)
        {
            CTimeSeriesData Data = new CTimeSeriesData();

            DateTime TempDate;
            double TempOpenPrice = 0.0;
            double TempLowPrice = 0.0;
            double TempHighPrice = 0.0;

            if (DateTime.TryParse(SomeList[0], out TempDate))
            {
                Data.Date = TempDate;
            }
            else
            {
                Data.Date = new DateTime();
            }

            if (double.TryParse(SomeList[1], out TempOpenPrice))
            {
                Data.Open = TempOpenPrice;
            }

            if (double.TryParse(SomeList[2], out TempHighPrice))
            {
                Data.High = TempHighPrice;
            }

            if (double.TryParse(SomeList[3], out TempLowPrice))
            {
                Data.Low = TempLowPrice;
            }

            return Data;
        }
    }
}
