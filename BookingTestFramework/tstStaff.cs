using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace BookingTestFramework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void StaffInstanceOK()
        {
            // create an instance of the staff class
            clsStaff Staff = new clsStaff();
            // make sure the class exists
            Assert.IsNotNull(Staff);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            Int32 ID = 1;
            // assign the data to the property
            AMember.StaffID = ID;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffID, ID);
        }

        [TestMethod]
        public void StaffFirstNameOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            string Staff = "Matt";
            // assign the data to the property
            AMember.StaffFirstName = Staff;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffFirstName, Staff);
        }

        [TestMethod]
        public void StaffLastNameOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            string Staff = "Chus";
            // assign the data to the property
            AMember.StaffLastName = Staff;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffLastName, Staff);
        }

        [TestMethod]
        public void StaffAddressOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            string Address = "85 Stafford Road";
            // assign the data to the property
            AMember.StaffAddress = Address;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffAddress, Address);
        }

        [TestMethod]
        public void StaffContactNoOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            string Number = "01254576852";
            // assign the data to the property
            AMember.StaffContactNo = Number;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffContactNo, Number);
        }

        [TestMethod]
        public void StaffPostCodeOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            string PostCode = "WS24LA";
            // assign the data to the property
            AMember.StaffPostCode = PostCode;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffPostCode, PostCode);
        }

        [TestMethod]
        public void StaffDOBOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            DateTime DOB = DateTime.Now.Date;
            // minus 16 years from the data
            DOB = DOB.AddYears(-16);
            // assign the data to the property
            AMember.StaffDOB = DOB;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffDOB, DOB);
        }

        [TestMethod]
        public void StaffDateJoinedOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            DateTime DateJoined = DateTime.Now.Date;
            // assign the data to the property
            AMember.StaffDateJoined = DateJoined;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffDateJoined, DateJoined);
        }

        [TestMethod]
        public void StaffEmailAddressOK()
        {
            // create an instance of the staff class
            clsStaff AMember = new clsStaff();
            // create test data to assign to the property
            string EmailAddress = "yaseenDMU@gmail.com";
            // assign the data to the property
            AMember.StaffEmailAddress = EmailAddress;
            // test to see that the two values are the same
            Assert.AreEqual(AMember.StaffEmailAddress, EmailAddress);
        }

        [TestMethod]
        public void StaffValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the staff ID
            if (AMember.StaffID != 3)
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffFirstName != "Omer")
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffLastName != "Samad")
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffAddress != "11 Drowning Street")
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffContactNoFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffContactNo != "07131212531")
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffPostCodeFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffPostCode != "LE19BH")
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffDOB != Convert.ToDateTime("02/01/1995"))
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffDateJoinedFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffDateJoined != Convert.ToDateTime("12/02/2017"))
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffEmailAddressFound()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean variable to record if data is OK
            Boolean Ok = true;
            // create test data to use with the method
            Int32 StaffID = 3;
            // execute the method
            Found = AMember.Find(StaffID);
            // check the property
            if (AMember.StaffEmailAddress != "of@hotmail.co.uk")
            {
                Ok = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffFirstNameMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "a";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "aa";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "";
            First = First.PadRight(49, 'a');
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffFirstNameMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "";
            First = First.PadRight(50, 'a');
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "";
            First = First.PadRight(51, 'a');
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "";
            First = First.PadRight(25, 'a');
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "";
            First = First.PadRight(100, 'a');
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffLastNameMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "a";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "aa";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "";
            Last = Last.PadRight(49, 'a');
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffLastNameMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "";
            Last = Last.PadRight(50, 'a');
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "";
            Last = Last.PadRight(51, 'a');
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "";
            Last = Last.PadRight(25, 'a');
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "";
            Last = Last.PadRight(100, 'a');
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddressMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "a";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "";
            Address = Address.PadRight(99, 'a');
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddressMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "";
            Address = Address.PadRight(100, 'a');
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "";
            Address = Address.PadRight(101, 'a');
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "";
            Address = Address.PadRight(200, 'a');
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffContactNoMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffContactNoMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "0";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StaffContactNoMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "0000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffContactNoMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void StaffContactNoMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "000000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StaffContactNoMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void StaffContactNoExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "00000000000000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "a";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "aa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "aaaaaaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "aaaaaaaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "aaaaaaaaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffPostCodeMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "";
            PostCode = PostCode.PadRight(100, 'a');
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 500 years old (1517)
            TestDate = TestDate.AddYears(-500);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 200 years old minus 1 day
            TestDate = TestDate.AddYears(-200);
            TestDate = TestDate.AddDays(-1);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 200 years old
            TestDate = TestDate.AddYears(-200);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 200 years plus 1 day
            TestDate = TestDate.AddYears(-200);
            TestDate = TestDate.AddDays(1);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 16 years old and minus 1 day
            TestDate = TestDate.AddYears(16);
            TestDate = TestDate.AddDays(-1);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffDOBMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 16 years old
            TestDate = TestDate.AddYears(-16);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 16 years old and add 1 day
            TestDate = TestDate.AddYears(-16);
            TestDate = TestDate.AddDays(1);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // variable to store test date data
            DateTime TestDate;
            // set to today's date
            TestDate = DateTime.Now.Date;
            // 50 years old
            TestDate = TestDate.AddYears(-50);
            // convert to string
            string DOB = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDOBInvalidData()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DateJoined = DateTime.Now.Date.ToString();
            // set the DOB to a non date value
            string DOB = "This is not a date!";
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        //[TestMethod]
        //public void StaffDateJoinedExtremeMin()
        //{
        //    // create an instace of the class we want to create
        //    clsStaff AMember = new clsStaff();
        //    // boolean variable to store the result of the validation
        //    Boolean OK = false;
        //    // create test data to assign to the property
        //    string First = "Matthew";
        //    string Last = "Anderson";
        //    string Address = "85 Warstead Road";
        //    string Email = "matt@gmail.com";
        //    string PostCode = "WS29RA";
        //    string ContactNo = "01922645322";
        //    string DOB = "02/04/1956";
        //    // variable to store the test date data
        //    DateTime TestDate;
        //    // set the date to today
        //    TestDate = DateTime.Now.Date;
        //    // change the date to less then 100 years
        //    TestDate = TestDate.AddYears(-100);
        //    // convert the date variable to a string
        //    string DateJoined = TestDate.ToString();
        //    // execute the method
        //    OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
        //    // test to see that the result is correct
        //    Assert.IsFalse(OK);
        //}

        //[TestMethod]
        //public void StaffDateJoinedMinLessOne()
        //{
        //    // create an instace of the class we want to create
        //    clsStaff AMember = new clsStaff();
        //    // boolean variable to store the result of the validation
        //    Boolean OK = false;
        //    // create test data to assign to the property
        //    string First = "Matthew";
        //    string Last = "Anderson";
        //    string Address = "85 Warstead Road";
        //    string Email = "matt@gmail.com";
        //    string PostCode = "WS29RA";
        //    string ContactNo = "01922645322";
        //    string DOB = "02/04/1956";
        //    // variable to store the test date data
        //    DateTime TestDate;
        //    // set the date to today
        //    TestDate = DateTime.Now.Date;
        //    // change the date to less then 1 day
        //    TestDate = TestDate.AddYears(-1);
        //    // convert the date variable to a string
        //    string DateJoined = TestDate.ToString();
        //    // execute the method
        //    OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
        //    // test to see that the result is correct
        //    Assert.IsFalse(OK);
        //}

        [TestMethod]
        public void StaffDateJoinedMin()
        {
            // create an instace of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            // variable to store the test date data
            DateTime TestDate;
            // set the date to today
            TestDate = DateTime.Now.Date;
            // convert the date variable to a string
            string DateJoined = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDateJoinedMinPlusOne()
        {
            // create an instace of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            // variable to store the test date data
            DateTime TestDate;
            // set the date to today
            TestDate = DateTime.Now.Date;
            // change the date - add 1 day
            TestDate = TestDate.AddDays(1);
            // convert the date variable to a string
            string DateJoined = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDateJoinedExtremeMax()
        {
            // create an instace of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            // variable to store the test date data
            DateTime TestDate;
            // set the date to today
            TestDate = DateTime.Now.Date;
            // change the date to more than 100 years
            TestDate = TestDate.AddYears(100);
            // convert the date variable to a string
            string DateJoined = TestDate.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDateJoinedInvalidData()
        {
            // create an instace of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "matt@gmail.com";
            string PostCode = "WS29RA";
            string ContactNo = "01922645322";
            string DOB = "02/04/1956";
            // convert the date variable to a string
            string DateJoined = "This ain't no date value!";
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "";
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMinBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "a@.";
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "a@.c";
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "";
            Email = Email.PadRight(253, '@');
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMaxBoundary()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "";
            Email = Email.PadRight(254, '@');
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "";
            Email = Email.PadRight(255, '@');
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffEmailAddressMid()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "";
            Email = Email.PadRight(127, '@');
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffEmailAddressExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AMember = new clsStaff();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string First = "Matthew";
            string Last = "Anderson";
            string Address = "85 Warstead Road";
            string Email = "";
            Email = Email.PadRight(500, '@');
            string PostCode = "aaaa";
            string ContactNo = "00000000000";
            string DOB = "02/04/1956";
            string DateJoined = DateTime.Now.Date.ToString();
            // execute the method
            OK = AMember.Valid(First, Last, Address, Email, PostCode, ContactNo, DOB, DateJoined);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}