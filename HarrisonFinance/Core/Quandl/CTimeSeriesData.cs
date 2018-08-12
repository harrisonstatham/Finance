using System;
namespace HarrisonFinance.Core.Quandl
{
    //--------------------------------------------------------------------------
    //
    //--------------------------------------------------------------------------

    public class CTimeSeriesData
    {

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }


        /// <summary>
        /// Gets or sets the low.
        /// </summary>
        /// <value>The low.</value>
        public double Low { get; set; }


        /// <summary>
        /// Gets or sets the high.
        /// </summary>
        /// <value>The high.</value>
        public double High { get; set; }


        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public double End { get; set; }


        /// <summary>
        /// Parses from string list.
        /// </summary>
        /// <returns>The from string list.</returns>
        /// <param name="SomeList">Some list.</param>
        public static CTimeSeriesData ParseFromStringList(IList<string> SomeList)
        {
            CTimeSeriesData Data = new CTimeSeriesData();

            DateTime TempDate;
            double TempHighPrice = 0.0;
            double TempLowPrice = 0.0;
            double TempEndPrice = 0.0;

            if (DateTime.TryParse(SomeList[0], out TempDate))
            {
                Data.Date = TempDate;
            }
            else
            {
                Data.Date = new DateTime();
            }

            if (double.TryParse(SomeList[1], out TempLowPrice))
            {
                Data.Low = TempLowPrice;
            }

            if (double.TryParse(SomeList[2], out TempEndPrice))
            {
                Data.End = TempEndPrice;
            }

            if (double.TryParse(SomeList[3], out TempHighPrice))
            {
                Data.High = TempHighPrice;
            }

            return Data;
        }
    }
}
