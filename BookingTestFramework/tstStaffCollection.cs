using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace BookingTestFramework
{
    /// <summary>
    /// Summary description for tstStaffCollection
    /// </summary>
    [TestClass]
    public class tstStaffCollection
    {
        public tstStaffCollection()
        {
            // TODO LATER
        }

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllMembers = new clsStaffCollection();
            // test to see that it exists
            Assert.IsNotNull(AllMembers);
        }

        [TestMethod]
        public void StaffListOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllMembers = new clsStaffCollection();
            // create test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Matthew";
            TestItem.StaffLastName = "Anderson";
            TestItem.StaffAddress = "85 Warstead Road";
            TestItem.StaffContactNo = "01922645322";
            TestItem.StaffDOB = DateTime.Now.AddYears(-61);
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffPostCode = "WS29RA";
            TestItem.StaffEmailAddress = "matt@gmail.com";
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllMembers.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllMembers.StaffList, TestList);
        }

        [TestMethod]
        public void ThisMemberPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllMembers = new clsStaffCollection();
            // create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set the properties
            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Matthew";
            TestStaff.StaffLastName = "Anderson";
            TestStaff.StaffAddress = "85 Warstead Road";
            TestStaff.StaffContactNo = "01922645322";
            TestStaff.StaffDOB = DateTime.Now.AddYears(-61);
            TestStaff.StaffDateJoined = DateTime.Now.Date;
            TestStaff.StaffPostCode = "WS29RA";
            TestStaff.StaffEmailAddress = "matt@gmail.com";
            // assign the data to the property 
            AllMembers.ThisMember = TestStaff;
            // test to see that the two values are the same
            Assert.AreEqual(AllMembers.ThisMember, TestStaff); 
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllMembers = new clsStaffCollection();
            // create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Matthew";
            TestItem.StaffLastName = "Anderson";
            TestItem.StaffAddress = "85 Warstead Road";
            TestItem.StaffContactNo = "01922645322";
            TestItem.StaffDOB = DateTime.Now.AddYears(-61);
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffPostCode = "WS29RA";
            TestItem.StaffEmailAddress = "matt@gmail.com";
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllMembers.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllMembers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllMembers = new clsStaffCollection();
            // create the item of test data 
            clsStaff TestItem = new clsStaff();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Matthew";
            TestItem.StaffLastName = "Anderson";
            TestItem.StaffAddress = "85 Warstead Road";
            TestItem.StaffContactNo = "01922645322";
            TestItem.StaffDOB = DateTime.Now.AddYears(-61);
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffPostCode = "WS29RA";
            TestItem.StaffEmailAddress = "matt@gmail.com";
            // set ThisMember to the test data
            AllMembers.ThisMember = TestItem;
            // add the record
            PrimaryKey = AllMembers.Add();
            // set the primary key value
            TestItem.StaffID = PrimaryKey;
            // find the record
            AllMembers.ThisMember.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllMembers.ThisMember, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllMembers = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // primary key variable
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffFirstName = "Matthew";
            TestItem.StaffLastName = "Anderson";
            TestItem.StaffAddress = "85 Warstead Road";
            TestItem.StaffContactNo = "01922645322";
            TestItem.StaffDOB = DateTime.Now.AddYears(-61);
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffPostCode = "WS29RA";
            TestItem.StaffEmailAddress = "matt@gmail.com";
            // set ThisDestination to the test data
            AllMembers.ThisMember = TestItem;
            // add the record
            PrimaryKey = AllMembers.Add();
            // set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            // modify the test data
            TestItem.StaffFirstName = "Andy";
            TestItem.StaffLastName = "Garcia";
            TestItem.StaffAddress = "92 Dickensian Road";
            TestItem.StaffContactNo = "01922458322";
            TestItem.StaffDOB = DateTime.Now.AddYears(-20);
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffPostCode = "LE1 TG2";
            TestItem.StaffEmailAddress = "AGarcia@gmail.com";
            // set the record based on the new test data
            AllMembers.ThisMember = TestItem;
            // update the record
            AllMembers.Update();
            // find the record
            AllMembers.ThisMember.Find(PrimaryKey);
            // test to see ThisDestination matches the test data
            Assert.AreEqual(AllMembers.ThisMember, TestItem);

        }

        [TestMethod]
        public void FilterByStaffLastNameMethodOK()
        {
            // create an instance of the collection class
            clsStaffCollection AllMembers = new clsStaffCollection();
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // apply a blank string
            FilteredMembers.FilterByStaffLastName("");
            // test to see that the two values are the same
            Assert.AreEqual(AllMembers.Count, FilteredMembers.Count);
        }

        [TestMethod]
        public void FilterByStaffLastNameNoneFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("XXX XXX");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredMembers.Count);
        }

        [TestMethod]
        public void FilterByStaffLastNameTestPKFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffID != 3)
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffID != 7)
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
        public void FilterByStaffLastNameTestFirstNameFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffFirstName != "Omer")
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffFirstName != "Matthew")
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
        public void FilterByStaffLastNameTestLastNameFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffLastName != "Samad")
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffLastName != "Samad")
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
        public void FilterByStaffLastNameTestContactNoFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffContactNo != "07131212531")
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffContactNo != "01922645322")
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
        public void FilterByStaffLastNameTestDOBFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffDOB != Convert.ToDateTime("02/01/1995"))
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffDOB != Convert.ToDateTime("07/03/1956"))
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
        public void FilterByStaffLastNameTestDateJoinedFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffDateJoined != Convert.ToDateTime("12/02/2017"))
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffDateJoined != Convert.ToDateTime("07/03/2017"))
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
        public void FilterByStaffLastNameTestPostCodeFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffPostCode != "LE19BH")
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffPostCode != "WS29RA")
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
        public void FilterByStaffLastNameTestEmailAddressFound()
        {
            // create an instance of the filtered data
            clsStaffCollection FilteredMembers = new clsStaffCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a last name that does not exist
            FilteredMembers.FilterByStaffLastName("Samad");
            // check that the correct number of records are found
            if (FilteredMembers.Count == 2)
            {
                // check that first record is ID 3
                if (FilteredMembers.StaffList[0].StaffEmailAddress != "of@hotmail.co.uk")
                {
                    OK = false;
                }
                // check that the second record is ID 8
                if (FilteredMembers.StaffList[1].StaffEmailAddress != "matt@gmail.com")
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
