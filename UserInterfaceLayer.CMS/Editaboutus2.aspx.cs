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
    public partial class Editaboutus2 : System.Web.UI.Page
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
            HHD.Models.AboutUs about = AboutUsBLL.GetByIdDTO(id);
            if (about != null)
            {
                TextBox2.Text = about.Images;
               
                TextBox1.Text = about.Name;
            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            int eventId = GetEventId();
            if (currenteventFileUploadposter.HasFile)
            {
                int type = AboutUsConstant.tool;
                string filePath = UploadFile(currenteventFileUploadposter);
               
                string name = TextBox1.Text;
                HHD.Models.AboutUs eventTypeCurrent = new HHD.Models.AboutUs()
                {

                    Images = filePath,
                
                    Name = name,
                };
                AboutUsDAL.UpdateAboutUsTool(GetEventId(), eventTypeCurrent);
                DisplayLocalTion(GetEventId());
            }
            else
            {
                HHD.Models.AboutUs eventTypeCurrent = new HHD.Models.AboutUs()
                {

                    Images = TextBox2.Text,
                  
                    Name = TextBox1.Text,
                };

                AboutUsDAL.UpdateAboutUsTool(GetEventId(), eventTypeCurrent);
            }
            Response.Redirect("AboutUsCMS.aspx");
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
          
            return id;
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