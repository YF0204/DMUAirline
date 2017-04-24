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
        if (IsPostBack == false)
        {
            // get the number of the booking to be processed
            BookingID = Convert.ToInt32(Session["BookingID"]);
            string dest = Convert.ToString(Session["Dest"]);
            string price = Convert.ToString(Session["Price"]);
            txtDestination.Text = dest;
            txtPP.Text = price;
            // on load add today's date to the booking date textbox
            txtBookingDate.Text = DateTime.Now.Date.ToShortDateString();
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
        Booking.ThisBooking.DestinationID = Convert.ToInt32(txtDestination.Text);
        Booking.ThisBooking.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
        Booking.ThisBooking.BookingApproved = Convert.ToBoolean(txtBookingApproved.Text);
        Booking.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
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
        Booking.ThisBooking.DestinationID = Convert.ToInt32(txtDestination.Text);
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
        }
        else
        {
            // update the record
            Update();
        }
        // redirect to the destination page
        Response.Redirect("MakeBooking.aspx");
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
        Total = Convert.ToDecimal(txtTotalPrice.Text);
    }

    // calculate button click event
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        CalculatePrice();
    }
}