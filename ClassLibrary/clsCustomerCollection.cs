using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomers> mCustomerList = new List<clsCustomers>();
        //private data member this customer
        clsCustomers mThisCustomer = new clsCustomers();
        public List<clsCustomers> CustomerList
        {
            get
            {
                //return the private data 
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public property for count


        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomers ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }



        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@Surname", mThisCustomer.Surname);
            DB.AddParameter("@Address1", mThisCustomer.Address1);
            DB.AddParameter("@Address2", mThisCustomer.Address2);
            DB.AddParameter("@Postcode", mThisCustomer.Postcode);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Email", mThisCustomer.Email);
            //execute the query returning the primary key value
            return DB.Execute("sproc_CustomerList_insert");
        }

        public void Update()
        {

            {
                //update an existing record based on the values of thisCustomer
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
                DB.AddParameter("@FirstName", mThisCustomer.FirstName);
                DB.AddParameter("@Surname", mThisCustomer.Surname);
                DB.AddParameter("@Address1", mThisCustomer.Address1);
                DB.AddParameter("@Address2", mThisCustomer.Address2);
                DB.AddParameter("@Postcode", mThisCustomer.Postcode);
                DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
                DB.AddParameter("@Email", mThisCustomer.Email);
                //execute the stored procedure
                DB.Execute("sproc_CustomerList_Update");
            }
        }

        public void FilterBySurname(string Surname)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Surname", Surname);
            //execute the stored procedure
            DB.Execute("sproc_CustomerList_FilterBySurname");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_CustomerList_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        private void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomers>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomers AnCustomer = new clsCustomers();
                //read in the fields from the current record
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AnCustomer.Address1 = Convert.ToString(DB.DataTable.Rows[Index]["Address1"]);
                AnCustomer.Address2 = Convert.ToString(DB.DataTable.Rows[Index]["Address2"]);
                //add the record to the private data mamber
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }

        }
    }
}
    


           
        
        
































































