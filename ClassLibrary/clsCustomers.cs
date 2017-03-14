using System;

namespace MyClassLibrary
{
    public class clsCustomers
    {
        //private data member for the customner no
        private Int32 mCustomerNo;
        //private data member for the FirstName
        private string mFirstName;
        //private data member for the surname
        private string mSurname;
        //private data member for the Address1
        private string mAddress1;
        //private data member for the address2
        private string mAddress2;
        //private data member for the Postcode
        private string mPostcode;
        //private data member for the PhoneNumber
        private string mPhoneNumber;
        //private data member for the Email
        private string mEmail;

        public string Address1
        {
            get
            {
                return mAddress1;
            }

            set
            {
                mAddress1 = value;
            }
        }
        public string Address2
        {
            get
            {
                return mAddress2;
            }
            set
            {
                mAddress2 = value;
            }
        }


        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }
        public string Surname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }

        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }

        public bool Valid(string firstName, string surname, string address1, string address2, string postcode, string phonenumber, string email)
        {
            {
                //boolean flag to indicate that all is ok
                Boolean Ok = true;
                //if the name of the customer is blank
                if (firstName.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (firstName.Length < 5)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (firstName.Length > 35)
                {
                    //flag an error
                    Ok = false;
                }
                if (surname.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (surname.Length < 5)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (surname.Length > 35)
                {
                    //flag an error
                    Ok = false;
                }
                if (address1.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (address1.Length < 14)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (address1.Length > 50)
                {
                    //flag an error
                    Ok = false;
                }
                if (address2.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (address2.Length < 14)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (address2.Length > 50)
                {
                    //flag an error
                    Ok = false;
                }
                if (postcode.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (postcode.Length < 6)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (postcode.Length > 8)
                {
                    //flag an error
                    Ok = false;
                }
                if (phonenumber.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (phonenumber.Length < 11)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (phonenumber.Length > 12)
                {
                    //flag an error
                    Ok = false;
                }
                if (email.Length == 0)
                {
                    //flag an error
                    Ok = false;

                }
                if (email.Length < 15)
                {
                    Ok = false;
                }
                //if the name of the county is more than 50 characters 
                if (email.Length > 254)
                {
                    //flag an error
                    Ok = false;
                }

                return Ok;
            }
        }

        public bool Find(int customerNo)
        {
            //create an instance of the data conection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no we want to search for 
            DB.AddParameter("@CustomerNo", customerNo);
            //execute the stored procedure
            DB.Execute("sproc_Customerlist_FilterByCustomerNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mAddress1 = Convert.ToString(DB.DataTable.Rows[0]["Address1"]);
                mAddress2 = Convert.ToString(DB.DataTable.Rows[0]["Address2"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //always return true
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
    




               

    

    
  
    

