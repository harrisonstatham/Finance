using System;
namespace HarrisonFinance.Core.Quandl.Enums
{
    public static class eTimeSeriesExtMethods
    {
        #region eTimeSeriesOrder Methods

        /// <summary>
        /// Tos the string.
        /// </summary>
        /// <returns>The string.</returns>
        /// <param name="Order">Order.</param>
        public static String ToString(this eTimeSeriesOrder Order)
        {
            string TheStr = "";

            switch (Order)
            {
                case eTimeSeriesOrder.Asc:
                    TheStr = "ASC";
                    break;

                case eTimeSeriesOrder.Desc:
                    TheStr = "DESC";
                    break;

            }

            return TheStr;
        }



        /// <summary>
        /// Tos the time series order.
        /// </summary>
        /// <returns>The time series order.</returns>
        /// <param name="TheStr">The string.</param>
        public static eTimeSeriesOrder ToTimeSeriesOrder(this string TheStr)
        {
            eTimeSeriesOrder Order;

            if (TheStr == null)
            {
                Order = eTimeSeriesOrder.Desc;
            }
            else
            {
                switch (TheStr.Trim().ToLower())
                {
                    case "asc":
                        Order = eTimeSeriesOrder.Asc;
                        break;


                    case "desc":
                    default:
                        Order = eTimeSeriesOrder.Desc;
                        break;

                }
            }

            return Order;
        }

        #endregion

        #region eTimeSeriesCollapse Methods

        /// <summary>
        /// Tos the string.
        /// </summary>
        /// <returns>The string.</returns>
        /// <param name="Collapse">Collapse.</param>
        public static string ToString(this eTimeSeriesCollapse Collapse)
        {
            string TheStr = "";

            switch (Collapse)
            {
                case eTimeSeriesCollapse.Annual:
                    TheStr = "Annual";
                    break;


                case eTimeSeriesCollapse.Daily:
                default:
                    TheStr = "Daily";
                    break;

                case eTimeSeriesCollapse.Monthly:
                    TheStr = "Monthly";
                    break;

                case eTimeSeriesCollapse.None:
                    TheStr = "None";
                    break;

                case eTimeSeriesCollapse.Quarterly:
                    TheStr = "Quarterly";
                    break;

                case eTimeSeriesCollapse.Weekly:
                    TheStr = "Weekly";
                    break;

            }

            return TheStr;
        }



        public static eTimeSeriesCollapse ToTimeSeriesCollapse(this string TheStr)
        {
            eTimeSeriesCollapse Collapse;

            if (TheStr == null)
            {
                Collapse = eTimeSeriesCollapse.None;
            }
            else
            {
                switch (TheStr.Trim().ToLower())
                {
                    case "annual":
                        Collapse = eTimeSeriesCollapse.Annual;
                        break;

                    case "daily":
                    default:
                        Collapse = eTimeSeriesCollapse.Daily;
                        break;

                    case "monthly":
                        Collapse = eTimeSeriesCollapse.Monthly;
                        break;

                    case "none":
                        Collapse = eTimeSeriesCollapse.None;
                        break;

                    case "quarterly":
                        Collapse = eTimeSeriesCollapse.Quarterly;
                        break;

                    case "weekly":
                        Collapse = eTimeSeriesCollapse.Weekly;
                        break;

                }
            }

            return Collapse;
        }


        #endregion

        #region eTimeSeriesTransform Methods

        public static string ToString(this eTimeSeriesTransform Transform)
        {
            string TheStr = "";

            switch (Transform)
            {
                case eTimeSeriesTransform.Cumulative:
                    TheStr = "Annual";
                    break;


                case eTimeSeriesTransform.Differential:
                default:
                    TheStr = "Daily";
                    break;

                case eTimeSeriesTransform.None:
                    TheStr = "Monthly";
                    break;

                case eTimeSeriesTransform.Normalize:
                    TheStr = "None";
                    break;

                case eTimeSeriesTransform.RDifferential:
                    TheStr = "Quarterly";
                    break;

                case eTimeSeriesTransform.RDiffFrom:
                    TheStr = "Weekly";
                    break;

            }

            return TheStr;
        }


        public static eTimeSeriesTransform ToTimeSeriesTransform(this string TheStr)
        {
            eTimeSeriesTransform Transform;

            if (TheStr == null)
            {
                Transform = eTimeSeriesTransform.None;
            }
            else
            {
                
                switch (TheStr.Trim().ToLower())
                {
                    case "annual":
                        Transform = eTimeSeriesTransform.Cumulative;
                        break;

                    case "daily":
                    default:
                        Transform = eTimeSeriesTransform.Differential;
                        break;

                    case "monthly":
                        Transform = eTimeSeriesTransform.None;
                        break;

                    case "none":
                        Transform = eTimeSeriesTransform.Normalize;
                        break;

                    case "quarterly":
                        Transform = eTimeSeriesTransform.RDifferential;
                        break;

                    case "weekly":
                        Transform = eTimeSeriesTransform.RDiffFrom;
                        break;

                }

            }
            return Transform;
        }



        #endregion

    }
}
