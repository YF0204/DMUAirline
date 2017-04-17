using System;

namespace ClassLibrary
{
    public class clsBooking
    {
        // private data member for the BookingID property
        private Int32 mBookingID;
        // private data member for the BookingApproved property
        private Boolean mBookingApproved;
        // private data member for the TotalPrice property
        private decimal mTotalPrice;
        // private data member for the DestinationID property
        private Int32 mDestinationID;
        // private data member for the BookingDate property
        private DateTime mBookingDate;

        // public property for the BookingApproved property
        public bool BookingApproved
        {
            get
            {
                // return the private data
                return mBookingApproved;
            }
            set
            {
                // set the value of the private data member
                mBookingApproved = value;
            }
        }
        // public property for the BookingID property
        public int BookingID
        {
            get
            {
                // return the private data
                return mBookingID;
            }
            set
            {
                // set the value of the private data member
                mBookingID = value;
            }
        }
        // public property for the TotalPrice property
        public decimal TotalPrice
        {
            get
            {
                // return the private data
                return mTotalPrice;
            }
            set
            {
                // set the value of the private data member
                mTotalPrice = value;
            }
        }

        // public property for the DestinationID foreign key
        public Int32 DestinationID
        {
            get
            {
                // return the private data
                return mDestinationID;
            }
            set
            {
                // set the value of the private data member
                mDestinationID = value;
            }
        }

        // public property for BookingDate
        public DateTime BookingDate
        {
            get
            {
                // return the private data
                return mBookingDate;
            }
            set
            {
                // set the value of the private data member
                mBookingDate = value;
            }
        }

        public bool Find(int bookingID)
        {
            // create an instance of the data connection class
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the BookingID to search for
            DB.AddParameter("@BookingID", bookingID);
            // execute the stored procedure
            DB.Execute("sproc_tblBooking_FilterByBookingID");
            // if one record is found 
            if (DB.Count == 1)
            {
                // copy the data from the table
                mBookingID = Convert.ToInt32(DB.DataTable.Rows[0]["BookingID"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mBookingApproved = Convert.ToBoolean(DB.DataTable.Rows[0]["BookingApproved"]);
                mDestinationID = Convert.ToInt32(DB.DataTable.Rows[0]["DestinationID"]);
                mBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                // return true
                return true;
            }
            else
            {
                // return false
                return false;
            }
        }
    }
}