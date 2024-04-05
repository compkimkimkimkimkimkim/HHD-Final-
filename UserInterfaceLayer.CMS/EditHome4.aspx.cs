using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditHome4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DisplayLocalTion(id);
                }
            }
        }
        private void DisplayLocalTion(int id)
        {
            Home home = HomeBLL.GetByIdDTO(id);
            if (home != null)
            {
                txtIndustryLink.Text = home.Link;
            }
        }
        protected void btnAddRank_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndustryLink.Text.Trim()))
            {

                int type = HomeConstant.Testimonial;
                var newUoN = new Home()
                {

                    category = type,
                    Link = txtIndustryLink.Text
                };
                HomeDAL.UpdateHome4(GetEventId(), newUoN);
            }
            Response.Redirect("HomeCMS.aspx");
        }

        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;

            return eventId;
        }
    }
}