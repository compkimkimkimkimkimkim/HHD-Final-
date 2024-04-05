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


namespace HHD.UserInterfaceLayer.Site
{
    public partial class CL_Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCurent();
                LoadUpComming();
                LoadPast();
                MainTitle();
            }

        }

        public void LoadCurent()
        {

            string sql = @"SELECT EventPoster
                   FROM EventLists
                   WHERE EventType = 3";
            Current_Container.DataSource = SqlHelper.GetDataTable(sql);
            Current_Container.DataBind();

        }
        public void LoadUpComming()
        {
            string sql = @"SELECT EventPoster
                   FROM EventLists
                   WHERE EventType = 2";
            UpComing_Container.DataSource = SqlHelper.GetDataTable(sql);
            UpComing_Container.DataBind();
        }


        public void LoadPast()
        {
            string sql = @"SELECT EventPoster
                   FROM EventLists
                   WHERE EventType = 1";
            Past_Container.DataSource = SqlHelper.GetDataTable(sql);
            Past_Container.DataBind();


        }
        public void MainTitle()
        {
            string sql = @"SELECT EventPoster
                   FROM EventLists
                   WHERE EventType = 4";
            MainTitle_Containt.DataSource = SqlHelper.GetDataTable(sql);
            MainTitle_Containt.DataBind();
        }
    }
}