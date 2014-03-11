using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Grant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CommunityAssistEntities ae = new CommunityAssistEntities();
            var services = from s in ae.CommunityServices
                           orderby s.ServiceName
                           select new { s.ServiceName, s.ServiceKey };

            ddlServices.DataSource = services.ToList();
            ddlServices.DataTextField = "ServiceName";
            ddlServices.DataValueField = "ServiceKey";
            ddlServices.DataBind();
        }
    }
    protected void btnSubmitGrant_Click(object sender, EventArgs e)
    {

    }
}