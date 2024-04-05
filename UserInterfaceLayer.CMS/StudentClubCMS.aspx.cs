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
    public partial class StudentClubCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadIndustry();
            LoadInterest();
            LoadInternational();
            TitlePageClub();


        }

        public void TitlePageClub()
        {
            TitlePageCLUB.Rows.Clear();

            var listLevel1 = StudentClubBLL.GetByType(StudentClubConstant.TitleClub);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic500";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width90";
                row.Cells.Add(cell1);

                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditPSBCTitle_Click;
                cell5.Controls.Add(editButton);

                row.Cells.Add(cell5);


                TitlePageCLUB.Rows.Add(row);
            }
        }
        public void EditPSBCTitle_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=StudentClub" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={StudentClubConstant.TitleClub}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void LoadIndustry()
        {
            Industry_tbl.Rows.Clear();

            var listLevel1 = StudentClubBLL.GetByType(StudentClubConstant.Industry);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width10";
                row.Cells.Add(cell1);


                TableCell cell2 = new TableCell();
                Label label2 = new Label();
                label2.CssClass = "size15";
                label2.Text = item.Name;
                cell2.Controls.Add(label2);
                cell2.CssClass = "width15";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label label3 = new Label();
                label3.CssClass = "size10";
                label3.Text = item.Content;
                cell3.Controls.Add(label3);
                cell3.CssClass = "width50";
                row.Cells.Add(cell3);


                TableCell cell4 = new TableCell();
                Label label4 = new Label();
                label4.CssClass = "size10";
                label4.Text = item.Link;
                cell4.Controls.Add(label4);
                cell4.CssClass = "width15";
                row.Cells.Add(cell4);


                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;
                cell5.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += DeleteIndustryClick_Click;
                cell5.Controls.Add(deleteButton);
                row.Cells.Add(cell5);


                Industry_tbl.Rows.Add(row);
            }
        }

        public void LoadInterest()
        {



            Interest_tbl.Rows.Clear();

            var listLevel1 = StudentClubBLL.GetByType(StudentClubConstant.Interest);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width10";
                row.Cells.Add(cell1);


                TableCell cell2 = new TableCell();
                Label label2 = new Label();
                label2.CssClass = "size15";
                label2.Text = item.Name;
                cell2.Controls.Add(label2);
                cell2.CssClass = "width15";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label label3 = new Label();
                label3.CssClass = "size10";
                label3.Text = item.Content;
                cell3.Controls.Add(label3);
                cell3.CssClass = "width50";
                row.Cells.Add(cell3);


                TableCell cell4 = new TableCell();
                Label label4 = new Label();
                label4.CssClass = "size10";
                label4.Text = item.Link;
                cell4.Controls.Add(label4);
                cell4.CssClass = "width15";
                row.Cells.Add(cell4);


                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;
                cell5.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Deleteinterrest_Click;
                cell5.Controls.Add(deleteButton);
                row.Cells.Add(cell5);


                Interest_tbl.Rows.Add(row);
            }
        }

        public void LoadInternational()
        {
            International_tbl.Rows.Clear();

            var listLevel1 = StudentClubBLL.GetByType(StudentClubConstant.International);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width10";
                row.Cells.Add(cell1);


                TableCell cell2 = new TableCell();
                Label label2 = new Label();
                label2.CssClass = "size15";
                label2.Text = item.Name;
                cell2.Controls.Add(label2);
                cell2.CssClass = "width15";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label label3 = new Label();
                label3.CssClass = "size10";
                label3.Text = item.Content;
                cell3.Controls.Add(label3);
                cell3.CssClass = "width50";
                row.Cells.Add(cell3);


                TableCell cell4 = new TableCell();
                Label label4 = new Label();
                label4.CssClass = "size10";
                label4.Text = item.Link;
                cell4.Controls.Add(label4);
                cell4.CssClass = "width15";
                row.Cells.Add(cell4);


                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;
                cell5.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click1;
                cell5.Controls.Add(deleteButton);
                row.Cells.Add(cell5);



                International_tbl.Rows.Add(row);
            }
        }


        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("StudentClubEdit.aspx?id=" + id.ToString() + $"&type={typeof(StudentClub).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }

        public void Delete_Click1(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            StudentClubBLL.DeleteStudentClub(id);
            LoadInternational();



        }
        public void Deleteinterrest_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            StudentClubBLL.DeleteStudentClub(id);
            LoadInterest();



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
        public void ClearIndustry()
        {
            txtIndustryLink.Text = string.Empty;
            txtIndustryName.Text = string.Empty;
            txtIndustryContent.Text = string.Empty;
            ClubiFileUploadIndustry.Dispose();
        }
        public void ClearInterest()
        {
            txtInterestName.Text = string.Empty;
            txtInterestLink.Text = string.Empty;
            txtInterestContent.Text = string.Empty;
            ClubiFileUploadInterest.Dispose();
        }
        public void ClearInternational()
        {
            txtInternationalName.Text = string.Empty;
            txtInternationalLink.Text = string.Empty;
            txtInternationalContent.Text = string.Empty;
            ClubiFileUploadInternational.Dispose();
        }

        public void DeleteTitleClick_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            StudentClubBLL.DeleteStudentClub(id);
            TitlePageClub();
        }
        public void DeleteIndustryClick_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            StudentClubBLL.DeleteStudentClub(id);
            LoadIndustry();
        }

        protected void btnAddIndustry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIndustryContent.Text.Trim()) && !string.IsNullOrEmpty(txtIndustryLink.Text.Trim()) && !string.IsNullOrEmpty(txtIndustryName.Text.Trim()) && ClubiFileUploadIndustry.HasFile
                    )
            {
                string filePath = UploadFile(ClubiFileUploadIndustry);
                int type = StudentClubConstant.Industry;
                var newStudent = new StudentClub()
                {
                    Images = filePath,
                    Name = txtIndustryName.Text,
                    Content = txtIndustryContent.Text,
                    Link = txtIndustryLink.Text,
                    StudentClubType = type
                };
                StudentClubBLL.AddStudentClub(newStudent);
                LoadIndustry();
                LoadInterest();
                LoadInternational();
            }
        }

        protected void btnCancelIndustry_Click(object sender, EventArgs e)
        {
            LoadIndustry();
            LoadInterest();
            LoadInternational();
        }

        protected void btnAddInterest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInterestContent.Text.Trim()) && !string.IsNullOrEmpty(txtInterestLink.Text.Trim()) && !string.IsNullOrEmpty(txtInterestName.Text.Trim()) && ClubiFileUploadInterest.HasFile
                    )
            {
                string filePath = UploadFile(ClubiFileUploadInterest);
                int type = StudentClubConstant.Interest;
                var newStudent = new StudentClub()
                {
                    Images = filePath,
                    Name = txtInterestName.Text,
                    Content = txtInterestContent.Text,
                    Link = txtInterestLink.Text,
                    StudentClubType = type
                };
                StudentClubBLL.AddStudentClub(newStudent);
                LoadIndustry();
                LoadInterest();
                LoadInternational();
            }
        }

        protected void btnCancelInterest_Click(object sender, EventArgs e)
        {
            LoadIndustry();
            LoadInterest();
            LoadInternational();
        }

        protected void btnAddInternational_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInternationalContent.Text.Trim()) && !string.IsNullOrEmpty(txtInternationalLink.Text.Trim()) && !string.IsNullOrEmpty(txtInternationalName.Text.Trim()) && ClubiFileUploadInternational.HasFile
                    )
            {
                string filePath = UploadFile(ClubiFileUploadInternational);
                int type = StudentClubConstant.International;
                var newStudent = new StudentClub()
                {
                    Images = filePath,
                    Name = txtInternationalName.Text,
                    Content = txtInternationalContent.Text,
                    Link = txtInternationalLink.Text,
                    StudentClubType = type
                };
                StudentClubBLL.AddStudentClub(newStudent);
                LoadIndustry();
                LoadInterest();
                LoadInternational();
            }
        }

        protected void btnCancelInternational_Click(object sender, EventArgs e)
        {
            txtInternationalName.Text = string.Empty;
            txtInternationalLink.Text = string.Empty;
            txtInternationalContent.Text = string.Empty;
            ClubiFileUploadInternational.Dispose();
        }
    }
}