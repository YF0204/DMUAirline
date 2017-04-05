using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CarResDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            //DisplayCarReg();
            LblCarReg.Text = DisplayCarReg("") + "Record Found";
        }
    }
    //void DisplayCarReg()
    //{
    //    //create an instance of the car park collection
    //    clscarparkCollection carpark = new clscarparkCollection();
    //    //set the data source  to the list box
    //    LstCarReg.DataSource = carpark.CarParkList;
    //    //set the name of the primary key
    //    LstCarReg.DataValueField = "CarParkID";
    //    //Set the data field to display
    //    LstCarReg.DataTextField = "CarReg";
    //    //bind the data to the text
    //    LstCarReg.DataBind();
    //}

    // function to populate the list box
    Int32 DisplayCarReg(string CarRegFilter)
    {
        // create an instance of the car park cloolection
        clscarparkCollection carreg = new clscarparkCollection();
        // var for record count
        Int32 RecordCount;
        // var for first name
        string CarReg;
        // var for Index
        Int32 Index = 0;
        // clear the list of any existing item
        LstCarReg.Items.Clear();
        // call the filter method by staff last name
        carreg.FilterByCarReg(CarRegFilter);
        // get the count of records
        RecordCount = carreg.Count;
        // loop through each record found using the index
        while (Index < RecordCount)
        {
            // get the first name of the staff member
            CarReg = Convert.ToString(carreg.CarParkList[Index].CarReg);
            //// get the last name of the staff member
            //LastName = Convert.ToString(Members.StaffList[Index].StaffLastName);
            //// get the ID of the staff member
            //StaffID = Convert.ToString(Members.StaffList[Index].StaffID);
            //// set up a new object of class list item
            ListItem NewItem = new ListItem(CarReg + ",");
            // add the item to the list
            LstCarReg.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        // return the number of records found
        return RecordCount;
    }

    protected void BtnFilter_Click(object sender, EventArgs e)
    {
        // event handler for searching for staff members
        // declare var to store the record count
        Int32 RecordCount;
        // assign the results of the display staff members function to the record count var
        RecordCount = DisplayCarReg(TxtCarReg.Text);
        // display the number of records found
        LblCarReg.Text = RecordCount + " records found";

    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        // var to store  the primary key value of the record to be deleted
        Int32 CarParkID;
        //if a record has been selcted from the list
        if (LstCarReg.SelectedIndex != -1)
        {
            //var to store the primary key value  of the record to be deleted
            CarParkID = Convert.ToInt32(LstCarReg.SelectedValue);
            //store  the data in the session object
            Session["CarParkID"] = CarParkID;
            //redirect to the page 
            Response.Redirect("CarResDelete.aspx");
        }
        //if no record has been found
        else
        {
            //display an error
            LblCarReg.Text = "Please select a record to delete from the list";

        }
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        //var to store  the primary key value of the record to be deleted 
        Int32 CarParkID;
        //if a record has been selcted from the list
        if (LstCarReg.SelectedIndex != -1)
        {
            //var to store the primary key value  of the record to be deleted
            CarParkID = Convert.ToInt32(LstCarReg.SelectedValue);
            //store  the data in the session object
            Session["CarParkID"] = CarParkID;
            //redirect to the page 
            Response.Redirect("AddCarRes.aspx");
        }
        //if no record has been found
        else
        {
            //display an error
            LblCarReg.Text = "Please select a record to delete from the list";
        }
    }


    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this  new record
        Session["CarParkID"] = -1;
        //direct back to the main page
        Response.Redirect("AddCarRes.aspx");
    }
}