using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MyTestFramework
{
    [TestClass]
    public class TstCustomers
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerFirstNameOk()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "selina";
            //asssign the data to the property 
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void CustomerSurnameOk()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "hayat";
            //asssign the data to the property 
            ACustomer.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, TestData);
        }

        [TestMethod]
        public void CustomerAddress1Ok()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = " 32 oxford street";
            //asssign the data to the property 
            ACustomer.Address1 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address1, TestData);
        }

        [TestMethod]
        public void CustomerAddress2Ok()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = " Management Office";
            //asssign the data to the property 
            ACustomer.Address2 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address2, TestData);
        }
        [TestMethod]
        public void CustomerPhoneNumberOk()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "07734946810";
            //asssign the data to the property 
            ACustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerEmailOk()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "selinahayat@gmail.com";
            //asssign the data to the property 
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void CustomerNoOk()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //asssign the data to the property 
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }
        

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string phoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,phoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class you want to create
            clsCustomers Acustomer = new clsCustomers();
            Boolean Found = false;
            //create some test data to use with the method stub
            Int32 CustomerNo = 4;
            //invoke the method
            Found = Acustomer.Find(CustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(4, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(5, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName,Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(6, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(34, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(35, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(36, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "";
            FirstName = FirstName.PadRight(17, 'a');
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(4, 'a');
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SurnameMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(5, 'a');
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(6, 'a');
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(34, 'a');
            string Address1 = " 28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SurnameMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(35, 'a');
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(36, 'a');
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "";
            Surname = Surname.PadRight(17, 'a');
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void Address1MinLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(4, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void Address1MinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(14, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void Address1MinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(15, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void Address1MaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1= Address1.PadRight(49, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void Address1MaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(50, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void Address1MaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(51, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void Address1Mid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(36, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname,Address1,Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]

        public void Address1ExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "";
            Address1 = Address1.PadRight(100, 'a');
            string Address2 = "Management office";
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void Address2MinLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight( 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse (Ok);
        }

        [TestMethod]
        public void Address2MinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(14, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void Address2MinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(15, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void Address2MaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(49, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void Address2MaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(50, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void Address2MaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(51, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void Address2Mid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(36, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]

        public void Address2ExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "";
            Address2 = Address2.PadRight(100, 'a');
            string Postcode = "Le15xu";
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2,Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void PostcodeMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "";
            Postcode = Postcode.PadRight(6, 'a');
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "";
            Postcode = Postcode.PadRight(7, 'a');
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "";
            Postcode = Postcode.PadRight(7, 'a');
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PostcodeMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "";
            Postcode = Postcode.PadRight(8, 'a');
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            Address2 = Address2.PadRight(51, 'a');
            string Postcode = "";
            Postcode = Postcode.PadRight(9, 'a');
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "";
            Postcode = Postcode.PadRight(4, 'a');
            string PhoneNumber = "07734946810";
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode,PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PhoneNumberMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(11, 'a');
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(12, 'a');
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(11, 'a');
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PhoneNumberMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "le15xu";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(12, 'a');
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le1xu";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(13, 'a');
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(6, 'a');
            string Email = "selinahayat@gmail.com";
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber,Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(15, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(16, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(253, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "Management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(254, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le1xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(255, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void EmailMid()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(127, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FirstName = "selina";
            string Surname = "Hayat";
            string Address1 = "28 oxford street";
            string Address2 = "management office";
            string Postcode = "le15xu";
            string PhoneNumber = "07734946810";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //invoke the method
            Ok = ACustomer.Valid(FirstName, Surname, Address1, Address2, Postcode, PhoneNumber, Email);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.CustomerNo != 4)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.FirstName != "Sonia")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.Surname != "ggg ggg1")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
            
        }
        [TestMethod]
        public void TestAddress1Found()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.Address1 != "20 low street ")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);

        }


        [TestMethod]
        public void TestAddress2Found()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.Address2 != "15 dowing street")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.Postcode != "le5 7du")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.PhoneNumber != "04452662121")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 4;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the customerno
            if (ACustomer.Email != "Sonia@hotmail.co.uk")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);


        }







    }


}



























