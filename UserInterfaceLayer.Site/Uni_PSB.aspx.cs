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
    public partial class Uni_PSB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Getdata();
            GetTitle();
            MainTitle();
            OverView();
        }
        public void Getdata()
        {
            try
            {
                string sql = "SELECT Images, Name FROM PSBC WHERE PSBCType=1";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string script = @"<div class='line1'></div>";
                    int i = 0;
                    foreach (DataRow rowdt in dt.Rows)
                    {
                        if (i == 3)
                        {
                            i = 0;
                            script += @"<div class='line1'></div>";
                        }
                        script += @" <div class='item'>
                                        <div class='image'>
                                            <img src='ImagesSite/" + rowdt["Images"] + @"'>
                                        </div>
                                        <div class='title'>" + rowdt["Name"] + @"</div>
                                    </div>
                                    <div class='split'></div>";
                        i++;
                    }
                    script += @"<div class='line1'></div>";
                    RptPsb.InnerHtml = script;
                }
                else
                {
                    Console.WriteLine("No data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connection");
            }
        }
        public void GetTitle()
        {
            try
            {
                string sql = "SELECT * FROM PSBC WHERE PSBCType=2";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    RptTitle.DataSource = dt;
                    RptTitle.DataBind();
                }
                else
                {
                    Console.WriteLine("No data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connection");
            }
        }
        public void MainTitle()
        {
            string sql = "SELECT Images, Content, Title FROM PSBC WHERE PSBCType=4";
            MainTitle_Contain.DataSource = SqlHelper.GetDataTable(sql);
            MainTitle_Contain.DataBind();
        }
        public void OverView()
        {
            string sql = "SELECT Images, Title FROM PSBC WHERE PSBCType=3";
            OverView_Contain.DataSource = SqlHelper.GetDataTable(sql);
            OverView_Contain.DataBind();
        }
    }
}