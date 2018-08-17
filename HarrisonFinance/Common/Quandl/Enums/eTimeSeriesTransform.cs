using System;
namespace HarrisonFinance.Common.Quandl.Enums
{
    public enum eTimeSeriesTransform
    {
        None,
        Differential,
        RDifferential,
        RDiffFrom,
        Cumulative,
        Normalize
    };
}
