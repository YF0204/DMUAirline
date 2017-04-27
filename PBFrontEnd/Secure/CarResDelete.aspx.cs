using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CarResDelete : System.Web.UI.Page
{
    //car to store the primary key value of the record to be deleted
    Int32 CarParkID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numberof the address to be deleted from the sessfion object
        CarParkID = Convert.ToInt32(Session["CarParkID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteReservation();
        //redirect back to main page
        Response.Redirect("CarResDefault.aspx");
    }
    void DeleteReservation()
    {
        //fucntion to delete the selected record 

        //create an instance of  the car park reservation 
        clscarparkCollection AReservation = new clscarparkCollection();
        //find a record to delete 
        AReservation.ThisCarPark.Find(CarParkID);
        //delete the record 
        AReservation.Delete();
    }
}