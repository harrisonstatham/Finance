// ===========================================================
//   EnumTests.cs
//
//   Harrison Statham
//   Copyright Harrison Statham 2018
//
//
//
//
using NUnit.Framework;
using System;

namespace HarrisonFinance.UnitTests.Common.Enum
{

    enum eTestEnum
    {
        [EnumMeta(Name = "Test 1", Description = "The description of test 1.")]
        Test1, 

        [EnumMeta(Name = "Test 2", Description = "The description of test 2.")]
        Test2
    }


    //[TestFixture()]
    public class EnumTests
    {
        [Test()]
        public void TestMetaName()
        {

            string TheName = eTestEnum.Test1.GetName();

            Assert.AreEqual(TheName, "Test 1");
        }
    }
}
