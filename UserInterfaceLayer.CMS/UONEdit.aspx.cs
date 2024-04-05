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
    public partial class UONEdit : System.Web.UI.Page
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
                        case "UoN":
                            var student = StudentClubBLL.GetByIdDTO(id);
                            if (student != null)
                            {
                                TextBox dynamicTextBox = new TextBox();
                                dynamicTextBox.ID = typeof(StudentClub) + "ID";
                                dynamicTextBox.Text = student.id.ToString();

                                UoNFileUploadRank.Controls.Add(dynamicTextBox);
                                txtRank.Controls.Add(dynamicTextBox);
                                txtRankDescription.Controls.Add(dynamicTextBox);

                            }
                            break;
                        default:
                            break;
                    }
                }
            }

        }
        protected void btnAddRank_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRankDescription.Text.Trim()) && !string.IsNullOrEmpty(txtRank.Text.Trim()) && UoNFileUploadRank.HasFile
                    )
            {
                string filePath = UploadFile(UoNFileUploadRank);
                int type = UoNConstant.Overviewuon;
                var newUoN = new UoN()
                {
                    Images = filePath,
                    UoNType = type,
                    Rank = int.Parse(txtRank.Text),
                    Description = txtRankDescription.Text
                };
                UONBLL.EditUOn(newUoN, GetEventId());
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
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            TextBox textBox = UoNFileUploadRank.FindControl(typeof(EventLists) + "ID") as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                int.TryParse(textBox.Text, out eventId);
            }
            return eventId;
        }

    }
}