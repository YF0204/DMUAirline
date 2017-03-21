using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffDefault : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // clear any existing error messages
        lblError.Text = "";
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // populate the list box and display the no of records
            lblError.Text = DisplayStaffMembers("") + " records found";
        }
    }

    // function to populate the list box
    Int32 DisplayStaffMembers(string StaffFilter)
    {
        // create an instance of the staff collection class
        clsStaffCollection Members = new clsStaffCollection();
        // var for record count
        Int32 RecordCount;
        // var for first name
        string FirstName;
        // var for last name
        string LastName;
        // var for staff ID
        string StaffID;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing item
        lstStaff.Items.Clear();
        // call the filter method by staff last name
        Members.FilterByStaffLastName(StaffFilter);
        // get the count of records
        RecordCount = Members.Count;
        // loop through each record found using the index
        while (Index < RecordCount)
        {
            // get the first name of the staff member
            FirstName = Convert.ToString(Members.StaffList[Index].StaffFirstName);
            // get the last name of the staff member
            LastName = Convert.ToString(Members.StaffList[Index].StaffLastName);
            // get the ID of the staff member
            StaffID = Convert.ToString(Members.StaffList[Index].StaffID);
            // set up a new object of class list item
            ListItem NewItem = new ListItem(LastName + "," + FirstName, StaffID);
            // add the item to the list
            lstStaff.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }

    protected void btnAddStaff_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        // redirect to the data entry page
        Response.Redirect("NewMember.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // var to store PK value
        Int32 StaffID;
        // if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            // get the primary key value of the record to update
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            // store the data in the session object
            Session["StaffID"] = StaffID;
            // redirect to the update page
            Response.Redirect("NewMember.aspx");
        }
        // if no record has been selected
        else
        {
            // display error message
            lblError.Text = "Please select a record to update";
        }
    }

    protected void btnSearchStaff_Click(object sender, EventArgs e)
    {
        // event handler for searching for staff members
        // declare var to store the record count
        Int32 RecordCount;
        // assign the results of the display staff members function to the record count var
        RecordCount = DisplayStaffMembers(txtSearchStaff.Text);
        // display the number of records found
        lblError.Text = RecordCount + " records found";

    }
}