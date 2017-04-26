using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class NewMember : System.Web.UI.Page
{
    // var to store primary key value
    Int32 StaffID;
    // load event for page event handler
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staff member to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        // if this is not the first time the page has been loaded
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (StaffID != -1)
            {
                // display the current data for the record
                DisplayStaffMember();
            }
        }
    }

    // function for adding new staff members
    void Add()
    {
        // create an instance of the staff collection
        clsStaffCollection StaffMember = new clsStaffCollection();
        // validate the data
        Boolean OK = StaffMember.ThisMember.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPostcode.Text, txtContactNo.Text, txtDOB.Text, txtDateJoined.Text);
        // if the data is OK then add it to the object
        if (OK == true)
        {
            // get the data entered by the user
            StaffMember.ThisMember.StaffFirstName = txtFirstName.Text;
            StaffMember.ThisMember.StaffLastName = txtLastName.Text;
            StaffMember.ThisMember.StaffAddress = txtAddress.Text;
            StaffMember.ThisMember.StaffEmailAddress = txtEmail.Text;
            StaffMember.ThisMember.StaffPostCode = txtPostcode.Text;
            StaffMember.ThisMember.StaffContactNo = txtContactNo.Text;
            StaffMember.ThisMember.StaffDOB = Convert.ToDateTime(txtDOB.Text);
            StaffMember.ThisMember.StaffDateJoined = Convert.ToDateTime(txtDateJoined.Text);
            // add the new staff member
            StaffMember.Add();
        }
        else
        {
            // report an error
            lblError.Text = "There were problems with the data entered";
        }
    }

    // function for updating staff members
    void Update()
    {
        // create an instance of the destination collection class
        clsStaffCollection StaffMember = new clsStaffCollection();
        // validate the data
        Boolean OK = StaffMember.ThisMember.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEmail.Text, txtPostcode.Text, txtContactNo.Text, txtDOB.Text, txtDateJoined.Text);
        // if the data is OK then add it to the object
        if (OK == true)
        {
            // find the record to update
            StaffMember.ThisMember.Find(StaffID);
            // get the data entered by the user
            StaffMember.ThisMember.StaffFirstName = txtFirstName.Text;
            StaffMember.ThisMember.StaffLastName = txtLastName.Text;
            StaffMember.ThisMember.StaffAddress = txtAddress.Text;
            StaffMember.ThisMember.StaffEmailAddress = txtEmail.Text;
            StaffMember.ThisMember.StaffPostCode = txtPostcode.Text;
            StaffMember.ThisMember.StaffContactNo = txtContactNo.Text;
            StaffMember.ThisMember.StaffDOB = Convert.ToDateTime(txtDOB.Text);
            StaffMember.ThisMember.StaffDateJoined = Convert.ToDateTime(txtDateJoined.Text);
            // update the record
            StaffMember.Update();
        }
        else
        {
            // error
            lblError.Text = "There is a problem with the data entered";
        }
    }

    void DisplayStaffMember()
    {
        // create an instance of the destination collection class
        clsStaffCollection StaffMember = new clsStaffCollection();
        // find the record to update
        StaffMember.ThisMember.Find(StaffID);
        // display the data for this record
        txtFirstName.Text = StaffMember.ThisMember.StaffFirstName;
        txtLastName.Text = StaffMember.ThisMember.StaffLastName;
        txtAddress.Text = StaffMember.ThisMember.StaffAddress;
        txtEmail.Text = StaffMember.ThisMember.StaffEmailAddress;
        txtPostcode.Text = StaffMember.ThisMember.StaffPostCode;
        txtContactNo.Text = StaffMember.ThisMember.StaffContactNo;
        txtDOB.Text = StaffMember.ThisMember.StaffDOB.ToString();
        txtDateJoined.Text = StaffMember.ThisMember.StaffDateJoined.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffID == -1)
        {
            // add the new staff member
            Add();
        }
        else
        {
            // update the staff member's details
            Update();
        }
        // finished, redirect to staff default page
        Response.Redirect("StaffDefault.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect to staff default page
        Response.Redirect("StaffDefault.aspx");
    }
}