using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCarStaffCollection
    {

        public clsCarStaffCollection()
        {
            // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("Sproc_tblCarStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        // private data member for the list
        List<clsCarStaff> mCarStaffList = new List<clsCarStaff>();
        //private data member ThisCarPark
        clsCarStaff mThisCarStaff = new clsCarStaff();
        public List<clsCarStaff> StaffList
        {
            get
            {
                //return the private Data
                return mCarStaffList;
            }
            set
            {
                //set the private data
                mCarStaffList = value;
            }
                }
        public int Count
        {
            get
            {
                return mCarStaffList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCarStaff ThisStaff
        {
            get
            {
                return mThisCarStaff;
            }
             set
            {
                mThisCarStaff = value;
            }
                }

        public int Add()
        {
            //Adds a new record to the database based on the values of mThisCarPark
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for  the stored procedure
            DB.AddParameter("@StaffAddress", mThisCarStaff.StaffAddress);
            DB.AddParameter("@StaffName", mThisCarStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisCarStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisCarStaff.StaffPhoneNumber);
            //excute the query returning the primary key value
            return DB.Execute("SPROC_tblCarStaff_Insert");
        }
        public void Delete()
        {
            //deletes the record point to by the thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@StaffNo", mThisCarStaff.StaffNo);
            //excute the stored procedure
            DB.Execute("SPROC_tblCarStaff_Delete");
        }
        public void Update()
        {
            // update an existing record based on the values of this carpark
            // connect the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@StaffNo", mThisCarStaff.StaffNo);
            DB.AddParameter("@StaffAddress", mThisCarStaff.StaffAddress);
            DB.AddParameter("@StaffName", mThisCarStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisCarStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisCarStaff.StaffPhoneNumber);
            //excute the stored procedur
            DB.Execute("SPROC_tblCarStaff_Update");



        }

        public void FilterByStaffName(string StaffName)
        {
            
            //filter the records based on a full or partial First Name
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the carreg parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //excute the stored procedure
            DB.Execute("Sproc_tblCarStaff_FilterByFirstName");
            //populate the arraylist with data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table on the parameter DB
            //var for the index
            Int32 Index = 0;
            //Var to store  the record count
            Int32 RecordCount;
            //get the count of the record
            RecordCount = DB.Count;
            //clear the private array list
            mCarStaffList = new List<clsCarStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank record
                clsCarStaff acarStaff = new clsCarStaff();
                // read in the fields  from the current record
                acarStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                acarStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                acarStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                acarStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                //add the record to the private data member
                mCarStaffList.Add(acarStaff);
                //point at the next record
                Index++;
            }
        }
    }
}