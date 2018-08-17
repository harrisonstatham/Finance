// ===========================================================
//   CCRUD.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using System;

using LiteDB;

namespace HarrisonFinance.Common.Database
{
    public class CCRUD
    {
        #region Singleton

        private static CCRUD mInstance = null;

        public static CCRUD Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new CCRUD();
                }

                return mInstance;
            }
        }

        #endregion

        #region Private Members

        private LiteDatabase mDB = null;

        private bool mIsConnected = false;

        #endregion


        #region Public Members

        public bool IsConnected => mIsConnected;

        public LiteDatabase DB => mDB;

        #endregion


        #region Constructor(s)

        protected CCRUD()
        {
            
        }

        #endregion



        #region Public Methods

        public void Connect(string DatabaseFileName)
        {

            try 
            {
                mDB = new LiteDatabase(DatabaseFileName);

                mIsConnected = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

                mIsConnected = false;
            }
        }





        #endregion






    }
}
