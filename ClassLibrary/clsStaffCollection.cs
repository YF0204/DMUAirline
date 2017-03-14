using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        // public constructor for the class
        public clsStaffCollection()
        {
            // object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mStaffList = new List<clsStaff>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank address
                clsStaff AMember = new clsStaff();
                // read in all the fields from the current record
                AMember.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AMember.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AMember.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AMember.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AMember.StaffContactNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffContactNo"]);
                AMember.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                AMember.StaffDateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateJoined"]);
                AMember.StaffPostCode = Convert.ToString(DB.DataTable.Rows[Index]["StaffPostCode"]);
                AMember.StaffEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmailAddress"]);
                // add the record to the private data member
                mStaffList.Add(AMember);
                // move to next record
                Index++;
            }

        }

        // public property for Count
        public int Count
        {
            get
            {
                // return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // amend this later
            }
        }
        // public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                // return the private data
                return mStaffList;
            }
            set
            {
                // set the private data
                mStaffList = value;
            }
        }
        // public property for ThisMember
        public clsStaff ThisMember
        {
            get
            {
                // return the private data
                return mThisMember;
            }
            set
            {
                // set the private data
                mThisMember = value;
            }
        }
        // private data member for the staff list
        List<clsStaff> mStaffList = new List<clsStaff>();
        // private data member for the list
        clsStaff mThisMember = new clsStaff();

        public int Add()
        {
            // adds a new staff record to the system
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffFirstName", mThisMember.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisMember.StaffLastName);
            DB.AddParameter("@StaffAddress", mThisMember.StaffAddress);
            DB.AddParameter("@StaffContactNo", mThisMember.StaffContactNo);
            DB.AddParameter("@StaffDOB", mThisMember.StaffDOB);
            DB.AddParameter("@StaffDateJoined", mThisMember.StaffDateJoined);
            DB.AddParameter("@StaffPostCode", mThisMember.StaffPostCode);
            DB.AddParameter("@StaffEmailAddress", mThisMember.StaffEmailAddress);
            // execute the stored procedure and return the new PK value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // update an existing record based on the value of ThisMember
            // connect to the data connection class
            clsDataConnection DB = new clsDataConnection();
            // set the parameters
            DB.AddParameter("@StaffID", mThisMember.StaffID);
            DB.AddParameter("@StaffFirstName", mThisMember.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisMember.StaffLastName);
            DB.AddParameter("@StaffAddress", mThisMember.StaffAddress);
            DB.AddParameter("@StaffContactNo", mThisMember.StaffContactNo);
            DB.AddParameter("@StaffDOB", mThisMember.StaffDOB);
            DB.AddParameter("@StaffDateJoined", mThisMember.StaffDateJoined);
            DB.AddParameter("@StaffPostCode", mThisMember.StaffPostCode);
            DB.AddParameter("@StaffEmailAddress", mThisMember.StaffEmailAddress);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void FilterByStaffLastName(string StaffLastName)
        {
            // filters the records based on the last name of the staff member
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the parameter to the database
            DB.AddParameter("@StaffLastName", StaffLastName);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffLastName");
            // populate the array list with the data table
            PopulateArray(DB);
        }
    }
}