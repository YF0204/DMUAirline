using System;

namespace MyClassLibrary
{
    public class clsAirline
    {
        //private data member for the ContractID
        private Int32 mContactID;
        //private data member for the AirlineName
        private String mAirlineName;
        //private data member for the AirlineContactNumber
        private String mAirlineContactNumber;
        //private data member for the Destination
        private String mDestinations;
        //private data member for the CostOfContract
        private Decimal mContractCost;
        //private data member for the StartDate
        private DateTime mStartDate;
        //private data member for the EndDate
        private DateTime mEndDate;

        public int ContractID
        {
            get
            {
                // return the private data
                return mContactID;
            }
            set
            {
                // set the value of the private data member
                mContactID = value;
            }
        }
        public string AirlineName
        {
            get
            {
                // return the private data
                return mAirlineName;
            }
            set
            {
                // set the value of the private data member
                mAirlineName = value;
            }
        }
        public string AirlineContactNumber
        {
            get
            {
                // return the private data
                return mAirlineContactNumber;
            }
            set
            {
                // set the value of the private data member
                mAirlineContactNumber = value;
            }
        }

        public string Destinations
        {
            get
            {
                // return the private data
                return mDestinations;
            }
            set
            {
                // set the value of the private data member
                mDestinations = value;
            }
        }
        public decimal ContractCost
        {
            get
            {
                // return the private data
                return mContractCost;
            }
            set
            {
                // set the value of the private data member
                mContractCost = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                // return the private data
                return mStartDate;
            }
            set
            {
                // set the value of the private data member
                mStartDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                // return the private data
                return mEndDate;
            }
            set
            {
                // set the value of the private data member
                mEndDate = value;
            }
        }
        public bool Find(int ContractID)
        {
            // CREATE AN INSTANCE OF THE DATA CONNECTION
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the ContractID to search for
            DB.AddParameter("@ContractID", ContractID);
            // execute the stored procedure
            DB.Execute("sproc_tblAirlineContract_FilterByContractID");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy data from the database to the private data members
                mContactID = Convert.ToInt32(DB.DataTable.Rows[0]["ContractID"]);
                mAirlineName = Convert.ToString(DB.DataTable.Rows[0]["Airline Name"]);
                mAirlineContactNumber = Convert.ToString(DB.DataTable.Rows[0]["Airline Contact NUmber"]);
                mDestinations = Convert.ToString(DB.DataTable.Rows[0]["Main Destinations"]);
                mContractCost = Convert.ToDecimal(DB.DataTable.Rows[0]["Contract Cost"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Contract Start Date"]);
                mEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Contract End Date"]);
                //return that every thing was ok
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
                                 
            
        }

        public bool Valid(string airlineName, string airlineContactNumber, DateTime contractStartDate, DateTime contractEndDate, decimal contractCost, string mainDestinations)
        {
            // create a bolean variable to flag the error
            Boolean OK = true;
            // if airline name is 4 chars
            if (airlineName.Length < 5)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (airlineName.Length > 20)
            {
                // set the flag OK to false
                OK = false;
            }

            if (airlineContactNumber.Length < 11)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (airlineContactNumber.Length > 15)
            {
                // set the flag OK to false
                OK = false;
            }

           
            if (mainDestinations.Length <5)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (mainDestinations.Length > 20)
            {
                // set the flag OK to false
                OK = false;
            }

            string cost = contractCost.ToString();

            if (cost.Length < 4)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (cost.Length > 7)
            {
                // set the flag OK to false
                OK = false;
            }

            //return the value of OK
            return OK;
        }
    }
}