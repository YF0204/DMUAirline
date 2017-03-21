using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class NewDestination : System.Web.UI.Page
{
    // primary key used for scope
    Int32 DestinationID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the destination to be processed
        DestinationID = Convert.ToInt32(Session["DestinationID"]);
        // if this is not the first time the page has been loaded
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (DestinationID != -1)
            {
                // display the current data for the record
                DisplayDestination();
            }
        }
    }

    // function for adding new destinations
    void Add()
    {
        // create an instance of the destination collection class
        clsDestinationCollection Destinations = new clsDestinationCollection();
        // validate the data
        Boolean OK = Destinations.ThisDestination.Valid(txtDestinationName.Text, Convert.ToDecimal(txtPrice.Text), txtDayofFlight.Text, txtReturnDate.Text);
        // if the data is OK then add it to the object
        if (OK == true)
        {
            // get the data entered by the user
            Destinations.ThisDestination.Destination = txtDestinationName.Text;
            Destinations.ThisDestination.PricePerPerson = Convert.ToDecimal(txtPrice.Text);
            Destinations.ThisDestination.DayOfFlight = Convert.ToDateTime(txtDayofFlight.Text);
            Destinations.ThisDestination.ReturnDate = Convert.ToDateTime(txtReturnDate.Text);
            // add the record
            Destinations.Add();
        }
        else
        {
            // error
            lblError.Text = "There is a problem with the data entered";
        }

    }

    // function for updating destinations
    void Update()
    {
        // create an instance of the destination collection class
        clsDestinationCollection Destinations = new clsDestinationCollection();
        // validate the data
        Boolean OK = Destinations.ThisDestination.Valid(txtDestinationName.Text, Convert.ToDecimal(txtPrice.Text), txtDayofFlight.Text, txtReturnDate.Text);
        // if the data is OK then add it to the object
        if (OK == true)
        {
            // find the record to update
            Destinations.ThisDestination.Find(DestinationID);
            // get the data entered by the user
            Destinations.ThisDestination.Destination = txtDestinationName.Text;
            Destinations.ThisDestination.PricePerPerson = Convert.ToDecimal(txtPrice.Text);
            Destinations.ThisDestination.DayOfFlight = Convert.ToDateTime(txtDayofFlight.Text);
            Destinations.ThisDestination.ReturnDate = Convert.ToDateTime(txtReturnDate.Text);
            // update the record
            Destinations.Update();
        }
        else
        {
            // error
            lblError.Text = "There is a problem with the data entered";
        }
    }

    // event handler for the OK button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        if (DestinationID == -1)
        {
            // add the record
            Add();
        }
        else
        {
            // update the record
            Update();
        }
        // redirect to the main page
        Response.Redirect("Default.aspx");
    }

    void DisplayDestination()
    {
        // create an instance of the destination collection class
        clsDestinationCollection Destinations = new clsDestinationCollection();
        // find the record to update
        Destinations.ThisDestination.Find(DestinationID);
        // display the data of the record chosen
        txtDestinationName.Text = Destinations.ThisDestination.Destination;
        txtPrice.Text = Destinations.ThisDestination.PricePerPerson.ToString();
        txtDayofFlight.Text = Destinations.ThisDestination.DayOfFlight.ToString();
        txtReturnDate.Text = Destinations.ThisDestination.ReturnDate.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect back to default page
        Response.Redirect("Default.aspx");
    }
}