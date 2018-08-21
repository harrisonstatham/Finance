// ===========================================================
//   ACInstitution.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;
using GeoCoordinatePortable;

namespace HarrisonFinance.Core
{
    public class ACInstitution : IMeta, ILocation
    {
        
        #region IMeta Implementation

        public string Name { get; set; }

        public string Description { get; set; }

        #endregion


        #region ILocation Implementation

        private GeoCoordinate mGeoLocation;

        public GeoCoordinate GeoLocation 
        { 
            get { return mGeoLocation; } 
        }

        public eCountry? Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public eState? State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public eCounty? County { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public eProvidence? Providence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        #endregion







        public ACInstitution()
        {
        }
    }
}
