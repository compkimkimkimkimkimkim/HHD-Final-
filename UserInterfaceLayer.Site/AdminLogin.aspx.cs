using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string info = Request.QueryString["logout"];

                if (info == "1")
                {
                    Session.Clear();
                    HttpContext.Current.Session["user"] = null;
                }
            }
        }

        protected void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string email = LidCMS.Text;
                string password = LpdCMS.Text;

                if (email == "1111@admin.sg" && password == "1111")
                {
                    Response.Redirect("~/UserInterfaceLayer.CMS/HomeCMS.aspx");
                }
                else
                {
                    loginfail.Text = "Invailed Email or Password!";
                }
            }
        }
    }
}