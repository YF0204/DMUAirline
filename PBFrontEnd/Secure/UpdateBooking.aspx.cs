using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class UpdateBooking : System.Web.UI.Page
{
    // declare a variable for the Booking ID
    Int32 BookingID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the id of the booking to update
        BookingID = Convert.ToInt32(Session["BookingID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (BookingID != -1)
            {
                // display the current data for the record
                DisplayBooking();
            }
        }
    }

    void Update()
    {
        // create an instance of the booking collection
        clsBookingCollection Booking = new clsBookingCollection();
        // find the record to update
        Booking.ThisBooking.Find(BookingID);
        // get the data entered
        Booking.ThisBooking.DestinationID = Convert.ToInt32(txtDestinationID.Text);
        Booking.ThisBooking.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
        Booking.ThisBooking.BookingApproved = Convert.ToBoolean(txtBookingApproved.Text);
        Booking.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
        Booking.ThisBooking.CarParkID = Convert.ToInt32(txtCarParkID.Text);
        Booking.ThisBooking.CustomerNo = Convert.ToInt32(txtCustomerID.Text);
        // update the record
        Booking.Update();
    }

    void DisplayBooking()
    {
        // create an instance of the booking collection
        clsBookingCollection Booking = new clsBookingCollection();
        // find the record to update
        Booking.ThisBooking.Find(BookingID);
        // display the data for the record
        txtDestinationID.Text = Booking.ThisBooking.DestinationID.ToString();
        txtTotalPrice.Text = Booking.ThisBooking.TotalPrice.ToString();
        txtBookingDate.Text = Booking.ThisBooking.BookingDate.ToString();
        txtBookingApproved.Text = Booking.ThisBooking.BookingApproved.ToString();
        txtCarParkID.Text = Booking.ThisBooking.CarParkID.ToString();
        txtCustomerID.Text = Booking.ThisBooking.CustomerNo.ToString();
    }

    protected void btnConfirmUpdate_Click(object sender, EventArgs e)
    {
        // update the changes made
        Update();
        // redirect to list of bookings
        Response.Redirect("ListOfBookings.aspx");
    }
}