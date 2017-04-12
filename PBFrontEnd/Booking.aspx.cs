using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Booking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Add()
    {
        // create an instance of the class file
        clsBookingCollection Booking = new clsBookingCollection();
        // get the data
        Booking.ThisBooking.DestinationID = Convert.ToInt32(txtDestination.Text);
        Booking.ThisBooking.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
        // add the record
        Booking.Add();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // add the new record
        Add();
        // redirect to the destination page
        Response.Redirect("MakeBooking.aspx");
    }

    void CalculatePrice()
    {

    }
}