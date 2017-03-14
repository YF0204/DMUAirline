using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDestinationCollection
    {

        // constructor for the class
        public clsDestinationCollection()
        {
            // onject for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblDestination_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB); 
        }

        // private data member for the list
        List<clsDestination> mDestinationList = new List<clsDestination>();
        // private data member for ThisDestination
        clsDestination mThisDestination = new clsDestination();
        // public property for ThisDestination
        public clsDestination ThisDestination
        {
            get
            {
                // return the private data
                return mThisDestination;
            }
            set
            {
                // set the private data
                mThisDestination = value;
            }
        }
        // public property for count
        public int Count
        {
            get
            {
                // return the count of the list
                return mDestinationList.Count;
            }
            set
            {
                // amend this later
            }
        }
        // public property for the destination list
        public List<clsDestination> DestinationList
        {
            get
            {
                // return the private data
                return mDestinationList;
            }
            set
            {
                // set the private data
                mDestinationList = value;
            }
        }

        public int Add()
        {
            // this method adds a new destination to the database
            // connect to the data connection class
            clsDataConnection DB = new clsDataConnection();
            // set the parameters
            DB.AddParameter("@DestinationName", mThisDestination.Destination);
            DB.AddParameter("@PricePerPerson", mThisDestination.PricePerPerson);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblDestination_Insert");
        }

        public void Update()
        {
            // update an existing record based on the value of ThisDestination
            // connect to the data connection class
            clsDataConnection DB = new clsDataConnection();
            // set the parameters
            DB.AddParameter("@DestinationID", mThisDestination.DestinationID);
            DB.AddParameter("@DestinationName", mThisDestination.Destination);
            DB.AddParameter("@PricePerPerson", mThisDestination.PricePerPerson);
            // execute the stored procedure
            DB.Execute("sproc_tblDestination_Update");
        }

        public void FilterByDestination(string Destination)
        {
            // filters the records based on destination
            // connect to data connection class
            clsDataConnection DB = new clsDataConnection();
            // send the destination parameter to the database
            DB.AddParameter("@DestinationName", Destination);
            // execute the stored procedure
            DB.Execute("sproc_tblDestination_FilterByDestination");
            // populate the array list with the data table
            PopulateArray(DB); 
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mDestinationList = new List<clsDestination>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank address
                clsDestination Destination = new clsDestination();
                // read in the fields from the current record
                Destination.DestinationID = Convert.ToInt32(DB.DataTable.Rows[Index]["DestinationID"]);
                Destination.Destination = Convert.ToString(DB.DataTable.Rows[Index]["DestinationName"]);
                Destination.PricePerPerson = Convert.ToDecimal(DB.DataTable.Rows[Index]["PricePerPerson"]);
                // add the record to private data member
                mDestinationList.Add(Destination);
                // increment the index
                Index++;
            }
        }
    }
}