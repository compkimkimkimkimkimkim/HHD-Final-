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
    public partial class EditHome : System.Web.UI.Page
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
                txtID.Text = home.Image;
            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            int eventId = GetEventId();
            if (currenteventFileUploadposter.HasFile)
            {
                int type = HomeConstant.CurrentEventList;
                string filePath = UploadFile(currenteventFileUploadposter);
                Home eventTypeCurrent = new Home()
                {
                    Image = filePath,
                };
                HomeDAL.UpdateHome(GetEventId(), eventTypeCurrent);
                DisplayLocalTion(GetEventId());
            }
            else
            {

                Home eventTypeCurrent = new Home()
                {
                    Image = txtID.Text,
                };
                HomeDAL.UpdateHome(GetEventId(), eventTypeCurrent);
                DisplayLocalTion(GetEventId());
            }
            Response.Redirect("HomeCMS.aspx");
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            return eventId;
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