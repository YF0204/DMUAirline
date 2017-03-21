using System;

namespace ClassLibrary
{
    public class clsCarPark
    {
        // private data member for the CarParkID
        private Int32 mCarParkID;
        // private date member for CarReg
        private string  mCarReg;
        // private data member for the Booking Date
        private DateTime mBookingDate;
        //private data member for the EndDate
        private DateTime mEndDate;
        // private data member for the location
        private string mLocation;
        //private data member for the start date 
        private DateTime mStartDate;

        //Matthew was here
        public Int32 carparkid
        {
            get
            {
                return mCarParkID;
            }
            set
            {
                mCarParkID = value;
            }
        }
        public string CarReg
        {
            get
            {
                return mCarReg;
            }
            set
            {
                mCarReg = value;
            }
        }
        public DateTime BookingDate
        {
            get
            {
                return mBookingDate;
            }
            set
            {
                mBookingDate = value;
            }

        }       
        public DateTime EndDate
        {
            get
            {
                return mEndDate;
            }
            set
            {
                mEndDate = value;
            }
        }
        public string Location
        {
            get
            {
                return mLocation;
            }
            set
            {
                mLocation = value;
            }
          }
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
                set
            {
                mStartDate = value;
            }
         }

        public bool Valid(string bookingDate, string carReg, string startDate, string endDate, string location)
        {
            //create  a boolean  a variable  to flag the error
            Boolean Ok = true;
            // create a tempory variable to store date values
            DateTime DateTemp;
            DateTime startdate;
            DateTime enddate;
            //if the carparkid  is 1
            //if (carparkid.Length == 1)
            //{
            //    //set the flag Ok to false
            //    Ok = false;
            //}
            ////if the carparkid is graeter than 4 charaters
            //if (carparkid.Length > 4)
            //{
            //    //set the flag Ok to false
            //    Ok = false;
            //}
            // try the date validation assuming the date is avlid date
            try
            {
                //copy the Bokking date value to the datetemp variable
                DateTemp = Convert.ToDateTime(bookingDate);
                startdate = Convert.ToDateTime(startDate);
                enddate = Convert.ToDateTime(endDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag Ok to false
                    Ok = false;
                }
                //check to see if the date is graeter than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag Ok to false
                    Ok = false;
                }
                if(startdate < DateTime.Now.Date)
                {
                    Ok = false;
                }
                if (startdate > DateTime.Now.AddMonths(+6))
                {
                    Ok = false;
                }
                if (enddate < DateTime.Now.Date)
                {
                    Ok = false;
                }
                if (enddate > DateTime.Now.AddMonths(+6))
                {
                    Ok = false;
                }
            }
            //the data was nota date so flag an error 
            catch
            {
                //set the falg ok to false
                Ok = false;
            }
            //is the carreg 2
            if (carReg.Length == 2)
            {
                //set the falg ok to false
                Ok = false;
            }
            //if the carreg is too long 
            if (carReg.Length > 8)
            {
                //set the falg ok to false
                Ok = false;
            }
            //is the location is 1
            if (location.Length == 1)
            {
                //set the falg ok to false
                Ok = false;
            }
            //is the location is 
            if (location.Length > 4)
            {
                Ok = false;
            }

            //return the value of ok
            return Ok;
        }

        public bool Find(int carParkID)
        {
            // create an instance of the data  connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the  carpark id  to search for
            DB.AddParameter("@CarParkId", carParkID);
            // excute the stored procedure 
            DB.Execute("SPROC_tblCarParkReservation_FilterNyCarParkId");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                //copy the data from the  database to the private data members
                mCarParkID = Convert.ToInt32(DB.DataTable.Rows[0]["CarParkId"]);
                mBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                mCarReg = Convert.ToString(DB.DataTable.Rows[0]["CarReg"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EndDate"]);
                mLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                // return that everything worked ok
                return true;
            }
            // if no record is found
            else
            {
                // return false  indicating a problem
                return false;
            }
        }
    }
}

            
