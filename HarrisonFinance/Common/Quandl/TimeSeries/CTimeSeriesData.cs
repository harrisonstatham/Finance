using System;
using System.Collections.Generic;

namespace HarrisonFinance.Common.Quandl
{
    //--------------------------------------------------------------------------
    //
    //--------------------------------------------------------------------------

    public class CTimeSeriesData
    {
        #region Public Members

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

        #endregion


        #region Override Methods

        public override string ToString()
        {
            return "Date: \t\t Open: \t\t Close: \t\t High: \t\t Low: \t\t Volume: \n" + 
                string.Format("{0} \t\t {1} \t\t {2} \t\t {3} \t\t {4} \t\t {5} \n", Date, Open, Close, High, Low, Volume);
        }

        #endregion

    }
}
