using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    /// <summary>
    /// Summary description for tstCarStaffCollection
    /// </summary>
    [TestClass]
    public class tstCarStaffCollection
    {
        public tstCarStaffCollection()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCarStaffCollection AllCarStaff = new clsCarStaffCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCarStaff);
        }
        //[TestMethod]
        //public void CarStaffOk()
        //{
        //    //create an instance of the class we want to create
        //    clsCarStaffCollection AllCarStaff = new clsCarStaffCollection();
        //    //create  some test data  to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsCarStaff> TestList = new List<clsCarStaff>();
        //    //add an item to the list
        //    //create the item of test data
        //    clsCarStaff TestItem = new clsCarStaff();
        //    //set its properties
        //    TestItem. StaffNo= 3;
        //    TestItem.StaffName = "Chetan";
        //    TestItem.StaffAddress = "80 spence street ";
        //    TestItem.StaffEmail = "chetan@gmail.com ";
        //    TestItem.StaffPhoneNumber = "05225889212 ";
        //    //add  the item to the list
        //    TestList.Add(TestItem);
        //    //assign the data  To property
        //    AllCarStaff.CarStaffList = TestList;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCarStaff.CarStaffList, TestList);
        //}
        [TestMethod]
        public void CarStaffAddMethodOk()
        {
            //create an instance of the class we want to create
            clsCarStaffCollection AllCarStaff = new clsCarStaffCollection();
            //create the item of test data
            clsCarStaff TestItem = new clsCarStaff();
            // car to store the rpimary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 3;
            TestItem.StaffName = "Chetan";
            TestItem.StaffAddress = "80 spence street ";
            TestItem.StaffEmail = "chetan@gmail.com ";
            TestItem.StaffPhoneNumber = "05225889212 ";
            //set thiscar park to the test data 
            AllCarStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllCarStaff.Add();
            // set the primary key of the data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllCarStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCarStaff.ThisStaff, TestItem);
        }
        public void CarStaffDeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCarStaffCollection AllCarStaff = new clsCarStaffCollection();
            //create the item of test data
            clsCarStaff TestItem = new clsCarStaff();
            // car to store the rpimary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 3;
            TestItem.StaffName = "Chetan";
            TestItem.StaffAddress = "80 spence street ";
            TestItem.StaffEmail = "chetan@gmail.com ";
            TestItem.StaffPhoneNumber = "05225889212 "; 
            //set thiscar park to the test data 
            AllCarStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllCarStaff.Add();
            // set the primary key of the data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllCarStaff.ThisStaff.Find(PrimaryKey);
            //delete the record 
            AllCarStaff.Delete();
            //now find the record
            Boolean Found = AllCarStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void CarStaffUpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsCarStaffCollection AllCarStaff = new clsCarStaffCollection();
            //create the item of test data
            clsCarStaff TestItem = new clsCarStaff();
            // car to store the rpimary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 3;
            TestItem.StaffName = "Chetan";
            TestItem.StaffAddress = "80 spence street ";
            TestItem.StaffEmail = "chetan@gmail.com ";
            TestItem.StaffPhoneNumber = "05225889212 ";
            //set thiscar park to the test data 
            AllCarStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllCarStaff.Add();
            // set the primary key of the data
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.StaffNo = 1003;
            TestItem.StaffName = "Chetan";
            TestItem.StaffAddress = "50 spence street ";
            TestItem.StaffEmail = "chetan@gmail.co.uk ";
            TestItem.StaffPhoneNumber = "05225889212 ";
            //set thiscar park to the test data 
            AllCarStaff.ThisStaff = TestItem;
            //update the record
            AllCarStaff.Update();
            //find the record
            AllCarStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCarStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void FilterBystaffNameMethodOk()
        {
            //create an innstance of the class containing unfiltered results
            clsCarStaffCollection AllCarStaff = new clsCarStaffCollection();
            //create  an instance of the filtered data
            clsCarStaffCollection FilteredStaffName = new clsCarStaffCollection();
            //apply a blank string(should return all records)
            FilteredStaffName.FilterByStaffName("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllCarStaff.Count, FilteredStaffName.Count);
        }
        [TestMethod]
        public void FilterByStaffNameNoneFound()
        {
            //create an instance of the filtered data
            clsCarStaffCollection FillteredStaffName = new clsCarStaffCollection();
            //apply a FirstName that doesnt exits
            FillteredStaffName.FilterByStaffName("aaaa");
            //test to see that there are no records found
            Assert.AreEqual(0, FillteredStaffName.Count);
        }
        [TestMethod]
        public void FilterbyFirstNametestDataFound()
        {
            //create an instance of the class we want to create 
            clsCarStaffCollection FilterFirstNames = new clsCarStaffCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a car reg that doesnt exit
            FilterFirstNames.FilterByStaffName("Omer");
            //check that the coorect number of records are found
            if (FilterFirstNames.Count == 2)
            {
                //check that the first record is id 1 
                if (FilterFirstNames.StaffList[0].StaffNo != 6)
                {
                    Ok = false;
                }
                //check that the first record  is id 2
                if (FilterFirstNames.StaffList[1].StaffNo != 7)
                {
                    Ok = false;
                }

            }
            else
            {
                Ok = false;
            }
            //test to see that there are no records
            Assert.IsTrue(Ok);


        }
    }
}
