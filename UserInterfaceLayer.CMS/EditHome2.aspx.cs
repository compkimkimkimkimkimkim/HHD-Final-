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
using System.Xml.Linq;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditHome2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    string name = Request.QueryString["type"];
                    DisplayLocalTion(id);
                }
            }
        }
        private void DisplayLocalTion(int id)
        {
            Home home = HomeBLL.GetByIdDTO(id);
            if (home != null)
            {
                txtIndustryName.Text = home.Name;
                txtIndustryLink.Text=home.Link;
                txtIndustryContent.Text=home.Content;   


            }
        }
        protected void btnAddIndustry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndustryContent.Text.Trim()) && !string.IsNullOrEmpty(txtIndustryLink.Text.Trim()) && !string.IsNullOrEmpty(txtIndustryName.Text.Trim()) && ClubiFileUploadIndustry.HasFile
                    )
            {
                string filePath = UploadFile(ClubiFileUploadIndustry);
           
                var home = new Home()
                {
                    Image = filePath,
                    Name = txtIndustryName.Text,
                    Content = txtIndustryContent.Text,
                    Link = txtIndustryLink.Text,
                  

                };
                HomeDAL.UpdateHome2(GetEventId(), home);
            }
            Response.Redirect("HomeCMS.aspx");
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            return eventId;
        }

        protected void btnCancelIndustry_Click(object sender, EventArgs e)
        {

        }
        public string UploadFile(FileUpload file)
        {
            try
            {
                string FileName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + "_" + Path.GetFileName(file.FileName);
                string destinationFile = Server.MapPath("~/UserInterfaceLayer.Site/ImagesSite");
                string destianFilePath = Path.Combine(destinationFile, FileName);
                file.SaveAs(destianFilePath);
                return FileName;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}