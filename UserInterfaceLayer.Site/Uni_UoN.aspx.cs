using HHD.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class Uni_UoN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindAboutUsData();
            BindAboutUsData1();
            MainTitle();
            GetOtherContent();
        }

        private void BindAboutUsData()
        {
            try
            {
                string sql = "SELECT * FROM UoN WHERE UoNType = 1";

                DataTable dataTable = SqlHelper.GetDataTable(sql);
                rptTop.DataSource = dataTable;
                rptTop.DataBind();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Handle the exception appropriately.
            }
        }

        private void BindAboutUsData1()
        {
            try
            {
                string sql = "SELECT * FROM UoN WHERE UoNType = 2";

                DataTable dataTable = SqlHelper.GetDataTable(sql);
                rptview.DataSource = dataTable;
                rptview.DataBind();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Handle the exception appropriately.
            }
        }
        private void MainTitle()
        {
            string sql = "SELECT Images, Content, Title FROM UoN WHERE UoNType = 3";
            MainTitle_Contain.DataSource = SqlHelper.GetDataTable(sql);
            MainTitle_Contain.DataBind();
        }
        /// <summary>
        /// Other Content
        /// UoNType = 4
        /// </summary>
        private void GetOtherContent()
        {
            try
            {
                string sql = @"SELECT Images,Description,Content, Title
                   FROM UoN
                   WHERE UoNType = 4";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string strLayout = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        strLayout += @" 
                               <div class='itemOtherContent'>
                                    <h1>" + row["Title"] + @"</h1>
                                    <div class='line-wrap'>
                                        <div class='line'></div>
                                    </div>
                                    <div class='light'>" + row["Description"] + @"</div>
                                    <p class='message-cont'>
                                        " + row["Content"] + @"
                                    </p>
                                    <div class='sign'>
                                        <img src='ImagesSite/" + row["Images"] + @"'>
                                    </div>
                                </div>";
                    }
                    arrItemOtherContents.InnerHtml = strLayout;
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}