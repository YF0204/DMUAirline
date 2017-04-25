using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibrary
{
    [TestClass]
    public class tstcarparkCollection
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCarPark);
        }
        [TestMethod]
        public void CarParkReservationOk()
        {
            //create an instance of the class we want to create
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //create  some test data  to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCarPark> TestList = new List<clsCarPark>();
            //add an item to the list
            //create the item of test data
            clsCarPark TestItem = new clsCarPark();
            //set its properties
            TestItem.carparkid = 1;
            TestItem.CarReg = "DEO3 CHO";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.EndDate = DateTime.Now.Date;
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Location = "B2";
            //add  the item to the list
            TestList.Add(TestItem);
            //assign the data  To property
            AllCarPark.CarParkList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCarPark.CarParkList, TestList);
        }
        [TestMethod]
        public void CarParkAddMethodOk()
        {
            //create an instance of the class we want to create
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //create the item of test data
            clsCarPark TestItem = new clsCarPark();
            // car to store the rpimary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.carparkid = 20;
            TestItem.CarReg = "hiup b4u";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.EndDate = DateTime.Now.Date;
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Location = "B3";
            //set thiscar park to the test data 
            AllCarPark.ThisCarPark = TestItem;
            //add the record
            PrimaryKey = AllCarPark.Add();
            // set the primary key of the data
            TestItem.carparkid = PrimaryKey;
            //find the record
            AllCarPark.ThisCarPark.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCarPark.ThisCarPark, TestItem);
        }

        [TestMethod]
        public void CarParkDeleteMethodOk()
        {
            //create an instance of the class we want to create
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //create the item of test data
            clsCarPark TestItem = new clsCarPark();
            // car to store the rpimary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.carparkid = 3;
            TestItem.CarReg = "hiup b4u";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.EndDate = DateTime.Now.Date;
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Location = "B3";
            //set thiscar park to the test data 
            AllCarPark.ThisCarPark = TestItem;
            //add the record
            PrimaryKey = AllCarPark.Add();
            // set the primary key of the data
            TestItem.carparkid = PrimaryKey;
            //find the record
            AllCarPark.ThisCarPark.Find(PrimaryKey);
            //delete the record 
            AllCarPark.Delete();
            //now find the record
            Boolean Found = AllCarPark.ThisCarPark.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void CarParkUpdateMethodOk()
        {
            //create an instance of the class we want to create
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //create the item of test data
            clsCarPark TestItem = new clsCarPark();
            // car to store the rpimary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.carparkid = 3;
            TestItem.CarReg = "hiup b4u";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.EndDate = DateTime.Now.Date;
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Location = "B3";
            //set thiscar park to the test data 
            AllCarPark.ThisCarPark = TestItem;
            //add the record
            PrimaryKey = AllCarPark.Add();
            // set the primary key of the data
            TestItem.carparkid = PrimaryKey;
            //modify the test data
            TestItem.carparkid = 3;
            TestItem.CarReg = "hCPp b9u";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.EndDate = DateTime.Now.Date;
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Location = "B7";
            //set thiscar park to the test data 
            AllCarPark.ThisCarPark = TestItem;
            //update the record
            AllCarPark.Update();
            //find the record
            AllCarPark.ThisCarPark.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCarPark.ThisCarPark, TestItem);
        }

        [TestMethod]
        public void FilterByCarRegMethodOk()
        {
            //create an innstance of the class containing unfiltered results
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //create  an instance of the filtered data
            clscarparkCollection FilteredCarReg = new clscarparkCollection();
            //apply a blank string(should return all records)
            FilteredCarReg.FilterByCarReg("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllCarPark.Count, FilteredCarReg.Count);
        }
        [TestMethod]
        public void FilterByCarRegNoneFound()
        {
            //create an instance of the filtered data
            clscarparkCollection FillteredCarReg = new clscarparkCollection();
            //apply a carreg that doesnt exits
            FillteredCarReg.FilterByCarReg("aaa aaa");
            //test to see that there are no records found
            Assert.AreEqual(0, FillteredCarReg.Count);
        }

        [TestMethod]
        public void CarParklistandcountOk()
        {
            //create an instance of the class we want to create 
            clscarparkCollection AllCarPark = new clscarparkCollection();
            //create some test data to assign to the protery 
            //in this case the data needs to be a list of objects
            List<clsCarPark> TestList = new List<clsCarPark>();
            //add an item to the list
            //create the item of the test data
            clsCarPark TestItem = new clsCarPark();
            //set its properties 
            TestItem.carparkid = 2;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.CarReg = "";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.EndDate = DateTime.Now.Date;
            TestItem.Location = "";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCarPark.CarParkList = TestList;
            //test to see that the two values  are the same
            Assert.AreEqual(AllCarPark.Count, TestList.Count);
        }

        [TestMethod]
        public void FilterbyCarParktestDataFound()
        {
            //create an instance of the class we want to create 
            clscarparkCollection FilterCarRegs = new clscarparkCollection();
            //var to store outcome
            Boolean Ok = true;
            //apply a car reg that doesnt exit
            FilterCarRegs.FilterByCarReg("bbgg ttt");
            //check that the coorect number of records are found
            if (FilterCarRegs.Count == 2)
            {
                //check that the first record is id 1 
                if (FilterCarRegs.CarParkList[0].carparkid != 151)
                {
                    Ok = false;
                }
                //check that the first record  is id 2
                if (FilterCarRegs.CarParkList[1].carparkid != 152)
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
