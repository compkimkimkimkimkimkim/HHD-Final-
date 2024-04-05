using HHD.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class CL_Location : System.Web.UI.Page
    {
        public string SplitAddress(string address)
        {
            string[] parts = address.Split(new string[] { "Singapore" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 1)
            {
                return parts[0].Trim() + "<br />Singapore" + parts[1];
            }
            return address;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetImageTitle();
                GetdataCity();
                GetdataStation();
                GetdataStation2();
                GetdataStation3();
                GetdataBus1();
            }
        }
        public void GetdataCity()
        {
            try
            {
                string sql = "SELECT * FROM Localtion WHERE LocaltionType = '1'";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    RptCity.DataSource = dt;
                    RptCity.DataBind();
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
        public void GetdataStation()
        {
            try
            {
                string sql = "SELECT LocaltionName, Distance,Minutes FROM Localtion WHERE LineColour = 'Green' ";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rptstation1.DataSource = dt;
                    rptstation1.DataBind();
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
        public void GetdataStation2()
        {
            try
            {
                string sql = "SELECT LocaltionName, Distance,Minutes FROM Localtion WHERE LineColour = 'Blue' ";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
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
        public void GetdataStation3()
        {
            try
            {
                string sql = "SELECT LocaltionName, Distance,Minutes FROM Localtion WHERE LineColour = 'Red' ";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    Repeater2.DataSource = dt;
                    Repeater2.DataBind();
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
        public void GetdataBus1()
        {
            try
            {
                string sql = "SELECT * FROM Localtion WHERE LocaltionType =3 ";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    RptBus1.DataSource = dt;
                    RptBus1.DataBind();
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
        public string RenderBusNumbers(string busNumbers)
        {

            string[] numbers = busNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string html = ""; 

            foreach (string number in numbers)
            {

                html += $"<div class=\"bus-plpp-card-right-item\">{number}</div>";
            }

            return html;
        }

        public void GetImageTitle()
        {
            try
            {
                string sql = @"SELECT Images
                   FROM Localtion
                   WHERE LocaltionType = 4";
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
    }
}