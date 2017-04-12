using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace MyTestFramework
{
    /// <summary>
    /// Summary description for TstCustomerCollection
    /// </summary>
    [TestClass]
    public class TstCustomerCollection
    {


        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instane of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item of the test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.CustomerNo = 4;
            TestItem.FirstName = "Sonia";
            TestItem.Surname = "Ruskhar ";
            TestItem.Address1 = "20 low street ";
            TestItem.Address2 = "15 dowing street";
            TestItem.Postcode = "le5 7du";
            TestItem.PhoneNumber = "04452662121";
            TestItem.Email = "Sonia@hotmail.co.uk";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOk()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //create some test datato assign to the property
        //    Int32 SomeCount = 0;
        //    //assign the data to the property
        //    AllCustomers.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomers TestCustomer = new clsCustomers();
            //set the properties of the test object
            TestCustomer.CustomerNo = 4;
            TestCustomer.FirstName = "Sonia";
            TestCustomer.Surname = "Ruskhar ";
            TestCustomer.Address1 = "20 low street ";
            TestCustomer.Address2 = "15 dowing street";
            TestCustomer.Postcode = "le5 7du";
            TestCustomer.PhoneNumber = "04452662121";
            TestCustomer.Email = "Sonia@hotmail.co.uk";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

    

        [TestMethod]
        public void ListAndCount()
        {
            //creat an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create the item of the test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.CustomerNo = 4;
            TestItem.FirstName = "Sonia";
            TestItem.Surname = "Ruskhar ";
            TestItem.Address1 = "20 low street ";
            TestItem.Address2 = "15 dowing street";
            TestItem.Postcode = "le5 7du";
            TestItem.PhoneNumber = "04452662121";
            TestItem.Email = "Sonia@hotmail.co.uk";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        //[TestMethod]
        //public void TwoRecordsPresent()

        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 13;
            TestItem.FirstName = "Amy";
            TestItem.Surname = "Gray ";
            TestItem.Address1 = "10 low street ";
            TestItem.Address2 = "15 dowing street";
            TestItem.Postcode = "le5 7du";
            TestItem.PhoneNumber = "04452662121";
            TestItem.Email = "AmyGray@hotmail.co.uk";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerNo = 13;
            TestItem.FirstName = "Amy";
            TestItem.Surname = "Gray ";
            TestItem.Address1 = "10 low street ";
            TestItem.Address2 = "15 dowing street";
            TestItem.Postcode = "le5 7du";
            TestItem.PhoneNumber = "04452662121";
            TestItem.Email = "AmyGray@hotmail.co.uk";
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.CustomerNo = 13;
            TestItem.FirstName = "Amy";
            TestItem.Surname = "Gray ";
            TestItem.Address1 = "9 low street ";
            TestItem.Address2 = "555 dowing street";
            TestItem.Postcode = "le5 7du";
            TestItem.PhoneNumber = "04452662121";
            TestItem.Email = "AmyGray@hotmail.co.uk";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void FilterBySurnameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.FilterBySurname("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterBySurnameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a post code that doesn't exist
            FilteredCustomers.FilterBySurname("a");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterBySurnameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection ();
            //var to store outcome
            Boolean OK = true;
            //apply a surname that doesn't exist
            FilteredCustomers.FilterBySurname("ggg ggg");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 3
                if (FilteredCustomers.CustomerList[0].CustomerNo != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 4
                if (FilteredCustomers.CustomerList[1].CustomerNo != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }









    }
}

        

            

            

















