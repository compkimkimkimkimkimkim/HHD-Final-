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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Getcurent();
                GetVideo();
                GetCampus();
                GetUni_Info();
                GetCommunicate();
            }
        }
        public void Getcurent()
        {
            try
            {
                string sql = "SELECT * FROM Home WHERE category = 1";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string script = @"<div id='myCarousel' class='carousel slide' data-ride='carousel'>
    <!-- Indicators -->
            <ol class='carousel-indicators'>";
                    int item = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        script += @"<li data-target='#myCarousel' data-slide-to='" + item + @"' class='" + (item == 0 ? "active" : "") + @"'>";
                        item++;
                    }
                    script += @"</ol>

            <!-- Wrapper for slides -->
            <div class='carousel-inner'>";

                    int i = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        script += @" <div class='item " + (i == 1 ? "active" : "") + @"'>
                                            <img src='" + "ImagesSite/" + row["Image"] + @"' alt='' style='width:100%;'>
                                          </div>";
                        i++;
                    }
                    script += @"</div>

            <!-- Left and right controls -->
            <a class='left carousel-control' href='#myCarousel' data-slide='prev'>
              <span class='glyphicon glyphicon-chevron-left'></span>
              <span class='sr-only'>Previous</span>
            </a>
            <a class='right carousel-control' href='#myCarousel' data-slide='next'>
              <span class='glyphicon glyphicon-chevron-right'></span>
              <span class='sr-only'>Next</span>
            </a>
          </div>";
                    rptCurrent.InnerHtml = script;
                    rptCurrent.DataBind();
                }
                else
                {
                    Console.WriteLine("No Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail Connection");
            }
        }
        public void GetVideo()
        {
            {
                try
                {
                    string sql = "SELECT * FROM Home WHERE category = '2'";
                    DataTable dt = SqlHelper.GetDataTable(sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        rptVideo.DataSource = dt;
                        rptVideo.DataBind();
                    }
                    else
                    {
                        Console.WriteLine("No Data");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fail Connection");
                }
            }
        }
        /// <summary>
        /// Welcome to Singapore Campus
        /// category = 3
        /// rank: 
        ///     + 1: Navigate to Campus
        ///     + 2: About Marina Square
        ///     + 3: Student Club
        /// </summary>
        public void GetCampus()
        {
            try
            {
                string sql = "SELECT * FROM Home WHERE category = '3'";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        switch (row["Rank"] + "")
                        {
                            case "1":
                                imgCL_Location.ImageUrl = "ImagesSite/" + row["Image"];
                                txt_CL_Location.InnerHtml = row["Name"] + "";
                                break;
                            case "2":
                                imgCL_MarinaSquare.ImageUrl = "ImagesSite/" + row["Image"];
                                txt_CL_MarinaSquare.InnerHtml = row["Name"] + "";
                                break;
                            case "3":
                                imgCL_StudentClub.ImageUrl = "ImagesSite/" + row["Image"];
                                txt_CL_StudentClub.InnerHtml = row["Name"] + "";
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail Connection");
            }
        }

        /// <summary>
        /// Uni Info Section
        /// category = 4
        /// rank: 
        ///     + 1: Our University
        ///     + 2: The University of Newcastle
        ///     + 3: PSB Academy
        /// </summary>
        public void GetUni_Info()
        {
            try
            {
                string sql = "SELECT * FROM Home WHERE category = '4'";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        switch (row["Rank"] + "")
                        {
                            case "1":
                                txt_OurUni.InnerHtml = row["Description"] + "";
                                break;
                            case "2":
                                txt_University_of_NewCastle.InnerHtml = row["Description"] + "";
                                break;
                            case "3":
                                txt_PSB_Academy.InnerHtml = row["Description"] + "";
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail Connection");
            }
        }
        /// <summary>
        /// Communicate With Friends
        /// category: 5
        /// </summary>
        public void GetCommunicate()
        {
            try
            {
                string sql = "SELECT * FROM Home WHERE category = '5'";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    imgCommunicate.ImageUrl = "ImagesSite/" + dt.Rows[0]["Image"];
                    txt_Communicate.InnerHtml = dt.Rows[0]["Description"] + "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail Connection");
            }
        }
        protected void uonbtn(object sender, EventArgs e)
        {
            Response.Redirect("Uni_UoN.aspx");
        }

        protected void psbbtn(object sender, EventArgs e)
        {
            Response.Redirect("Uni_PSB.aspx");
        }
    }
}