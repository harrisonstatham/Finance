// ===========================================================
//   CTimeSeriesQuery.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
// ref: https://docs.quandl.com/docs/parameters-2
//

using System;

using HarrisonFinance.Common.Quandl.Enums;
using HarrisonFinance.Common.Quandl.Interfaces;

namespace HarrisonFinance.Common.Quandl
{
    public class CTimeSeriesRequest : IQuandlRequest
    {

        #region Private Constant Members

        private const string TIME_SERIES_URL = "https://www.quandl.com/api/v3/datasets/{0}/{1}/data.json{2}";

        #endregion


        #region Public Members

        public string DatabaseCode { get; set; }

        public string DatasetCode { get; set; }

        public int? Limit { get; set; }

        public int? ColumnIndex { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public eTimeSeriesOrder Order { get; set; }

        public eTimeSeriesCollapse Collapse { get; set; }

        public eTimeSeriesTransform Transform { get; set; }

        #endregion



        #region Constructor(s)

        public CTimeSeriesRequest(string TheDatabaseCode, string TheDatasetCode)
        {
            // Assign default parameters
            DatabaseCode = TheDatabaseCode;
            DatasetCode = TheDatasetCode;

            Order = eTimeSeriesOrder.Desc;
            Collapse = eTimeSeriesCollapse.None;
            Transform = eTimeSeriesTransform.None;
        }

        public CTimeSeriesRequest(string TheDatabaseCode,
                                  string TheDatasetCode,
                                  int? TheLimit,
                                  int? TheColumnIndex,
                                  DateTime? TheStartDate,
                                  DateTime? TheEndDate,
                                  eTimeSeriesOrder TheOrder, 
                                  eTimeSeriesCollapse TheCollapse, 
                                  eTimeSeriesTransform TheTransform)
        {
            // Assign default parameters
            DatabaseCode = TheDatabaseCode;
            DatasetCode = TheDatasetCode;

            Limit = TheLimit;
            ColumnIndex = TheColumnIndex;
            StartDate = TheStartDate;
            EndDate = TheEndDate;

            Order = TheOrder;
            Collapse = TheCollapse;
            Transform = TheTransform;
        }

        public CTimeSeriesRequest(CTimeSeriesRequest Copy) 
            : this(Copy.DatabaseCode, 
                   Copy.DatasetCode, 
                   Copy.Limit, 
                   Copy.ColumnIndex, 
                   Copy.StartDate, 
                   Copy.EndDate, 
                   Copy.Order,
                   Copy.Collapse,
                   Copy.Transform)
        {
            
        }


        #endregion


        #region Private Methods

        private string GetOptionalParameters()
        {
            bool HasOneOptionalParam = false;

            string OptionalParams = "";

            if (Limit != null)
            {
                OptionalParams += "limit=" + Limit.ToString();

                HasOneOptionalParam = true;
            }

            if (ColumnIndex != null)
            {
                OptionalParams += ((HasOneOptionalParam) ? "&" : "") + "column_index=" + ColumnIndex.ToString();

                HasOneOptionalParam = true;
            }

            if (StartDate != null)
            {
                OptionalParams += ((HasOneOptionalParam) ? "&" : "") + "start_date=" + StartDate.ToString();

                HasOneOptionalParam = true;
            }

            if (EndDate != null)
            {
                OptionalParams += ((HasOneOptionalParam) ? "&" : "") + "end_date=" + EndDate.ToString();

                HasOneOptionalParam = true;
            }

            if (Order == eTimeSeriesOrder.Asc)
            {
                OptionalParams += ((HasOneOptionalParam) ? "&" : "") + "order=" + Order.ToString();

                HasOneOptionalParam = true;
            }

            if (Collapse != eTimeSeriesCollapse.None)
            {
                OptionalParams += ((HasOneOptionalParam) ? "&" : "") + "collapse=" + Collapse.ToString();

                HasOneOptionalParam = true;
            }

            if (Transform != eTimeSeriesTransform.None)
            {
                OptionalParams += ((HasOneOptionalParam) ? "&" : "") + "transform=" + Transform.ToString();

                HasOneOptionalParam = true;
            }


            return (HasOneOptionalParam) ? ("?" + OptionalParams) : "";
        }

        #endregion



        #region Public Methods

        public string GetURL()
        {
            return string.Format(TIME_SERIES_URL, DatabaseCode, DatasetCode, GetOptionalParameters());
        }

        #endregion
    }
}
