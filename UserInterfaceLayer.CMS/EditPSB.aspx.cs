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

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditPSB : System.Web.UI.Page
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
                        case "PSBC":
                            var psbc = PSBCBLL.GetByIdDTO(id);
                            if (psbc != null)
                            {
                                TextBox dynamicTextBox = new TextBox();
                                dynamicTextBox.ID = typeof(PSBC) + "ID";
                                dynamicTextBox.Text = psbc.id.ToString();

                                //// Thêm TextBox vào container
                                PSBFileUploadUni.Controls.Add(dynamicTextBox);
                                txtUniName.Controls.Add(dynamicTextBox);
                                Contentne.Controls.Add(dynamicTextBox);
                            }
                            break;



                        default:
                            // Xử lý cho trường hợp mặc định (nếu cần)
                            break;
                    }
                }
            }


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
        protected void btnAddUni_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUniName.Text.Trim()) && PSBFileUploadUni.HasFile)
            {
                string filePath = UploadFile(PSBFileUploadUni);

                var newPSBC = new PSBC()
                {
                    Images = filePath,
                    Name = txtUniName.Text,
                    Content = Contentne.Text
                };
                PSBCBLL.EditPSBC(newPSBC, GetEventId());

            }
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            TextBox textBox = PSBFileUploadUni.FindControl(typeof(EventLists) + "ID") as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                int.TryParse(textBox.Text, out eventId);
            }
            return eventId;
        }

    }
}