using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // private data member for the StaffID property
        private Int32 mStaffID;
        // private data member for the StaffFirstName property
        private string mStaffFirstName;
        // private data member for the StaffLastName property
        private string mStaffLastName;
        // private data member for the StaffAddress property
        private string mStaffAddress;
        // private data member for the StaffContactNo property
        private string mStaffContactNo;
        // private data member for the StaffPostCode property
        private string mStaffPostCode;
        // private data member for the StaffDOB property
        private DateTime mStaffDOB;
        // private data member for the StaffDateJoined property
        private DateTime mStaffDateJoined;
        // private data member for the StaffEmailAddress property
        private string mStaffEmailAddress;

        // public property for the staff ID
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

        // public property for the staff first name
        public string StaffFirstName
        {
            get
            {
                // return the private data
                return mStaffFirstName;
            }
            set
            {
                // set the value of the private data member
                mStaffFirstName = value;
            }
        }

        // public property for the staff last name
        public string StaffLastName
        {
            get
            {
                // return the private data
                return mStaffLastName;
            }
            set
            {
                // set the value of the private data member
                mStaffLastName = value;
            }
        }

        // public property for the staff address
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

        // public property for the staff contact no
        public string StaffContactNo
        {
            get
            {
                // return the private data
                return mStaffContactNo;
            }
            set
            {
                // set the value of the private data member
                mStaffContactNo = value;
            }
        }

        // public property for the staff DOB
        public DateTime StaffDOB
        {
            get
            {
                // return the private data
                return mStaffDOB;
            }
            set
            {
                // set the value of the private data member
                mStaffDOB = value;
            }
        }

        // public property for the staff date joined
        public DateTime StaffDateJoined
        {
            get
            {
                // return the private data
                return mStaffDateJoined;
            }
            set
            {
                // set the value of the private data member
                mStaffDateJoined = value;
            }
        }

        // public property for the staff email address
        public string StaffEmailAddress
        {
            get
            {
                // return the private data
                return mStaffEmailAddress;
            }
            set
            {
                // set the value of the private data member
                mStaffEmailAddress = value;
            }
        }

        // public property for the staff postcode
        public string StaffPostCode
        {
            get
            {
                // return the private data
                return mStaffPostCode;
            }
            set
            {
                // set the value of the private data member
                mStaffPostCode = value;
            }
        }

        public bool Valid(string first, string last, string address, string email, string postCode, string contactNo, string dOB, string dateJoined)
        {
            // create a boolean variable to flag the error
            Boolean OK = true;
            // temp variable to store date of birth values
            DateTime DOBTemp;
            // temp variable to store date joined values
            DateTime DateTemp;
            // if the first name is blank
            if (first.Length == 0)
            {
                // flag the error
                OK = false;
            }
            if (first.Length > 50)
            {
                // flag the error
                OK = false;
            }
            if (last.Length == 0)
            {
                // flag the error
                OK = false;
            }
            if (last.Length > 50)
            {
                // flag the error
                OK = false;
            }
            if (address.Length == 0)
            {
                // flag the error
                OK = false;
            }
            if (address.Length > 100)
            {
                // flag the error
                OK = false;
            }
            if (contactNo.Length != 11)
            {
                // flag the error
                OK = false;
            }
            if (postCode.Length == 0)
            {
                // flag the error
                OK = false;
            }
            if (postCode.Length > 9)
            {
                // flag the error
                OK = false;
            }
            if (email.Length == 0)
            {
                // flag the error
                OK = false;
            }
            if (email.Length > 254)
            {
                // flag the error
                OK = false;
            }
            if (!email.Contains("@"))
            {
                // flag the error
                OK = false;
            }
            try
            {
                // copy the DOB value to the dateTemp variable
                DOBTemp = Convert.ToDateTime(dOB);
                DateTime TestDate;
                // check the date to see if greater than 16 years old
                TestDate = DateTime.Now.Date.AddYears(-16);
                TestDate = DateTime.Now.Date.AddDays(1);
                // if the new staff member is below 16 years old
                if (DOBTemp > TestDate)
                {
                    // flag the error
                    OK = false;
                }
            }
            // if the data isn't a date flag as an error
            catch
            {
                OK = false;
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateJoined);
            }
            //{
            // copy the DateJoined value to the DateTemp variable
            //DateTemp = Convert.ToDateTime(dateJoined);
            // check to see if the date is less than today
            //if (DateTemp < DateTime.Now.Date)
            //{
            // flag an error
            //OK = false;
            //}
            // check to see if the date is greater than today
            //if (DateTemp > DateTime.Now.Date)
            //{
            // flag an error
            // OK = false;
            // }
            //} 
            catch
            {
                OK = false;
            }
            return OK;
        }

        public bool Find(int StaffID)
        {
            // create an instance of the clsDataConnection class
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the staff ID to search for
            DB.AddParameter("@StaffID", StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            // if one record is found
            if (DB.Count == 1)
            {
                // copy thr data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffContactNo = Convert.ToString(DB.DataTable.Rows[0]["StaffContactNo"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mStaffDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateJoined"]);
                mStaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["StaffPostCode"]);
                mStaffEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffEmailAddress"]);
                // return that everything worked ok
                return true;
            }
            // if no record was found
            else
            {
                // return false if there is a problem
                return false;
            }
        }
    }
}