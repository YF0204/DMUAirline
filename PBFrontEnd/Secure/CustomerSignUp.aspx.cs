using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerSignUp : System.Web.UI.Page
{   //variable to store the primary key with page level scope
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }
    //function for adding new records
    void Add()
    {
        //create an instance of the address book
        clsCustomerCollection Customers = new clsCustomerCollection();
        //validate the data on the web form
        Boolean OK = Customers.ThisCustomer.Valid(TxtFirstName.Text, TxtSurname.Text, TxtAddress1.Text, TxtAddress2.Text, TxtPostcode.Text, TxtPhoneNumber.Text, TxtEmail.Text);
        //if the data is OK then add it to the object
        if (OK == true)
        {
            //get the data entered by the user
            Customers.ThisCustomer.FirstName = TxtFirstName.Text;
            Customers.ThisCustomer.Surname = TxtSurname.Text;
            Customers.ThisCustomer.Address1 = TxtAddress1.Text;
            Customers.ThisCustomer.Address2 = TxtAddress2.Text;
            Customers.ThisCustomer.Postcode = TxtPostcode.Text;
            Customers.ThisCustomer.PhoneNumber = TxtPhoneNumber.Text;
            Customers.ThisCustomer.Email = TxtEmail.Text;
            //add the record
            Customers.Add();
        }
        else
        {
            //report an error
            LblError.Text = "There were problems with the data entered";
        }
    }

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        if (CustomerNo == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //all done so redirect back to the main page

        Response.Redirect("AddCarRes.aspx");

    }
    //function for updateing records
    void Update()
    {
        //create an instance of the address book
        clsCustomerCollection Customers = new clsCustomerCollection();
        //validate the data on the web form
        Boolean OK = Customers.ThisCustomer.Valid(TxtFirstName.Text, TxtSurname.Text, TxtAddress1.Text, TxtAddress2.Text, TxtPostcode.Text, TxtPhoneNumber.Text, TxtEmail.Text);
        //if the data is OK then add it to the object
        if (OK == true)
        {
            //get the data entered by the user
            Customers.ThisCustomer.FirstName = TxtFirstName.Text;
            Customers.ThisCustomer.Surname = TxtSurname.Text;
            Customers.ThisCustomer.Address1 = TxtAddress1.Text;
            Customers.ThisCustomer.Address2 = TxtAddress2.Text;
            Customers.ThisCustomer.Postcode = TxtPostcode.Text;
            Customers.ThisCustomer.PhoneNumber = TxtPhoneNumber.Text;
            Customers.ThisCustomer.Email = TxtEmail.Text;
            //add the record
            Customers.Update();
        }
        else
        {
            //report an error
            LblError.Text = "There were problems with the data entered";
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the address book
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        TxtFirstName.Text = Customers.ThisCustomer.FirstName;
        TxtSurname.Text = Customers.ThisCustomer.Surname;
        TxtAddress1.Text = Customers.ThisCustomer.Address1;
        TxtAddress2.Text = Customers.ThisCustomer.Address2;
        TxtPostcode.Text = Customers.ThisCustomer.Postcode;
        TxtPhoneNumber.Text = Customers.ThisCustomer.PhoneNumber;
        TxtEmail.Text = Customers.ThisCustomer.Email;
    }
}
    




