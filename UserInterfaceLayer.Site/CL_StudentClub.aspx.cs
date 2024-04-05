using HHD.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class CL_StudentClub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadIndustry();
                LoadInterest();
                LoadInternational();
                MainTitle();
            }
        }
        public void LoadIndustry()
        {
            string sql = @"SELECT Images, Name, Content, Link
                   FROM StudentClub
                   WHERE StudentClubType = 3";
            rptIndustryClub.DataSource = SqlHelper.GetDataTable(sql);
            rptIndustryClub.DataBind();
        }
        public void LoadInterest()
        {
            string sql = @"SELECT Images, Name, Content, Link
                   FROM StudentClub
                   WHERE StudentClubType = 2";
            rptInterestClub.DataSource = SqlHelper.GetDataTable(sql);
            rptInterestClub.DataBind();
            rptInterestClub.DataBind();
        }
        public void LoadInternational()
        {
            string sql = @"SELECT Images, Name, Content, Link
                   FROM StudentClub
                   WHERE StudentClubType = 1";
            rptInternationalClub.DataSource = SqlHelper.GetDataTable(sql);
            rptInternationalClub.DataBind();

        }
        public void MainTitle()
        {
            string sql = @"SELECT Images
                   FROM StudentClub
                   WHERE StudentClubType = 4";
            MainTitle_Contain.DataSource = SqlHelper.GetDataTable(sql);
            MainTitle_Contain.DataBind();
        }
    }
}