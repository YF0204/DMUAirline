using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibrary
{
    [TestClass]
    public class tstCarPark
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //test to seethat it exists 
            Assert.IsNotNull(Acar);
        }
        [TestMethod]
        public void BookingDateOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //create some test data to assign to get the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Acar.BookingDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acar.BookingDate, TestData);
        }
        [TestMethod]
        public void CarparkidOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //create some test data to assign to get the property
            Int32 CarParkID = 2;
            Acar.carparkid = CarParkID;
            Assert.AreEqual(Acar.carparkid, CarParkID);
        }
        [TestMethod]
        public void CarRegOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //create some test data to assign to get the property
            string TestData = "KUO2 DXY";
            //assign the data to the property
            Acar.CarReg = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acar.CarReg, TestData);
        }
        [TestMethod]
        public void EndDateOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //create some test data to assign to get the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Acar.EndDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acar.EndDate, TestData);
        }
        [TestMethod]
        public void LocationOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //create some test data to assign to get the property
            string TestData = "101A";
            //assign the data to the property
            Acar.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acar.Location, TestData);
        }
        [TestMethod]
        public void StartDateOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            //create some test data to assign to get the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Acar.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acar.StartDate, TestData);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            string BookingDate = DateTime.Now.Date.ToString();
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // test data to use with the method
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCarParkIDFound()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // check the car park id
            if (Acar.carparkid != 151)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCarRegFound()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // check the car park id
            if (Acar.CarReg != "bbgg ttt")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBookingDateFound()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // check the car park id
            if (Acar.BookingDate != Convert.ToDateTime("20/04/2017"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStartDateFound()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // check the car park id
            if (Acar.StartDate != Convert.ToDateTime("21/04/2017"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEndDateFound()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // check the car park id
            if (Acar.EndDate != Convert.ToDateTime("25/04/2017"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLocationFound()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable 
            Boolean Found = false;
            // boolean variable
            Boolean OK = true;
            // create test data to pass through
            Int32 CarParkID = 151;
            // execute the method
            Found = Acar.Find(CarParkID);
            // check the car park id
            if (Acar.Location != "B2")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void BookingDateExMin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.AddYears(-500);
            string BookingDate = TestDate.ToString();
            //string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay 1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BookingDateMinLessOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.AddDays(-1);
            string BookingDate = TestDate.ToString();
           // string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BookingDateMin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.Date;
            string BookingDate = TestDate.ToString();
            //string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookingDateMinPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = TestDate.ToString();
            //string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void BookingDateMaxMinusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.AddDays(-1);
            string BookingDate = TestDate.ToString();
           // string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void BookingDateMaxBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.Date;
            string BookingDate = TestDate.ToString();
           // string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void BookingDateMaxPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = TestDate.ToString();
            //string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void BookingDateMid()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.Date;
            string BookingDate = TestDate.ToString();
           // string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void BookingDateExtremeMax()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            DateTime TestDate = DateTime.Now.AddYears(5);
            string BookingDate = TestDate.ToString();
            //string carparkid = "1a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        
        public void carparkidMinminusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "a";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        
        public void carparkidMin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "aa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        public void carparkidMinplusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "aaa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        public void carparkidMaxminusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "aaa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        public void carparkidMaxmBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "aaaa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        public void carparkidMaxmPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "aaaaa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        
        public void carparkidMid()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "aaa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        public void carparkidExtremeMax()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "aaaaaaa";
            string CarReg = "KU02 DXY";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void carpregminlessOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "aa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void carpregmin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "aaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void carpregminplusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "aaaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void carpregmaxminusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
         //   string carparkid = "1a";
            string CarReg = "aaaaaaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void carpregmaxBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "aaaaaaaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void carpregmaxplusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
         //   string carparkid = "1a";
            string CarReg = "aaaaaaaaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void carpregMid()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "aaaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void carpregExMax()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
         //   string carparkid = "1a";
            string CarReg = "aaaaaaaaaa";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDateExMin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
         //   string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddYears(-12);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDateMinLessOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
        //    string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddDays(-1);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDateMinBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
         //   string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.Date;
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StartDateMinPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddDays(+1);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StartDateMaxMinusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddMonths(+6 -1);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StartDateMaxBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddMonths(+6);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StartDateMaxPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddMonths(+6 +1);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StartDateMid()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
          //  string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddMonths(+3);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StartDateExtremeMax()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            DateTime TestDate = DateTime.Now.AddYears(+6);
            string StartDate = TestDate.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "Bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void LocationMinLessOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "a";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void LocationMin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "aa";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LocationMinPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "aaa";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LocationMaxlessOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "aaa";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LocationMaxBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "aaaa";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LocationMaxplusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "aaaaa";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void LocationMid()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "aa";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LocationExtremeMax()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            string EndDate = DateTime.Now.Date.ToString();
            string Location = "";
            Location = Location.PadRight(500, 'a');
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EndDateExtrememin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddYears(-15);
            string EndDate = TestDate.ToString();
            string Location = "bay1";     
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EndDateminLessOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddDays(-1);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EndDatemeMin()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.Date;
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EndDateMinPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddDays(+1);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EndDateMaxPlusOne()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
            //string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddMonths(+6 -1);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EndDateMaxBoundary()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddMonths(+6);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EndDateMaxBoundaryplusone()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddMonths(+6 +1);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate, CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EndDateMid()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddMonths(+3);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EndDateExtremeMaxx()
        {
            // create an instance of a class we want to create
            clsCarPark Acar = new clsCarPark();
            // boolean variable
            Boolean OK = false;
            //Create  someTest data  to pass method
            //DateTime TestDate = DateTime.Now.AddDays(1);
            string BookingDate = DateTime.Now.Date.ToString();
           // string carparkid = "1a";
            string CarReg = "Kuo2 dxy";
            string StartDate = DateTime.Now.Date.ToString();
            DateTime TestDate = DateTime.Now.AddYears(+6);
            string EndDate = TestDate.ToString();
            string Location = "bay1";
            // execute the method
            OK = Acar.Valid(BookingDate,  CarReg, StartDate, EndDate, Location);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

    }
}
