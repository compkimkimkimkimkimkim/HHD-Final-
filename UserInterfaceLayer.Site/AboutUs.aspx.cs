using HHD.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class AboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetImageTitle();
                BindAboutUsData();
                BindAboutUsData1();
            }
        }
        /// <summary>
        /// Get Image Title
        /// AboutUsType = 3
        /// </summary>
        public void GetImageTitle()
        {
            try
            {
                string sql = @"SELECT Images
                   FROM AboutUs
                   WHERE AboutUsType = 3";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    imgTitle.ImageUrl = "ImagesSite/" + dt.Rows[0]["Images"];
                }

            }
            catch (Exception ex)
            {
                // Handle the exception appropriately.
            }
        }
        private void BindAboutUsData()
        {
            string sql = @"SELECT Images, Name, Major, Ambitions
                   FROM AboutUs
                   WHERE AboutUsType = 1";

            rptAboutUs.DataSource = SqlHelper.GetDataTable(sql);
            rptAboutUs.DataBind();
        }
        private void BindAboutUsData1()
        {
            string sql = @"SELECT Images, Name, Major, Ambitions
                   FROM AboutUs
                   WHERE AboutUsType = 2";

            AbouUsType2.DataSource = SqlHelper.GetDataTable(sql);
            AbouUsType2.DataBind();
        }
    }
}