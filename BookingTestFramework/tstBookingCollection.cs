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
            TestItem.BookingDate = DateTime.Now.Date;
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
            TestBooking.BookingDate = DateTime.Now.Date;
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
            TestItem.BookingDate = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllBookings.BookingList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddBookingMethodOK()
        {
            // create an instance of the booking collection class
            clsBookingCollection Bookings = new clsBookingCollection();
            // create item of test data
            clsBooking TestItem = new clsBooking();
            // var to store primary key
            Int32 PrimaryKey = 0;
            // set the properties
            TestItem.BookingID = 3;
            TestItem.TotalPrice = 200;
            TestItem.BookingApproved = false;
            TestItem.DestinationID = 2;
            TestItem.BookingDate = DateTime.Now.Date;
            // set ThisBooking to the test data
            Bookings.ThisBooking = TestItem;
            // add the record
            PrimaryKey = Bookings.Add();
            // set the primary key 
            TestItem.BookingID = PrimaryKey;
            // find the record
            Bookings.ThisBooking.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(Bookings.ThisBooking, TestItem);
        }

        [TestMethod]
        public void UpdateBookingMethodOK()
        {
            // create an instance of the booking collection class
            clsBookingCollection Bookings = new clsBookingCollection();
            // create item of test data
            clsBooking TestItem = new clsBooking();
            // var to store primary key
            Int32 PrimaryKey = 0;
            // set the properties
            TestItem.TotalPrice = 1000;
            TestItem.BookingApproved = false;
            TestItem.DestinationID = 6;
            TestItem.BookingDate = DateTime.Now.Date;
            // set ThisBooking to the test data
            Bookings.ThisBooking = TestItem;
            // add the record
            PrimaryKey = Bookings.Add();
            // set the primary key of the test data
            TestItem.BookingID = PrimaryKey;
            // modify the test data
            TestItem.TotalPrice = 1500;
            TestItem.BookingApproved = true;
            TestItem.DestinationID = 12;
            TestItem.BookingDate = DateTime.Now.Date.AddDays(1);
            // set the record based on the new test data
            Bookings.ThisBooking = TestItem;
            // update the record
            Bookings.Update();
            // find the record
            Bookings.ThisBooking.Find(PrimaryKey);
            // test to see ThisBooking matches the test data
            Assert.AreEqual(Bookings.ThisBooking, TestItem);
        }
    }
}