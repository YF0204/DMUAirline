 using System;

namespace ClassLibrary
{
    public class clsDestination
    {
        // private data member for the DestinationID property
        private Int32 mDestinationID;
        // private data member for the DestinationName property
        private string mDestination;
        // private data member for the PricePerPerson property
        private decimal mPricePerPerson;
        // private data member for the DayOfFlight property
        private DateTime mDayOfFlight;
        // private data member for the ReturnDate property
        private DateTime mReturnDate;

        public string FullDetails
        {
            get
            {
                return mDestination + " " + mPricePerPerson;
            }
        }

        // public property for the DestinationName
        public string Destination
        {
            get
            {
                // return the private data
                return mDestination;
            }
            set
            {
                // set the value of the private data
                mDestination = value;
            }
        }
        
        // public property for the PricePerPerson
        public decimal PricePerPerson
        {
            get
            {
                // return the private data
                return mPricePerPerson;
            }
            set
            {
                // set the value of the private data
                mPricePerPerson = value;
            }
        }
        // public property for the Destination ID
        public int DestinationID
        {
            get
            {
                // return the private data
                return mDestinationID;
            }
            set
            {
                // set the value of the private data
                mDestinationID = value;
            }
        }
        
        // public property for DayOfFlight
        public DateTime DayOfFlight
        {
            get
            {
                // return the private data
                return mDayOfFlight;
            }
            set
            {
                // set the value of the private data
                mDayOfFlight = value;
            }
        }

        // public property for ReturnDate
        public DateTime ReturnDate
        {
            get
            {
                // return the private data
                return mReturnDate;
            }
            set
            {
                // set the value of the private data
                mReturnDate = value;
            }
        }
        public bool Valid(string destination, decimal price, string dayofflight, string returndate)
        {
            // boolean flag to indicate that everything is ok
            Boolean Ok = true;
            // temp variable to store day of flight values
            //DateTime FlightTemp;
            // temp variable to store day of flight values
            //DateTime ReturnTemp;
            // check if the name of the destination is blank
            if (destination == "")
            {
                //flag an error
                Ok = false;
            }
            // check if the name of the destination is more than 100 characters 
            if (destination.Length > 100)
            {
                //flag an error
                Ok = false;
            }
            // check if the price per person is below or equal to a penny
            if (price <= 0.01m)
            {
                // flag an error
                Ok = false;
            }
            // check if the day of flight is greater than yesterday
            //try
            //{
            //    // copy the day of flight value to the dateTemp variable
            //    FlightTemp = Convert.ToDateTime(dayofflight);
            //    DateTime TestDate;
            //    // copy the return date value to the dateTemp variable
            //    ReturnTemp = Convert.ToDateTime(returndate);
            //    DateTime TestReturnDate;
            //    // check the dates
            //    TestDate = DateTime.Now.Date.AddDays(-1);
            //    TestReturnDate = DateTime.Now.Date;
            //    // if the date is yesterday or lesser
            //    if (FlightTemp <= TestDate)
            //    {
            //        Ok = false;
            //    }
            //    // if the return date is less than the flight date
            //    if (ReturnTemp < TestReturnDate)
            //    {
            //        Ok = false;
            //    }
            //}
            //// if the date is incorrect flag an error
            //catch
            //{
            //    Ok = false;
            //}
            // return Ok
            return Ok;
            }
        
        // public find method for destinations
        public bool Find(int destinationID)
        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the destination ID
            DB.AddParameter("@DestinationID", destinationID);
            // execute the stored procedure
            DB.Execute("sproc_tblDestination_FilterByDestinationID");
            // if one record is found 
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mDestinationID = Convert.ToInt32(DB.DataTable.Rows[0]["DestinationID"]);
                mDestination = Convert.ToString(DB.DataTable.Rows[0]["DestinationName"]);
                mPricePerPerson = Convert.ToDecimal(DB.DataTable.Rows[0]["PricePerPerson"]);
                mDayOfFlight = Convert.ToDateTime(DB.DataTable.Rows[0]["DayOfFlight"]);
                mReturnDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReturnDate"]);
                // return that everything worked
                return true;
            }
            // if no record was found
            else
            {
                // return false
                return false;
            }
        }
    }
}
