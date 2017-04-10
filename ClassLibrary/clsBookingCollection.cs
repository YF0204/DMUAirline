using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsBookingCollection
    {
        // constructor for the clas
        public clsBookingCollection()
        {
            // var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount = 0;
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblBooking_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank booking
                clsBooking ABooking = new clsBooking();
                // read in all the fields from the current record
                ABooking.BookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingID"]);
                ABooking.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                ABooking.BookingApproved = Convert.ToBoolean(DB.DataTable.Rows[Index]["BookingApproved"]);
                ABooking.DestinationID = Convert.ToInt32(DB.DataTable.Rows[Index]["DestinationID"]);
                // add the record to the private data member
                mBookingList.Add(ABooking);
                // go to next record
                Index++;
            }

        }
        // private data member for the list
        List<clsBooking> mBookingList = new List<clsBooking>();
        // public property for the BookingList
        public List<clsBooking> BookingList
        {
            get
            {
                // return the private data
                return mBookingList;
            }
            set
            {
                // set the value of the private data
                mBookingList = value;
            }
        }
        // public propery for Count
        public int Count
        {
            get
            {
                // return the count of the list
                return mBookingList.Count;
            }
            set
            {
                // to do later
            }
        }
        public clsBooking ThisBooking { get; set; }
    }
}