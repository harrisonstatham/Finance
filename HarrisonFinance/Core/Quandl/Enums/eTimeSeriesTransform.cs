using System;
namespace HarrisonFinance.Core.Quandl.Enums
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
