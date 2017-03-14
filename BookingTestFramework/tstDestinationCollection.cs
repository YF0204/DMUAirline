using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace BookingTestFramework
{
    [TestClass]
    public class tstDestinationCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsDestinationCollection Destinations = new clsDestinationCollection();
            // test to see that it exists
            Assert.IsNotNull(Destinations);
        }

        [TestMethod]
        public void AddressListOk()
        {
            // create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            // create a list of test data
            List<clsDestination> TestList = new List<clsDestination>();
            // create the item of test data
            clsDestination TestItem = new clsDestination();
            // set the properties
            TestItem.DestinationID = 1;
            TestItem.Destination = "Rome";
            TestItem.PricePerPerson = 99;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllDestinations.DestinationList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllDestinations.DestinationList, TestList);
        }

        [TestMethod]
        public void ThisDestinationPropertyOK()
        {
            // create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            // create some test data to assign to the property
            clsDestination TestDestination = new clsDestination();
            // set the properties to the test object
            TestDestination.DestinationID = 1;
            TestDestination.Destination = "Rome";
            TestDestination.PricePerPerson = 99;
            // assign the data to the property
            AllDestinations.ThisDestination = TestDestination;
            // test to see that the two values are the same
            Assert.AreEqual(AllDestinations.ThisDestination, TestDestination);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            // create a list of test data
            List<clsDestination> TestList = new List<clsDestination>();
            // create the item of test data
            clsDestination TestItem = new clsDestination();
            // set its properties
            TestItem.DestinationID = 1;
            TestItem.Destination = "Rome";
            TestItem.PricePerPerson = 99;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllDestinations.DestinationList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllDestinations.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            // create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            // create the item of test data
            clsDestination TestItem = new clsDestination();
            // primary key variable
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.DestinationID = 1;
            TestItem.Destination = "Rome";
            TestItem.PricePerPerson = 99;
            // set ThisDestination to the test data
            AllDestinations.ThisDestination = TestItem;
            // add the record
            PrimaryKey = AllDestinations.Add();
            // set the primary key of the test data
            TestItem.DestinationID = PrimaryKey;
            // find the record
            AllDestinations.ThisDestination.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllDestinations.ThisDestination, TestItem);

        }

        
        public void UpdateMethodOk()
        {
            // create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            // create the item of test data
            clsDestination TestItem = new clsDestination();
            // primary key variable
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Destination = "Rome";
            TestItem.PricePerPerson = 99;
            // set ThisDestination to the test data
            AllDestinations.ThisDestination = TestItem;
            // add the record
            PrimaryKey = AllDestinations.Add();
            // set the primary key of the test data
            TestItem.DestinationID = PrimaryKey;
            // modify the test data
            TestItem.Destination = "Paris";
            TestItem.PricePerPerson = 50;
            // set the record based on the new test data
            AllDestinations.ThisDestination = TestItem;
            // update the record
            AllDestinations.Update();
            // find the record
            AllDestinations.ThisDestination.Find(PrimaryKey);
            // test to see ThisDestination matches the test data
            Assert.AreEqual(AllDestinations.ThisDestination, TestItem);

        }

        [TestMethod]
        public void FilterByDestinationMethodOK()
        {
            // create an instance of the class we want to create
            clsDestinationCollection AllDestinations = new clsDestinationCollection();
            // create an instance of the filtered data
            clsDestinationCollection FilteredDestinations = new clsDestinationCollection();
            // apply a blank string to return all records
            FilteredDestinations.FilterByDestination("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDestinations.Count, FilteredDestinations.Count);
        }

        [TestMethod]
        public void FilterByDestinationNoneFound()
        {
            // create an instance of the filtered data
            clsDestinationCollection FilteredDestinations = new clsDestinationCollection();
            // apply a destination that does not exist
            FilteredDestinations.FilterByDestination("XXX XXX");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredDestinations.Count);
        }

        [TestMethod]
        public void FilterByDestinationTestPKDataFound()
        {
            // create an instance of the filtered data
            clsDestinationCollection FilteredDestinations = new clsDestinationCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a destination that does exist
            FilteredDestinations.FilterByDestination("California");
            // check that the correct number of records are found
            if (FilteredDestinations.Count == 2)
            {
                // check the first record is ID 8
                if (FilteredDestinations.DestinationList[0].DestinationID != 9)
                {
                    OK = false;
                }
                // check the first record if ID 11
                if (FilteredDestinations.DestinationList[1].DestinationID != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FilterByDestinationTestNameDataFound()
        {
            // create an instance of the filtered data
            clsDestinationCollection FilteredDestinations = new clsDestinationCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a destination that exist
            FilteredDestinations.FilterByDestination("California");
            // check that the correct number of records are found
            if (FilteredDestinations.Count == 2)
            {
                // check the first record is California
                if (FilteredDestinations.DestinationList[0].Destination != "California")
                {
                    OK = false;
                }
                // check the first record is California
                if (FilteredDestinations.DestinationList[1].Destination != "California")
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FilterByDestinationTestPriceDataFound()
        {
            // create an instance of the filtered data
            clsDestinationCollection FilteredDestinations = new clsDestinationCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a destination that exists
            FilteredDestinations.FilterByDestination("California");
            // check that the correct number of records are found
            if (FilteredDestinations.Count == 2)
            {
                // check the data is 300
                if (FilteredDestinations.DestinationList[0].PricePerPerson != 200)
                {
                    OK = false;
                }
                // check the data is 250
                if (FilteredDestinations.DestinationList[1].PricePerPerson != 250)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
