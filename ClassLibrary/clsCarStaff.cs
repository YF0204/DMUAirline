using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCarStaff
    {
        // private data member for the StaffNo
        private Int32 mStaffNo;
        //private data member for Staff Address
        private string mStaffAddress;
        // private data member for the  Staff Email
        private string mStaffEmail;
        // private data member for the Staff Name
        private string mStaffName;
        // private data member for the staff phone Number
        private string mStaffPhoneNumber;


        public string StaffAddress
        {
            get
            {
                return mStaffAddress;
            }
                set
            {
                mStaffAddress = value;
            }
                }
        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
         }
        public Int32 StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
         }
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
             set
            {
                mStaffName = value;
            } 
          }
        public string StaffPhoneNumber
        {
            get
            {
                return mStaffPhoneNumber;
            }
             set
            {
                mStaffPhoneNumber = value;
            } 
                }

        public bool Valid(string staffAddress, string staffEmail, string staffName, string staffPhoneNumber)
        {
            //create  a boolean  a variable  to flag the error
            Boolean OK = true;

            if(staffAddress.Length == 4)
            {
                OK = false;
            }
            if(staffAddress.Length > 20)
            {
                OK = false;
            }
            if(staffEmail.Length == 12)
            {
                OK = false;
            }
            if(staffEmail.Length > 254)
            {
                OK = false;
            }
            if(staffName.Length == 2)
            {
                OK = false;
            }
            if(staffName.Length > 35)
            {
                OK = false;
            }
            if(staffPhoneNumber.Length == 10)
            {
                OK = false;
            }
            if(staffPhoneNumber.Length > 13)
            {
                OK = false;
            }
            return OK;
        }

        public bool Find(int staffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the StaffNo to reasearch for
            DB.AddParameter("@StaffNo", staffNo);
            //excute the stored procedure 
            DB.Execute("SPROC_tbl_CarStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
                {
                //return false indicating a problem
                return false;
            }
        }
    }
}