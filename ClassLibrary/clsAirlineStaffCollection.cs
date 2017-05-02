using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                // set the private data
                mStaffList = value;
            }
        }
        public clsStaff ThisStaff { get; set; }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }


        public clsStaffCollection()
        {
            // var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAirlineStaff_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while ther are records to proccess
            while (Index < RecordCount)
            {
                // create a bland airline
                clsStaff AnStaff = new clsStaff();
                //read in the feilds from the curent record
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["Staff Name"]);
                AnStaff.StaffContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["Staff Contact Number"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["Staff Email"]);
                AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["Staff Address"]);
                // add the recor to the rpivate data member
                mStaffList.Add(AnStaff);
                //point to the next record
                Index++;
            }
        }
    }
}

