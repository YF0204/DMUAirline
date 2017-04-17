using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace BookingTestFramework
{
    /// <summary>
    /// Summary description for tstBooking
    /// </summary>
    [TestClass]
    public class tstBooking
    {
        public tstBooking()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            // create instance of the booking class
            clsBooking ABooking = new clsBooking();
            // test to see that it exists
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void BookingIDPropertyOK()
        {
            // create instance of the booking class
            clsBooking ABooking = new clsBooking();
            // create test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            ABooking.BookingID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(ABooking.BookingID, TestData);
        }

        [TestMethod]
        public void BookingApprovedPropertyOK()
        {
            // create instance of the booking class
            clsBooking ABooking = new clsBooking();
            // create test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            ABooking.BookingApproved = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(ABooking.BookingApproved, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            // create instance of the booking class
            clsBooking ABooking = new clsBooking();
            // create test data to assign to the property
            decimal TestData = 200.50m;
            // assign the data to the property
            ABooking.TotalPrice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(ABooking.TotalPrice, TestData);
        }

        [TestMethod]
        public void BookingDatePropertyOK()
        {
            // create instance of the booking class
            clsBooking ABooking = new clsBooking();
            // create test data to assign to the property
            DateTime TestData;
            TestData = DateTime.Now.Date;
            // assign the data to the property
            ABooking.BookingDate = TestData;
            // test to see that two values are the same
            Assert.AreEqual(ABooking.BookingDate, TestData);
        }

        [TestMethod]
        public void FindBookingMethodOK()
        {
            // create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            // boolean variable to store validation result
            Boolean Found = false;
            // create test data to use with method
            Int32 BookingID = 1;
            // execute the method
            Found = ABooking.Find(BookingID);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }
    }
}
