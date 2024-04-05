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
    public partial class StudentClubEdit : System.Web.UI.Page
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


                        case "StudentClub":
                            var student = StudentClubBLL.GetByIdDTO(id);
                            if (student != null)
                            {
                                TextBox dynamicTextBox = new TextBox();
                                dynamicTextBox.ID = typeof(StudentClub) + "ID";
                                dynamicTextBox.Text = student.id.ToString();

                                ClubiFileUploadIndustry.Controls.Add(dynamicTextBox);
                                txtIndustryName.Controls.Add(dynamicTextBox);
                                txtIndustryContent.Controls.Add(dynamicTextBox);
                                txtIndustryLink.Controls.Add(dynamicTextBox);
                            }
                            break;

                        default:
                            break;
                    }
                }
            }

        }
        protected void btnAddIndustry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndustryContent.Text.Trim()) && !string.IsNullOrEmpty(txtIndustryLink.Text.Trim()) && !string.IsNullOrEmpty(txtIndustryName.Text.Trim()) && ClubiFileUploadIndustry.HasFile
                    )
            {
                string filePath = UploadFile(ClubiFileUploadIndustry);

                var newStudent = new StudentClub()
                {
                    Images = filePath,
                    Name = txtIndustryName.Text,
                    Content = txtIndustryContent.Text,
                    Link = txtIndustryLink.Text,

                };
                StudentClubBLL.EditStudentClub(newStudent, GetEventId());

            }
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            TextBox textBox = ClubiFileUploadIndustry.FindControl(typeof(EventLists) + "ID") as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                int.TryParse(textBox.Text, out eventId);
            }
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