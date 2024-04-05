using HHD.BusinessLogicLayer;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class CL_MarinaSquare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetImageTitle();
                RestauranL1();
                RestauranL2();
                RestaurantL3();
                RestauranBasement();
            }
        }
        /// <summary>
        /// Get Image Title
        /// type = 4
        /// </summary>
        public void GetImageTitle()
        {
            try
            {
                string sql = @"SELECT filePath
                   FROM LevelMary
                   WHERE type = 4";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    imgTitle.ImageUrl = "ImagesSite/" + dt.Rows[0]["filePath"];
                }

            }
            catch (Exception ex)
            {
                // Handle the exception appropriately.
            }
        }
        private void RestaurantL3()
        {
            string sql = "SELECT name, filepath, type, id FROM LevelMary WHERE type=3";
            RptLv3.DataSource = SqlHelper.GetDataTable(sql);
            RptLv3.DataBind();
        }
        private void RestauranL2()
        {
            string sql = "SELECT name, filepath, type, id FROM LevelMary WHERE type=2";
            RptLv2.DataSource = SqlHelper.GetDataTable(sql);
            RptLv2.DataBind();
        }
        private void RestauranL1()
        {
            string sql = "SELECT name, filepath, type, id FROM LevelMary WHERE type=1";
            RptLv1.DataSource = SqlHelper.GetDataTable(sql);
            RptLv1.DataBind();
        }
        private void RestauranBasement()
        {
            string sql = "SELECT name, filepath, type, id FROM LevelMary WHERE type=0";
            RptBase.DataSource = SqlHelper.GetDataTable(sql);
            RptBase.DataBind();
        }
    }
}