using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MakeBooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            // display the destinations in the list box
            DisplayDestinations();
        }
    }

    protected void btnMakeBooking_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["BookingID"] = -1;
        // select the index of the record from the list box
        int index = lstPickDestination.SelectedIndex;
        // get the text of the record
        string info = lstPickDestination.Items[index].Text;
        // pick apart the record to get the name and price
        int poundSymbolPosition = info.IndexOf("£");
        // var for destination name
        string destinationName = info.Substring(0, poundSymbolPosition);
        // start after the £PP
        int priceStartPosition = poundSymbolPosition + 4; 
        // var for destination price
        string destinationPrice = info.Substring(priceStartPosition, info.Length - priceStartPosition);
        // place the destination Name and Price into session objects
        Session["Dest"] = destinationName;
        Session["Price"] = destinationPrice;
        // redirect to the booking page
        Response.Redirect("Booking.aspx");
    }

    // function to populate the list box
    Int32 DisplayDestinations()
    {
        // create an instance of the destination collection
        clsDestinationCollection Destinations = new clsDestinationCollection();
        // var for record count
        Int32 RecordCount;
        // var for destination name
        string DestinationName;
        // var for destination price per person
        decimal DestinationPrice;
        // var for destination ID
        string DestinationID;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing item
        lstPickDestination.Items.Clear();
        // get the count of records
        RecordCount = Destinations.Count;
        // loop through each record found using the index
        while (Index < RecordCount)
        {
            // get the name of the destination
            DestinationName = Convert.ToString(Destinations.DestinationList[Index].Destination);
            // get the price per person for each destination
            DestinationPrice = Convert.ToDecimal(Destinations.DestinationList[Index].PricePerPerson);
            // get the ID of each destination
            DestinationID = Convert.ToString(Destinations.DestinationList[Index].DestinationID);
            // set up a new object of class list item
            ListItem NewItem = new ListItem(DestinationName + " " + "£PP" + " " + DestinationPrice, DestinationID);
            // add the item to the list
            lstPickDestination.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }
}