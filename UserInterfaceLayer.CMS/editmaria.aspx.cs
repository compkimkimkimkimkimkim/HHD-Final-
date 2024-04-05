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

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class editmaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    string name = Request.QueryString["type"];

                    switch (name)
                    {                      
                        case "MarianSquare":


                            DisplayLocalTion(id);
                        break;
                        default:
                            // Xử lý cho trường hợp mặc định (nếu cần)
                            break;
                    }
                }
            }
        }




        private void DisplayLocalTion(int id)
        {
            MarianSquare marianSquare = MarianSquareBLL.GetByIdDTO(id);
            if (marianSquare != null)
            {
                txtName.Text = marianSquare.name;
                txtID.Text = marianSquare.filePath;
            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            int eventId = GetEventId();
            if (currenteventFileUploadposter.HasFile)
            {
                int type = EventListsConstant.UpComing;
                string filePath = UploadFile(currenteventFileUploadposter);
                string name = txtName.Text;
                MarianSquare eventTypeCurrent = new MarianSquare()
                {

                    filePath = filePath,
                    name = name,
                };
                MarianSquareDAL.UpdateMarianSquare(GetEventId(),eventTypeCurrent );
                DisplayLocalTion(GetEventId());
            }
            else
            {
               
                MarianSquare eventTypeCurrent = new MarianSquare()
                {
                    filePath= txtID.Text, 
                    name = txtName.Text,
                };
                MarianSquareBLL.EditMarianSquare(eventTypeCurrent, eventId);
            }
            Response.Redirect("MarinaSquareCMS.aspx");
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

   