using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Booking : System.Web.UI.Page
{
    // var for primary key with page level scope
    Int32 BookingID;
    Int32 DestinationID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the booking to be processed
        BookingID = Convert.ToInt32(Session["BookingID"]);
        if (IsPostBack == false)
        {
            // get the data from the session objects
            string dest = Convert.ToString(Session["Dest"]);
            string price = Convert.ToString(Session["Price"]);
            string id = Convert.ToString(Session["ID"]);
            // place the information into the text boxes
            txtDestination.Text = dest;
            txtPP.Text = price;
            txtID.Text = id;
            // on load add today's date to the booking date textbox and false to booking approved
            txtBookingDate.Text = DateTime.Now.Date.ToShortDateString();
            txtBookingApproved.Text = Convert.ToString(false);
            // if this is not a new record
            if (BookingID != -1)
            {
                // display the current data for the record
                DisplayBooking();
            }
        }
    }

    void Add()
    {
        // create an instance of the class file
        clsBookingCollection Booking = new clsBookingCollection();
        // get the data
        Booking.ThisBooking.DestinationID = Convert.ToInt32(txtID.Text);
        Booking.ThisBooking.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
        Booking.ThisBooking.BookingApproved = Convert.ToBoolean(txtBookingApproved.Text);
        Booking.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
        Booking.ThisBooking.CustomerNo = Convert.ToInt32(txtCustomerID.Text);
        Booking.ThisBooking.CarParkID = Convert.ToInt32(txtCarParkID.Text);
        // add the record
        Booking.Add();
    }

    void Update()
    {
        // create an instance of the booking collection
        clsBookingCollection Booking = new clsBookingCollection();
        // find the record to update
        Booking.ThisBooking.Find(BookingID);
        // get the data entered
        Booking.ThisBooking.DestinationID = Convert.ToInt32(txtID.Text);
        Booking.ThisBooking.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
        Booking.ThisBooking.BookingApproved = Convert.ToBoolean(txtBookingApproved.Text);
        Booking.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
        // update the record
        Booking.Update();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (BookingID == -1)
        {
            // add the new record
            Add();
            // redirect to the destination page
            Response.Redirect("BookingComplete.aspx");
        }
        else
        {
            // update the record
            Update();
            // if booking is being updated return to list of bookings
            Response.Redirect("ListOfBookings.aspx");
        }
        
    }

    void DisplayBooking()
    {
        // create an instance of the booking collection
        clsBookingCollection Booking = new clsBookingCollection();
        // find the record to update
        Booking.ThisBooking.Find(BookingID);
        // display the data for the record
        txtDestination.Text = Booking.ThisBooking.DestinationID.ToString();
        txtTotalPrice.Text = Booking.ThisBooking.TotalPrice.ToString();
        txtBookingDate.Text = Booking.ThisBooking.BookingDate.ToString();
        txtBookingApproved.Text = Booking.ThisBooking.BookingApproved.ToString();
    }

    // function to calculate the total price of the booking
    void CalculatePrice()
    {
        // number of tickets chosen in the dropdown box times by the price person value of the selected destination
        decimal Total;
        decimal PP = Convert.ToDecimal(txtPP.Text);
        int Tickets = Convert.ToInt32(ddlTickets.SelectedValue);
        Total = PP * Tickets;
        txtTotalPrice.Text = Convert.ToString(Total);
    }

    // calculate button click event
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        CalculatePrice();
    }
}