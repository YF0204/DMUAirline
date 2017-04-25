using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Customers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            // update the list box
            //DisplayCustomers();
            // populate the list box and display the no of records
            LblError.Text = Displaycustomers("") + " records found";
        }
    }

    // function to populate the list box
    Int32 Displaycustomers(string CustomerFilter)
    {
        // create an instance of the staff collection class
        clsCustomerCollection Customers = new clsCustomerCollection();
        // var for record count
        Int32 RecordCount;
        // var for last name
        string Surname;
        //string for Email
        string Email;
        // var for Customer ID
        string CustomerNo;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing item
        lstCustomers.Items.Clear();
        // call the filter method by customer last name
        Customers.FilterBySurname(CustomerFilter);
        // get the count of records
        RecordCount = Customers.Count;
        // loop through each record found using the index
        while (Index < RecordCount)
        {
            
            // get the last name of the customer
            Surname = Convert.ToString(Customers.CustomerList[Index].Surname);
            // get the email of the customer
            Email = Convert.ToString(Customers.CustomerList[Index].Email);
            // get the ID of the Customer
            CustomerNo = Convert.ToString(Customers.CustomerList[Index].CustomerNo);
            // set up a new object of class list item
            ListItem NewItem = new ListItem( Surname +"," + Email, CustomerNo);
            // add the item to the list
            lstCustomers.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }

    //void DisplayCustomers()
    //{
    //    // create an instance of the customer collection
    //    clsCustomerCollection Customers = new clsCustomerCollection();
    //    // set the data source to the list box
    //    lstCustomers.DataSource = Customers.CustomerList;
    //    // set the name of the primery key
    //    lstCustomers.DataValueField = "CustomerNo";
    //    // set the data field to display
    //    lstCustomers.DataTextField = "Surname";
    //    // bind the data to the list
    //    lstCustomers.DataBind();
    //}


    protected void Add_Click1(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerSignUp.aspx");
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the edit page
            Response.Redirect("CustomerSignUp.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            LblError.Text = "Please select a record to update from the list";
        }
    }

    protected void BtnSearchSurname_Click(object sender, EventArgs e)
    {

        // event handler for searching for staff members
        // declare var to store the record count
        Int32 RecordCount;
        // assign the results of the display staff members function to the record count var
        RecordCount = Displaycustomers(txtSurname.Text);
        // display the number of records found
        LblError.Text = RecordCount + " records found";

    }

}






