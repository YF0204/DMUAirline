using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        //private data member for the ContractID
        private Int32 mStaffID;
        //private data member for the AirlineName
        private String mStaffName;
        //private data member for the AirlineContactNumber
        private String mStaffContactNumber;
        //private data member for the Destination
        private String mStaffAddress;
        //private data member for the CostOfContract
        private String mStaffEmail;



        public int StaffID
        {
            get
            {
                // return the private data
                return mStaffID;
            }
            set
            {
                // set the value of the private data member
                mStaffID = value;
            }
        }

        public string StaffName
        {
            get
            {
                // return the private data
                return mStaffName;
            }
            set
            {
                // set the value of the private data member
                mStaffName = value;
            }
        }
        public string StaffContactNumber
        {
            get
            {
                // return the private data
                return mStaffContactNumber;
            }
            set
            {
                // set the value of the private data member
                mStaffContactNumber = value;
            }
        }
        public string StaffAddress
        {
            get
            {
                // return the private data
                return mStaffAddress;
            }
            set
            {
                // set the value of the private data member
                mStaffAddress = value;
            }
        }
        public string StaffEmail
        {
            get
            {
                // return the private data
                return mStaffEmail;
            }
            set
            {
                // set the value of the private data member
                mStaffEmail = value;
            }
        }

        public bool Find(int StaffID)
        { 
             // CREATE AN INSTANCE OF THE DATA CONNECTION
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the ContractID to search for
            DB.AddParameter("@StaffID", StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblAirlineStaff_FilterByStaffID");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //copy data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["Staff Name"]);
                mStaffContactNumber = Convert.ToString(DB.DataTable.Rows[0]["Staff Contact Number"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["Staff Address"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["Staff Email"]);
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

        public bool Valid(string staffName, string staffContactNumber, string staffAddress, string staffEmail)
        {
            // create a bolean variable to flag the error
            Boolean OK = true;
            // if airline name is 4 chars
            if (staffName.Length < 5)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (staffName.Length > 20)
            {
                // set the flag OK to false
                OK = false;
            }

            if (staffContactNumber.Length < 11)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (staffContactNumber.Length > 15)
            {
                // set the flag OK to false
                OK = false;
            }


            if (staffAddress.Length < 6)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (staffAddress.Length > 20)
            {
                // set the flag OK to false
                OK = false;
            }

            if (staffEmail.Length < 10)
            {
                // set the flag OK to false
                OK = false;
            }

            // if airline name is more than 20 characters
            if (staffEmail.Length > 25)
            {
                // set the flag OK to false
                OK = false;
            }

            //return the value of OK
            return OK;
        }
    }
}