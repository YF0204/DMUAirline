using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AddCarRes : System.Web.UI.Page
{
    //variable  to store the primary key with page level  scope
    Int32 CarParkID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of car reg to be processed
        CarParkID = Convert.ToInt32(Session["CarParkID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (CarParkID != -1)
            {
                //Populate  the list of CarReg
                DisplayReg();
            }
        }
    }
    // function for adding car park reservations
    void Add()
    {
        // create an instance of the car park collection class
        clscarparkCollection Reservation = new clscarparkCollection();
        DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
        DateTime endDate = Convert.ToDateTime(txtEndDate.Text);
        Int32 NOD = Convert.ToInt32((endDate - startDate).Days);
        // validate the data
        Boolean OK = Reservation.ThisCarPark.Valid(txtBookingDate.Text, txtCarReg.Text, txtStartDate.Text, txtEndDate.Text, ddlLocation.Text);
        // if the date is OK then add it to the object
        if (OK == true)
        {
            // get the data entered by the user
            //DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
            //DateTime endDate = Convert.ToDateTime(txtEndDate.Text);
            //Int32 NOD = Convert.ToInt32((endDate - startDate).Days);
            Reservation.ThisCarPark.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
            Reservation.ThisCarPark.CarReg = txtCarReg.Text;
            Reservation.ThisCarPark.StartDate = Convert.ToDateTime(txtStartDate.Text);
            Reservation.ThisCarPark.EndDate = Convert.ToDateTime(txtEndDate.Text);
            Reservation.ThisCarPark.Location = Convert.ToString(ddlLocation.SelectedValue);
            Reservation.ThisCarPark.Price = Convert.ToDecimal(NOD * 10);
            // add the record
            Reservation.Add();
            //Response.Redirect("CarResDefault.aspx");
        }
        else
        {
            // state error
            lblError.Text = "There were problems, bro!";
           
        }

    }
    //Function for updating  record
    void Update()
    {
        //create an instance of the car reg
        clscarparkCollection Reservation = new clscarparkCollection();
        DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
        DateTime endDate = Convert.ToDateTime(txtEndDate.Text);
        Int32 NOD = Convert.ToInt32((endDate - startDate).Days);

        // validate the data
        //validate the data on the web form
        Boolean OK = Reservation.ThisCarPark.Valid(txtBookingDate.Text, txtCarReg.Text, txtStartDate.Text, txtEndDate.Text, ddlLocation.Text);
        //if the data is ok then add to the object
        if (OK == true)
        {
            //DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
            //DateTime endDate = Convert.ToDateTime(txtEndDate.Text);
            //Int32 NOD = Convert.ToInt32((endDate - startDate).Days);
            //find the record to update
            Reservation.ThisCarPark.Find(CarParkID);
            //get the  data entered  by the user
            Reservation.ThisCarPark.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
            Reservation.ThisCarPark.CarReg = txtCarReg.Text;
            Reservation.ThisCarPark.StartDate = Convert.ToDateTime(txtStartDate.Text);
            Reservation.ThisCarPark.EndDate = Convert.ToDateTime(txtEndDate.Text);
            Reservation.ThisCarPark.Location = Convert.ToString(ddlLocation.SelectedValue);
            Reservation.ThisCarPark.Price = Convert.ToDecimal(NOD * 10);
            //update the record 
            Reservation.Update();
            //Response.Redirect("CarResDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There wre problem with the date entered";
            
        }


    }
    void DisplayReg()
    {
        //create an instance of the car reg
        clscarparkCollection Reservation = new clscarparkCollection();
        //find the record to update
        Reservation.ThisCarPark.Find(CarParkID);
        //display the data  for this record 
        txtBookingDate.Text = Reservation.ThisCarPark.BookingDate.ToString();
        txtCarReg.Text = Reservation.ThisCarPark.CarReg;
        txtStartDate.Text = Reservation.ThisCarPark.StartDate.ToString();
        txtEndDate.Text = Reservation.ThisCarPark.EndDate.ToString();
        ddlLocation.SelectedValue = Reservation.ThisCarPark.Location;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CarParkID == -1)
        {
            // Add the new car reg
            Add();
            // redirect to the booking page
            Response.Redirect("MakeBooking.aspx");
        }
        else
        {
            //update the new reservation
            Update();
            // return to list of car park reservations
            Response.Redirect("CarResDefault.aspx");
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("MainMenu.aspx");
    }

    protected void btnSkip_Click(object sender, EventArgs e)
    {
        //all done so redirect  back to the main page
        Response.Redirect("MakeBooking.aspx");
    }
}