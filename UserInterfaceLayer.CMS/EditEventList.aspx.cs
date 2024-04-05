using HHD.BusinessLogicLayer;
using HHD.Constant;
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
    public partial class EditEventList : System.Web.UI.Page
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

                        case "EventLists":
                            //  ViewState["EventLists"] = true;
                            var events = EventListsBLL.GetByIdDTO(id);
                            if (events != null)
                            {
                                TextBox dynamicTextBox = new TextBox();
                                dynamicTextBox.ID = typeof(EventLists) + "ID";
                                dynamicTextBox.Text = events.Id.ToString();

                                //// Thêm TextBox vào container
                                //dynamicControlsPanel.Controls.Add(dynamicTextBox);
                                currenteventFileUploadposter.Controls.Add(dynamicTextBox);

                            }
                            break;

                        default:
                            // Xử lý cho trường hợp mặc định (nếu cần)
                            break;
                    }
                }
            }
        }





        protected void btnAction_Click(object sender, EventArgs e)
        {


            if (currenteventFileUploadposter.HasFile)
            {

                string filePath = UploadFile(currenteventFileUploadposter);

                EventLists eventTypeCurrent = new EventLists()
                {

                    EventPoster = filePath,

                };
                EventListsBLL.EditEvent(eventTypeCurrent, GetEventId());

            }



        }


        // Phương thức này sẽ lấy Id của sự kiện từ TextBox được thêm vào `currenteventFileUploadposter`
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