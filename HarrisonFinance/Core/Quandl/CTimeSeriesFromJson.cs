using System;
namespace HarrisonFinance.Core.Quandl
{
    /// <summary>
    /// This class is responsible for parsing a JSON result from Quandl and
    /// putting it into a nice CTimeSeries object.
    /// </summary>
    internal class CTimeSeriesFromJson
    {

        public IList<IList<string>> data { get; set; }

        public string database_code { get; set; }

        public string dataset_code { get; set; }

        public string limit { get; set; }

        public string column_index { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public string collapse { get; set; }

        public string order { get; set; }

        public string transform { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public DateTime refreshed_at { get; set; }

        public DateTime newest_available_date { get; set; }

        public DateTime oldest_available_date { get; set; }

        public IList<string> column_names { get; set; }

        public string frequency { get; set; }

        public string type { get; set; }

        public string premium { get; set; }


        public CTimeSeries ConvertToTimeSeries()
        {
            CTimeSeries Result = new CTimeSeries();


            // The obvious ones
            Result.DatabaseCode = database_code;
            Result.DatasetCode = dataset_code;
            Result.Name = name;
            Result.Description = description;
            Result.ColumnNames = column_names;

            Result.Frequency = frequency;
            Result.Type = type;
            Result.IsPremium = (premium.Trim().ToLower() == "true");

            // Do I need to copy them???
            Result.StartDate = start_date;
            Result.EndDate = end_date;
            Result.RefreshedAt = refreshed_at;
            Result.NewestAvailableDate = newest_available_date;
            Result.OldestAvailableDate = oldest_available_date;



            // Handle the data
            // We create a CTimeSeriesData object foreach list.
            foreach (var TheList in data)
            {
                Result.Data.Add(CTimeSeriesData.ParseFromStringList(TheList));
            }


            int TheLimit = 0;
            Result.Limit = 0;

            if (int.TryParse(limit, out TheLimit))
            {
                Result.Limit = TheLimit;
            }


            int TheColIndex = 0;
            Result.ColumnIndex = 0;

            if (int.TryParse(column_index, out TheColIndex))
            {
                Result.ColumnIndex = TheColIndex;
            }

            Result.Collapse = eTimeSeriesExtMethods.ToTimeSeriesCollapse(collapse);
            Result.Order = eTimeSeriesExtMethods.ToTimeSeriesOrder(order);
            Result.Transform = eTimeSeriesExtMethods.ToTimeSeriesTransform(transform);


            return Result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
