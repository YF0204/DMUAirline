using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProjectBank : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaffAccess_Click(object sender, EventArgs e)
    {
        // redirect to the staff access page
        Response.Redirect("ListOfBookings.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        // redirect to the main menu (list of destinations)
        Response.Redirect("MakeBooking.aspx");
    }
}
