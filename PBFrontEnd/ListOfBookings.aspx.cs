using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ListOfBookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // display the list of bookings made by customers
        DisplayBookings();
    }

    // function to populate list box with bookings to be processed
    Int32 DisplayBookings()
    {
        // create an instance of the booking collection
        clsBookingCollection Bookings = new clsBookingCollection();
        // var for record count
        Int32 RecordCount;
        // var for total booking price
        decimal BookingPrice;
        // var for booking approved 
        string BookingApproved;
        // var for Booking ID
        string BookingID;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing items
        lstBookings.Items.Clear();
        // get the count of records
        RecordCount = Bookings.Count;
        // loop through each record found using the index
        while (Index < RecordCount)
        {
            // get the name of the destination
            BookingPrice = Convert.ToDecimal(Bookings.BookingList[Index].TotalPrice);
            // get the price per person for each destination
            BookingApproved = Convert.ToString(Bookings.BookingList[Index].BookingApproved);
            // get the ID of each destination
            BookingID = Convert.ToString(Bookings.BookingList[Index].BookingID);
            // set up a new object of class list item
            ListItem NewItem = new ListItem(BookingPrice + " " + BookingApproved, BookingID);
            // add the item to the list
            lstBookings.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }
}