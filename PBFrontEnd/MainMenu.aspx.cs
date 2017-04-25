using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // this function handles the load event for the page
        // if this is the first time the page has been loaded
        if (IsPostBack == false)
        {
            // update the list box
            DisplayDestinations();
        }
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
        // var for single flight
        string DayFlight;
        // var for return flight
        string ReturnFlight;
        // var for destination ID
        string DestinationID;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing item
        lstDestinationPicker.Items.Clear();
        // get the count of records
        RecordCount = Destinations.Count;
        // loop through each record found using the index
        while (Index < RecordCount)
        {
            // get the name of the destination
            DestinationName = Convert.ToString(Destinations.DestinationList[Index].Destination);
            // get the price per person for each destination
            DestinationPrice = Convert.ToDecimal(Destinations.DestinationList[Index].PricePerPerson);
            // get the day of flight
            DayFlight = Convert.ToString(Destinations.DestinationList[Index].DayOfFlight);
            // get the return flight
            ReturnFlight = Convert.ToString(Destinations.DestinationList[Index].ReturnDate);
            // get the ID of each destination
            DestinationID = Convert.ToString(Destinations.DestinationList[Index].DestinationID);
            // set up a new object of class list item
            ListItem NewItem = new ListItem(DestinationName + " " + "£PP" + " " + " " + DestinationPrice + " " + DayFlight + " " + ReturnFlight, DestinationID);
            // add the item to the list
            lstDestinationPicker.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }
}