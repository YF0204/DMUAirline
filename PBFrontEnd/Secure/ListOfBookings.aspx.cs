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
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list and display the number of records found
            lblError.Text = DisplayBookings() + " records found";
        }
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
        // var for booking date
        string BookingDate;
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
            // get the booking date of the flight
            BookingDate = Convert.ToString(Bookings.BookingList[Index].BookingDate);
            // set up a new object of class list item
            ListItem NewItem = new ListItem(BookingPrice + " " + BookingApproved + " " + BookingDate, BookingID);
            // add the item to the list
            lstBookings.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }

    // function to populate list box with bookings to be processed
    Int32 DisplayBookingsByDate()
    {
        // create an instance of the booking collection
        clsBookingCollection Bookings = new clsBookingCollection();
        // var for record count
        Int32 RecordCount;
        // var for total booking price
        decimal BookingPrice;
        // var for booking approved 
        string BookingApproved;
        // var for booking date
        string BookingDate;
        // var for Booking ID
        string BookingID;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing items
        lstBookings.Items.Clear();
        // filter the records
        Bookings.FilterByDate();
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
            // get the booking date of the flight
            BookingDate = Convert.ToString(Bookings.BookingList[Index].BookingDate);
            // set up a new object of class list item
            ListItem NewItem = new ListItem(BookingPrice + " " + BookingApproved + " " + BookingDate, BookingID);
            // add the item to the list
            lstBookings.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // var to store primary key value of the booking to be updated
        Int32 BookingID;
        // if a booking has been selected from the list
        if (lstBookings.SelectedIndex != -1)
        {
            // get the primary key value of the record to update
            BookingID = Convert.ToInt32(lstBookings.SelectedValue);
            // store the data in the session object
            Session["BookingID"] = BookingID;
            // redirect to the update page
            Response.Redirect("Booking.aspx");
        }
        else
        // if no record has been selected display this message
        {
            // display an error
            lblError.Text = "Please select a booking to update";
        }
    }

    protected void btnFilterDate_Click(object sender, EventArgs e)
    {
        // event handler for filtering bookings by date
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the display destinations function to the record count var
        RecordCount = DisplayBookingsByDate();
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void btnManageCarParkRes_Click(object sender, EventArgs e)
    {
        // redirect to car park reservations page
        Response.Redirect("CarResDefault.aspx");
    }

    protected void btnCustomerManage_Click(object sender, EventArgs e)
    {
        // redirect to customers page
        Response.Redirect("Customers.aspx");
    }

    protected void btnStaffManage_Click(object sender, EventArgs e)
    {
        // redirect to staff page
        Response.Redirect("StaffDefault.aspx");
    }

    protected void btnDestinationManage_Click(object sender, EventArgs e)
    {
        // redirect to the destinations page
        Response.Redirect("Default.aspx");
    }
}