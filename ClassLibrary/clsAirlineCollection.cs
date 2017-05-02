using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsAirlineCollection
    {
        //private data member for the list
        List<clsAirline> mAirlineList = new List<clsAirline>();


        public List<clsAirline> AirlineList
        {
            get
            {
                //return the private data
                return mAirlineList;
            }
            set
            {
                // set the private data
                mAirlineList = value;
            }
        }
        public int Count
        {
            get
            {
                return mAirlineList.Count;
            }
            set
            {

            }
        }
        public clsAirline ThisAirline { get; set; }


        //constructor for the class
        public clsAirlineCollection()
        {
            // var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAirlineContract_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while ther are records to proccess
            while (Index < RecordCount)
            {
                // create a bland airline
                clsAirline AnAirline = new clsAirline();
                //read in the feilds from the curent record
                AnAirline.ContractID = Convert.ToInt32(DB.DataTable.Rows[Index]["ContractID"]);
                AnAirline.AirlineName = Convert.ToString(DB.DataTable.Rows[Index]["Airline Name"]);
                AnAirline.AirlineContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["Airline Contact Number"]);
                AnAirline.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Contract Start Date"]);
                AnAirline.EndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Contract End Date"]);
                AnAirline.Destinations = Convert.ToString(DB.DataTable.Rows[Index]["Main Destinations"]);
                AnAirline.ContractCost = Convert.ToDecimal(DB.DataTable.Rows[Index]["Contract Cost"]);
                // add the recor to the rpivate data member
                mAirlineList.Add(AnAirline);
                //point to the next record
                Index++;
            }
        }
    }
}