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

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditHome3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DisplayLocalTion(id);
                }
            }
        }
        private void DisplayLocalTion(int id)
        {
            Home home = HomeBLL.GetByIdDTO(id);
            if (home != null)
            {
                txtRank.Text = home.Rank.ToString();
                txtRankDescription.Text = home.Description;
            }
        }
        protected void btnAddRank_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRankDescription.Text.Trim()) && !string.IsNullOrEmpty(txtRank.Text.Trim()) && UoNFileUploadRank.HasFile
                    )
            {
                string filePath = UploadFile(UoNFileUploadRank);
                int type = HomeConstant.UniInfoSection;
                var newUoN = new Home()
                {
                    Image = filePath,
                    category = type,
                    Rank = int.Parse(txtRank.Text),
                    Description = txtRankDescription.Text
                };
                HomeDAL.UpdateHome3(GetEventId(), newUoN);
            }
            Response.Redirect("HomeCMS.aspx");
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
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
         
            return eventId;
        }
    }
}