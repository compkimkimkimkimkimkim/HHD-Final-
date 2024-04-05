using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.Models;
using HHD.UserInterfaceLayer.Site;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class AboutUsCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTitle();
            LoadProject();
            LoadTools();

        }

        public void GetTitle()
        {
            tbTitle.Rows.Clear();

            var listLevel1 = AboutUsBLL.GetByType(AboutUsConstant.Title);

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

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditTitle_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell4.Controls.Add(editButton);
                row.Cells.Add(cell4);


                tbTitle.Rows.Add(row);
            }
        }
        public void EditTitle_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=AboutUs" + $"&prevURL={Request.Url.AbsoluteUri}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void LoadProject()
        {
            Project_tbl.Rows.Clear();

            var listLevel1 = AboutUsBLL.GetByType(AboutUsConstant.Member);

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
                Label lb = new Label();
                lb.CssClass = "size15";
                lb.Text = item.Name;
                cell2.Controls.Add(lb);
                cell2.CssClass = "width15";
                row.Cells.Add(cell2);



                TableCell cell3 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Major;
                cell3.Controls.Add(lb2);
                cell3.CssClass = "width15";
                row.Cells.Add(cell3);



                TableCell cell4 = new TableCell();
                Label lb3 = new Label();
                lb3.CssClass = "size15";
                lb3.Text = item.Ambitions;
                cell4.Controls.Add(lb3);
                cell4.CssClass = "width50";
                row.Cells.Add(cell4);



                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell5.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;

                // Gắn sự kiện cho nút DELETE ở đây
                cell5.Controls.Add(deleteButton);
                row.Cells.Add(cell5);


                Project_tbl.Rows.Add(row);
            }
        }



        public void ClearTools()
        {
            txtToolName.Text = string.Empty;
        }
        public void ClearProject()
        {
            txtMemebrName.Text = string.Empty;
            txtMemebrAmbition.Text = string.Empty;
            txtMemebrMajor.Text = string.Empty;
            aboutusFileUploadmember.Dispose();
        }


        public void LoadTools()
        {
            Toolst_tbl.Rows.Clear();

            var listLevel1 = AboutUsBLL.GetByType(AboutUsConstant.tool);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();

                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width45";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label lb3 = new Label();
                lb3.CssClass = "size15";
                lb3.Text = item.Name;
                cell2.Controls.Add(lb3);
                cell2.CssClass = "width45";
                row.Cells.Add(cell2);



                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click2;

                // Gắn sự kiện cho nút EDIT ở đây
                cell3.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;

                // Gắn sự kiện cho nút DELETE ở đây
                cell3.Controls.Add(deleteButton);
                row.Cells.Add(cell3);


                Toolst_tbl.Rows.Add(row);
            }
        }
        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Editaboutus.aspx?id=" + id.ToString() + $"&type={typeof(HHD.Models.AboutUs).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

        }
        public void Edit_Click2(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Editaboutus2.aspx?id=" + id.ToString() + $"&type={typeof(HHD.Models.AboutUs).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

        }
        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            AboutUsBLL.DeletePSBC(id);
            LoadProject();
            LoadTools();
        }
        protected void btnAddMemebr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMemebrName.Text.Trim()) && !string.IsNullOrEmpty(txtMemebrAmbition.Text.Trim()) && !string.IsNullOrEmpty(txtMemebrMajor.Text.Trim()) && aboutusFileUploadmember.HasFile)
            {
                string filePath = UploadFile(aboutusFileUploadmember);
                int type = AboutUsConstant.Member;
                var newAbout = new HHD.Models.AboutUs()
                {
                    Images = filePath,
                    Name = txtMemebrName.Text,
                    Ambitions = txtMemebrAmbition.Text,
                    Major = txtMemebrMajor.Text,
                    AboutUsType = type,
                };
                AboutUsBLL.AddAbout(newAbout);
                ClearProject();
                LoadProject();
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

        protected void btnCancelMemebr_Click(object sender, EventArgs e)
        {
            ClearProject();
        }

        protected void btnAddTool_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToolName.Text.Trim()) && aboutusFileUploadtool.HasFile)
            {
                string filePath = UploadFile(aboutusFileUploadtool);
                int type = AboutUsConstant.tool;
                var newAbout = new HHD.Models.AboutUs()
                {
                    Images = filePath,
                    Name = txtToolName.Text,
                    AboutUsType = type,
                };
                AboutUsBLL.AddAbout(newAbout);
                ClearTools();
                LoadTools();
            }
        }

        protected void btnCancelTool_Click(object sender, EventArgs e)
        {
            ClearTools();
        }
    }
}