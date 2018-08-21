// ===========================================================
//   ILocation.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;

using GeoCoordinatePortable;

namespace HarrisonFinance
{
    public interface ILocation
    {

        /// <summary>
        /// A geo location.
        /// </summary>
        /// <value>The geo location.</value>
        GeoCoordinate GeoLocation { get; set; }


        /// <summary>
        /// The country that a location is in. If applicable.
        /// </summary>
        /// <value>The country.</value>
        eCountry? Country { get; set; }


        /// <summary>
        /// The state that the location is in. If applicable.
        /// </summary>
        /// <value>The state.</value>
        eState? State { get; set; }



        /// <summary>
        /// The county that the location is in. If applicable.
        /// </summary>
        /// <value>The county.</value>
        eCounty? County { get; set; }



        /// <summary>
        /// The providence that the location is in. If applicable.
        /// </summary>
        /// <value>The providence.</value>
        eProvidence? Providence { get; set; }



    }
}
