using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace BookingTestFramework
{
    [TestClass]
    public class tstAirline
    {
        [TestMethod]
        public void DestinationInstanceOK()
        {
            // create an instance of the class we want to create
            clsDestination Destination = new clsDestination();
            // make sure that it exists
            Assert.IsNotNull(Destination);
        }

        [TestMethod]
        public void DestinationIDOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // create test data to assign to the property
            Int32 ID = 1;
            // assign data to the property
            ADestination.DestinationID = ID;
            // test to see that the two values are the same
            Assert.AreEqual(ADestination.DestinationID, ID);
        }

        [TestMethod]
        public void DestinationNameOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // create test data to assign to the property
            string Destination = "New York";
            // assign the data to the property
            ADestination.Destination = Destination;
            // test to see that the two values are the same
            Assert.AreEqual(ADestination.Destination, Destination);
        }

        [TestMethod]
        public void PricePerPersonOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // create test data to assign to the property
            decimal PricePerPerson = 5.5m;
            // assign the data to the property
            ADestination.PricePerPerson = PricePerPerson;
            // test to see that the two values are the same
            Assert.AreEqual(ADestination.PricePerPerson, PricePerPerson);
        }

        [TestMethod]
        public void DayOfFlightOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // create test data to assign to the property
            DateTime Flight = DateTime.Now.Date;
            // add 7 days onto the date
            Flight = Flight.AddDays(7);
            // assign data to the property
            ADestination.DayOfFlight = Flight;
            // test to see that the two values are the same
            Assert.AreEqual(ADestination.DayOfFlight, Flight);
        }

        [TestMethod]
        public void ReturnDateOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // create test data to assign to the property
            DateTime Flight = DateTime.Now.Date;
            // add 7 days onto the date
            Flight = Flight.AddDays(14);
            // assign data to the property
            ADestination.ReturnDate = Flight;
            // test to see that the two values are the same
            Assert.AreEqual(ADestination.ReturnDate, Flight);
        }

        [TestMethod]
        public void DestinationValidMethodOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "New York";
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DestinationFindMethodOK()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // create test data to assign to the property
            Int32 DestinationID = 5;
            // execute the method
            Found = ADestination.Find(DestinationID);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDestinationIDFound()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean to record if data is ok
            Boolean OK = true;
            // create test data to use with the method
            Int32 DestinationID = 5;
            // execute the method
            Found = ADestination.Find(DestinationID);
            // check the destination ID
            if (ADestination.DestinationID != 5)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDestinationNameFound()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean to record if data is ok
            Boolean OK = true;
            // create test data to use with the method
            Int32 DestinationID = 5;
            // execute the method
            Found = ADestination.Find(DestinationID);
            // check the property
            if (ADestination.Destination != "Turkey")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPricePerPersonFound()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // boolean to record if data is ok
            Boolean OK = true;
            // create test data to use with the method
            Int32 DestinationID = 5;
            // execute the method
            Found = ADestination.Find(DestinationID);
            // check the property
            if (ADestination.PricePerPerson != 200)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DestinationNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "";
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DestinationNameMin()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "D";
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DestinationNameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "DA";
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DestinationNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "";
            Destination = Destination.PadRight(99, 'a');
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DestinationNameMaxBoundary()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "";
            Destination = Destination.PadRight(100, 'a');
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void DestinationNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "";
            Destination = Destination.PadRight(101, 'a');
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DestinationNameMid()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "";
            Destination = Destination.PadRight(50, 'a');
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DestinationNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "";
            Destination = Destination.PadRight(200, 'a');
            decimal Price = 100;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PricePerPersonExtremeMin()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = -10;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PricePerPersonMinlessOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 0;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PricePerPersonMin()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 0.01m;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PricePerPersonMinPlusOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 10;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PricePerPersonMaxMinusOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 1000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PricePerPersonMax()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PricePerPersonMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 1000000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PricePerPersonMid()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 5000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PricePerPersonExtremeMax()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        
        public void DayOfFlightMinLessOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = "19/03/2017";
            string Return = "25/03/2017";
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DayOfFlightMinBoundary()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DayOfFlightMinPlusOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        
        public void ReturnDateMinLessOne()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = "20/03/2017";
            string Return = "19/03/2017";
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ReturnDateMinBoundary()
        {
            // create an instance of the class we want to create
            clsDestination ADestination = new clsDestination();
            // boolean variable to store the result of the validation
            Boolean OK = false;
            // create test data to assign to the property
            string Destination = "Dubai";
            decimal Price = 100000;
            string Flight = Convert.ToString(DateTime.Now.Date);
            string Return = Convert.ToString(DateTime.Now.Date.AddDays(1));
            // execute the method
            OK = ADestination.Valid(Destination, Price, Flight, Return);
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

