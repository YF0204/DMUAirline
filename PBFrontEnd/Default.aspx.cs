using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list and display the number of records found
            lblError.Text = DisplayDestinations("") + " records found";
        }
    }

    // function to populate the list box
    Int32 DisplayDestinations(string DestinationFilter)
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
        lstDestinations.Items.Clear();
        // call the filter method by destination name
        Destinations.FilterByDestination(DestinationFilter);
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
            lstDestinations.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }

    // event handler for the Add Destination button
    protected void btnAddDestination_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["DestinationID"] = -1;
        // redirect to the data entry page
        Response.Redirect("NewDestination.aspx");
    }

    // event handler for the Update Destination button
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // var to store the primary key value
        Int32 DestinationID;
        // if a record has been selected from the list
        if (lstDestinations.SelectedIndex != -1)
        {
            // get the primary key value
            DestinationID = Convert.ToInt32(lstDestinations.SelectedValue);
            // store the data in the session object
            Session["DestinationID"] = DestinationID;
            // redirect to the update page
            Response.Redirect("NewDestination.aspx");
        }
        // if no record has been selected
        else
        {
            // display an error
            lblError.Text = "Please select a record to update";
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        // event handler for searching destinations
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the display destinations function to the record count var
        RecordCount = DisplayDestinations(txtSearch.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }
}