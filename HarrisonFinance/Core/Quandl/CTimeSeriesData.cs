using System;
using System.Collections.Generic;

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
        public double Open { get; set; }


        /// <summary>
        /// Gets or sets the high.
        /// </summary>
        /// <value>The high.</value>
        public double High { get; set; }


        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public double Low { get; set; }


        /// <summary>
        /// Gets or sets the close.
        /// </summary>
        /// <value>The close.</value>
        public double Close { get; set; }


        /// <summary>
        /// Gets or sets the volume.
        /// </summary>
        /// <value>The volume.</value>
        public double Volume { get; set; }


        /// <summary>
        /// Gets or sets the ex dividend.
        /// </summary>
        /// <value>The ex dividend.</value>
        public double ExDividend { get; set; }


        /// <summary>
        /// Gets or sets the split ration.
        /// </summary>
        /// <value>The split ration.</value>
        public double SplitRation { get; set; }


        /// <summary>
        /// Gets or sets the adj open.
        /// </summary>
        /// <value>The adj open.</value>
        public double AdjOpen { get; set; }


        /// <summary>
        /// Gets or sets the adj high.
        /// </summary>
        /// <value>The adj high.</value>
        public double AdjHigh { get; set; }


        /// <summary>
        /// Gets or sets the adj low.
        /// </summary>
        /// <value>The adj low.</value>
        public double AdjLow { get; set; }


        /// <summary>
        /// Gets or sets the adj close.
        /// </summary>
        /// <value>The adj close.</value>
        public double AdjClose { get; set; }


        /// <summary>
        /// Gets or sets the adj volume.
        /// </summary>
        /// <value>The adj volume.</value>
        public double AdjVolume { get; set; }




        /// <summary>
        /// Parses from string list.
        /// </summary>
        /// <returns>The from string list.</returns>
        /// <param name="SomeList">Some list.</param>
        public static CTimeSeriesData ParseFromStringList(IList<string> SomeList)
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
