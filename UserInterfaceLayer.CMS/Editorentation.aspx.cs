using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class Editorentation : System.Web.UI.Page
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
            HHD.Models.Orientation orientation = OrientationBLL.GetByIdDTO(id);
            if (orientation != null)
            {
                txtID.Text = orientation.Images;
                txtName.Text = orientation.Title;
                TextBox1.Text = orientation.Content;
            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            int eventId = GetEventId();
            if (currenteventFileUploadposter.HasFile)
            {
                int type = OrientationConstant.ToDo;
                string filePath = UploadFile(currenteventFileUploadposter);
                string name = txtName.Text;
                string content = TextBox1.Text;
                HHD.Models.Orientation eventTypeCurrent = new HHD.Models.Orientation()
                {

                    Images = filePath,
                    Content = name,
                    Title = content,
                };
                OrientationDAL.UpdateOrientation(GetEventId(), eventTypeCurrent);
                DisplayLocalTion(GetEventId());
            }
            else
            {

                HHD.Models.Orientation eventTypeCurrent = new HHD.Models.Orientation()
                {
                    Images = txtID.Text,
                    Content = TextBox1.Text,
                    Title = txtName.Text,
                  
                };
                OrientationDAL.UpdateOrientation(GetEventId(), eventTypeCurrent);
            }
            Response.Redirect("OrientationCMS.aspx");
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            TextBox textBox = currenteventFileUploadposter.FindControl(typeof(EventLists) + "ID") as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                int.TryParse(textBox.Text, out eventId);
            }
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