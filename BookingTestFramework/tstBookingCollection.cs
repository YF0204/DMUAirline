using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace BookingTestFramework
{
    /// <summary>
    /// Summary description for tstBookingCollection
    /// </summary>
    [TestClass]
    public class tstBookingCollection
    {
        public tstBookingCollection()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the BookingCollection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            // test to see that it exists
            Assert.IsNotNull(AllBookings);
        }

        [TestMethod]
        public void BookingListOK()
        {
            // create an instance of the BookingCollection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            // create a list of test data
            List<clsBooking> TestList = new List<clsBooking>();
            // create the item of test data
            clsBooking TestItem = new clsBooking();
            // set the properties
            TestItem.BookingID = 1;
            TestItem.TotalPrice = 198;
            TestItem.BookingApproved = false;
            TestItem.DestinationID = 1;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllBookings.BookingList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllBookings.BookingList, TestList);
        }

        [TestMethod]
        public void ThisBookingPropertyOK()
        {
            // create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            // create some test data to assign to the property
            clsBooking TestBooking = new clsBooking();
            // set the properties to the test object
            TestBooking.BookingID = 1;
            TestBooking.TotalPrice = 198;
            TestBooking.BookingApproved = false;
            TestBooking.DestinationID = 1;
            // assign the data to the property
            AllBookings.ThisBooking = TestBooking;
            // test to see that the two values are the same
            Assert.AreEqual(AllBookings.ThisBooking, TestBooking);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            // create test data to assign to the property
            List<clsBooking> TestList = new List<clsBooking>();
            // create the item of test data
            clsBooking TestItem = new clsBooking();
            // set its properties
            TestItem.BookingID = 1;
            TestItem.TotalPrice = 198;
            TestItem.BookingApproved = false;
            TestItem.DestinationID = 1;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllBookings.BookingList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }
    }
}