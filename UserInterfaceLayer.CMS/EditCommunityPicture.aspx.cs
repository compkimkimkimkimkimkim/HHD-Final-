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
    public partial class EditCommunityPicture : System.Web.UI.Page
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
            CommunityPicture communityPicture = CommunityPictureBLL.GetByIdDTO(id);
            if (communityPicture != null)
            {
                txtName.Text = communityPicture.Path;
            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            int eventId = GetEventId();
            if (currenteventFileUploadposter.HasFile)
            {

                string filePath = "~/UserInterfaceLayer.Site/ImagesSite/" + UploadFile(currenteventFileUploadposter);


                CommunityPicture eventTypeCurrent = new CommunityPicture()
                {

                    Path = filePath,
                };
                CommunityPictureDAL.UpdateCommunityPicture2(GetEventId(), eventTypeCurrent);
                DisplayLocalTion(GetEventId());
            }
            else
            {

                CommunityPicture eventTypeCurrent = new CommunityPicture()
                {

                    Path = txtName.Text,
                };
                CommunityPictureDAL.UpdateCommunityPicture2(GetEventId(), eventTypeCurrent);
            }
            Response.Redirect("CommunityCMS.aspx");
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