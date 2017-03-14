using System;
using System.Collections.Generic;

namespace ClassLibrary
{

   // public clscarparkCollection()
    public class clscarparkCollection
    {
        
        public clscarparkCollection()
        {
           // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("Sproc_tblCarParkReservation_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        // private data member for the list
        List<clsCarPark> mCarParkList = new List<clsCarPark>();
        //private data member ThisCarPark
        clsCarPark mThisCarPark = new clsCarPark();

        public List<clsCarPark> CarParkList
        {
            get
            {
                //return the private Data
                return mCarParkList;
            }
            set
            {
                //set the private data
                mCarParkList = value;
            }
          }
        public int Count
        {
            get
            {
                return mCarParkList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsCarPark ThisCarPark
        {
            get
            {
                //return the private data
                return mThisCarPark;
            }
                set
            {
                //set the private data
                mThisCarPark = value;
            }
         }
        public int Add()
        {
            //Adds a new record to the database based on the values of mThisCarPark
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for  the stored procedure
            DB.AddParameter("@BookingDate", mThisCarPark.BookingDate);
            DB.AddParameter("@CarReg", mThisCarPark.CarReg);
            DB.AddParameter("@StartDate", mThisCarPark.StartDate);
            DB.AddParameter("@EndDate", mThisCarPark.EndDate);
            DB.AddParameter("@Location", mThisCarPark.Location);
            //excute the query returning the primary key value
            return DB.Execute("SPROC_tblCarParkReservation_Insert");
        }

        public void Delete()
        {
            //deletes the record point to by the thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CarParkId", mThisCarPark.carparkid);
            //excute the stored procedure
            DB.Execute("SPROC_tblCarParkReservation_Delete");
        }
        public void Update()
        {
            // update an existing record based on the values of this carpark
            // connect the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CarParkId", mThisCarPark.carparkid);
            DB.AddParameter("@CarReg", mThisCarPark.CarReg);
            DB.AddParameter("@BookingDate", mThisCarPark.BookingDate);
            DB.AddParameter("@StartDate", mThisCarPark.StartDate);
            DB.AddParameter("@EndDate", mThisCarPark.EndDate);
            DB.AddParameter("@Location", mThisCarPark.Location);
            //excute the stored procedur
            DB.Execute("SPROC_tblCarParkReservation_Update");



        }

        public void FilterByCarReg(string CarReg)
        {
            //filter the records based on a full or partial CarReg
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the carreg parameter to the database
            DB.AddParameter("@CarReg", CarReg);
            //excute the stored procedure
            DB.Execute("Sproc_tblCarParkReservation_FilterByCarReg");
            //populate the arraylist with data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table on the parameter DB
            //var for the index
            Int32 Index = 0;
            //Var to store  the record count
            Int32 RecordCount;
            //get the count of the record
            RecordCount = DB.Count;
            //clear the private array list
            mCarParkList = new List<clsCarPark>();
            //while there are records to process
            while (Index < RecordCount) 
            {
                //create a blank record
                clsCarPark acarpark = new clsCarPark();
                // read in the fields  from the current record
                acarpark.carparkid = Convert.ToInt32(DB.DataTable.Rows[Index]["CarParkId"]);
                acarpark.BookingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BookingDate"]);
                acarpark.CarReg = Convert.ToString(DB.DataTable.Rows[Index]["CarReg"]);
                acarpark.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                acarpark.EndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EndDate"]);
                acarpark.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                //add the record to the private data member
                mCarParkList.Add(acarpark);
                //point at the next record
                Index++;
            }
        }
   
    }
}

