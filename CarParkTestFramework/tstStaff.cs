using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            //test to see if that exists
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void StaffAddressOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            //create some test data to assign to the property
            string TestData = "12c";
            //assign the data to the property
            AStaff.StaffAddress = TestData;
            //test to see if the two value are the same
            Assert.AreEqual(AStaff.StaffAddress, TestData);
          
        }
        [TestMethod]
        public void StaffEmailOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            //create some test data to assign to the property
            string TestData = "aaaa@hotmail.com";
            //assign the data to the property
            AStaff.StaffEmail = TestData;
            //test to see if the two value are the same
            Assert.AreEqual(AStaff.StaffEmail, TestData);

        }
        [TestMethod]
        public void StaffNameOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            //create some test data to assign to the property
            string TestData = "Chetan";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see if the two value are the same
            Assert.AreEqual(AStaff.StaffName, TestData);

        }
        [TestMethod]
        public void StaffPhoneNumberOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            //create some test data to assign to the property
            string TestData = "079334355";
            //assign the data to the property
            AStaff.StaffPhoneNumber = TestData;
            //test to see if the two value are the same
            Assert.AreEqual(AStaff.StaffPhoneNumber, TestData);

        }
        [TestMethod]
        public void StaffIDOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffNo = TestData;
            //test to see if the two value are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);

        }
        [TestMethod]
        public void ValidmethodOk()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);
                
        }
        [TestMethod]
        public void FindmethodOk()
        {
            // create an instance of a class we want to create
            clsCarPark Astaff = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // test data to use with the method
            Int32 staffNo = 1;
            // execute the method
            Found = Astaff.Find(staffNo);
            // test to see that the result is correct
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffNoFound()
        {
            // create an instance of a class we want to create
            clsCarStaff Astaff = new clsCarStaff();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 StaffNo = 1;
            // execute the method
            Found = Astaff.Find(StaffNo);
            // check the car park id
            if (Astaff.StaffNo != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            // create an instance of a class we want to create
            clsCarStaff Astaff = new clsCarStaff();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 StaffNo = 1;
            // execute the method
            Found = Astaff.Find(StaffNo);
            // check the car park id
            if (Astaff.StaffName != "James")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffEmailFound()
        {
            // create an instance of a class we want to create
            clsCarStaff Astaff = new clsCarStaff();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 StaffNo = 1;
            // execute the method
            Found = Astaff.Find(StaffNo);
            // check the car park id
            if (Astaff.StaffEmail != "admin@hotmail.com")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffAddressFound()
        {
            // create an instance of a class we want to create
            clsCarStaff Astaff = new clsCarStaff();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 StaffNo = 1;
            // execute the method
            Found = Astaff.Find(StaffNo);
            // check the car park id
            if (Astaff.StaffAddress != "76 Cork Street")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffPhoneNumberFound()
        {
            // create an instance of a class we want to create
            clsCarStaff Astaff = new clsCarStaff();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 StaffNo = 1;
            // execute the method
            Found = Astaff.Find(StaffNo);
            // check the car park id
            if (Astaff.StaffPhoneNumber != "01456612014")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "aaaa";
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void StaffAddressMin()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "aaaaa";
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "aaaaaa";
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void StaffAddressMaxMinusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(19, 'a');
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void StaffAddressMaxBoundary()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(20, 'a');
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(21, 'a');
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void StaffAddressMid()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(10, 'a');
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(50, 'a');
            string StaffEmail = "aaaa@hotmail.com";
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void staffEmailMinMinusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(12, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffEmailMinBoundary()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(13, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffEmailMinPlusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(14, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffEmailMaxMinusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(253, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffEmailMaxBoundary()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(254, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffEmailMaxPlusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(255, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffEmailMid()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(127, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffEmailExtremeMax()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(500, 'a');
            string StaffName = "Chetan";
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffNameMinMinusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(2, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffNameMin()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(3, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffNameMinplusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(4, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffNameMaxminusOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(34, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffNameMax()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(35, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffNameMaxplusone()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(36, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffNameMid()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(17, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffNameExtremeMax()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "";
            StaffName = StaffName.PadRight(200, 'a');
            string StaffPhoneNumber = "079334355";
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffPhoneMumberMinLessOne()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(10, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffiPhoneNumberMin()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(11, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffiPhoneNumberMinplusone()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(12, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffiPhoneNumbermaxminusone()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(12, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffiPhoneNumbermaxboundary()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(13, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffiPhoneNumbermaxbounplusone()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(14, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void staffiPhoneNumbermid()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(12, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void staffiPhoneExtremeMax()
        {
            //create an instance of a class we want to create
            clsCarStaff AStaff = new clsCarStaff();
            // bhollean variable to store the results of the validation
            Boolean Ok = false;
            // create some test data to pass to the method
            string StaffAddress = "12c";
            string StaffEmail = "aaa@hotmail.com";
            string StaffName = "Cheatan";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(20, 'a');
            //Invoke the method
            Ok = AStaff.Valid(StaffAddress, StaffEmail, StaffName, StaffPhoneNumber);
            //test to see that the results  is correct
            Assert.IsFalse(Ok);

        }
       
    }
}
