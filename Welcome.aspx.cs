using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["personKey"] != null)
        {
            GetCustomerInfo();
        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }
    private void GetCustomerInfo()
    {
        CommunityAssistEntities ae = new CommunityAssistEntities();
        int pk = (int)Session["personKey"];
        var customer = from c in ae.People
                       where c.PersonKey == pk
                       select new
                       {
                           c.PersonLastName,
                           c.PersonFirstName,
                           c.Donations,
                           c.PersonUsername,
                           c.ServiceGrants,
                       };

        GridView1.DataSource = customer.ToList();
        GridView1.DataBind();

    }



    protected void btnDonation_Click(object sender, EventArgs e)
    {
        Response.Redirect("Donation.aspx");
    }
    protected void btnGrant_Click(object sender, EventArgs e)
    {
        Response.Redirect("Grant.aspx");
    }
}