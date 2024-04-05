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
    public partial class Uni_Orientation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindToDoList();
                BindFAQ();
                GetTitle();
            }
        }

        private void BindToDoList()
        {
            try
            {
                string sql = @"SELECT Images, Content, Title
                   FROM Orientation
                   WHERE OrientationType = 1";

                rptToDo.DataSource = SqlHelper.GetDataTable(sql);
                rptToDo.DataBind();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Handle the exception appropriately.
            }
        }
        private void BindFAQ()
        {
            try
            {
                string sql = @"SELECT Images, Content, Title
                   FROM Orientation
                   WHERE OrientationType = 2";
                rptFAQ.DataSource = SqlHelper.GetDataTable(sql);
                rptFAQ.DataBind();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Handle the exception appropriately.
            }
        }
        /// <summary>
        /// Get Title
        /// OrientationType = 3
        /// </summary>
        private void GetTitle()
        {
            try
            {
                string sql = @"SELECT Content, Title
                   FROM Orientation
                   WHERE OrientationType = 3";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txt_Title.InnerHtml = dt.Rows[0]["Title"] + "";
                    txt_Content.InnerHtml = dt.Rows[0]["Content"] + "";
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // Handle the exception appropriately.
            }
        }

    }
}