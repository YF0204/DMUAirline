using System;

namespace ClassLibrary
{
    public class clsDestination
    {
        // private data member for the DestinationID property
        private Int32 mDestinationID;
        // private data member for the DestinationName property
        private string mDestination;
        // private data member for the PricePerPerson property
        private decimal mPricePerPerson;

        // public property for the DestinationName
        public string Destination
        {
            get
            {
                // return the private data
                return mDestination;
            }
            set
            {
                // set the value of the private data
                mDestination = value;
            }
        }
        
        // public property for the PricePerPerson
        public decimal PricePerPerson
        {
            get
            {
                // return the private data
                return mPricePerPerson;
            }
            set
            {
                // set the value of the private data
                mPricePerPerson = value;
            }
        }
        // public property for the Destination ID
        public int DestinationID
        {
            get
            {
                // return the private data
                return mDestinationID;
            }
            set
            {
                // set the value of the private data
                mDestinationID = value;
            }
        }
        
        public bool Valid(string destination, decimal price)
        {
            //boolean flag to indicate that everything is ok
            Boolean Ok = true;
            // check if the name of the destination is blank
            if (destination == "")
            {
                //flag an error
                Ok = false;
            }
            // check if the name of the destination is more than 100 characters 
            if (destination.Length > 100)
            {
                //flag an error
                Ok = false;
            }
            // check if the price per person is below or equal to a penny
            if (price <= 0.01m)
            {
                // flag an error
                Ok = false;
            }
            // return Ok
            return Ok;
            }
        
        // public find method for destinations
        public bool Find(int destinationID)
        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the destination ID
            DB.AddParameter("@DestinationID", destinationID);
            // execute the stored procedure
            DB.Execute("sproc_tblDestination_FilterByDestinationID");
            // if one record is found 
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mDestinationID = Convert.ToInt32(DB.DataTable.Rows[0]["DestinationID"]);
                mDestination = Convert.ToString(DB.DataTable.Rows[0]["DestinationName"]);
                mPricePerPerson = Convert.ToDecimal(DB.DataTable.Rows[0]["PricePerPerson"]);
                // return that everything worked
                return true;
            }
            // if no record was found
            else
            {
                // return false
                return false;
            }
        }
    }
}
