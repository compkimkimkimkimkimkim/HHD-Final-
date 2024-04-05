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
    public partial class OrientationCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTitle();
            LoadToDo();
            LoadFAQ();
        }

        public void GetTitle()
        {
            tbWelcome.Rows.Clear();

            var listLevel1 = OrientationBLL.GetByType(OrientationConstant.Welcome);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell2 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Title + "";
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width30";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Content + "";
                cell3.Controls.Add(lb2);
                cell3.CssClass = "width65";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width5";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditTitle_Click;
                cell4.Controls.Add(editButton);
                row.Cells.Add(cell4);


                tbWelcome.Rows.Add(row);
            }
        }

        public void EditTitle_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=Orientation" + $"&prevURL={Request.Url.AbsoluteUri}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void LoadToDo()
        {
            To_do_tbl.Rows.Clear();
            var listLevel1 = OrientationBLL.GetByType(OrientationConstant.ToDo);

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
                lb.Text = item.Title;
                cell2.Controls.Add(lb);
                cell2.CssClass = "width20";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label lb3 = new Label();
                lb3.CssClass = "size10";
                lb3.Text = item.Content;
                cell3.Controls.Add(lb3);
                cell3.CssClass = "width60";
                row.Cells.Add(cell3);


                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;
                cell4.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;
                cell4.CssClass = "width10";
                cell4.Controls.Add(deleteButton);

                row.Cells.Add(cell4);


                To_do_tbl.Rows.Add(row);
            }
        }
        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Editorentation.aspx?id=" + id.ToString() + $"&type={typeof(HHD.Models.Orientation).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

        }
        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            OrientationBLL.DeleteOrientation(id);
            LoadToDo();

            LoadFAQ();
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        public void LoadFAQ()
        {
            FAQ_tbl.Rows.Clear();

            var listLevel1 = OrientationBLL.GetByType(OrientationConstant.FAQ);
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
                lb.Text = item.Title;
                cell2.Controls.Add(lb);
                cell2.CssClass = "width20";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label lb3 = new Label();
                lb3.CssClass = "size10";
                lb3.Text = item.Content;
                cell3.Controls.Add(lb3);
                cell3.CssClass = "width60";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;
                cell4.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;

                cell4.Controls.Add(deleteButton);
                row.Cells.Add(cell4);

                FAQ_tbl.Rows.Add(row);
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
        public void ClearFAQ()
        {

            txtFAQQuestion.Text = string.Empty;
            txtFAQContent.Text = string.Empty;
            oriFileUploadFAQ.Dispose();
        }
        public void ClearToDo()
        {
            txtTodoContent.Text = string.Empty;
            txtTodoTitle.Text = string.Empty;
            oriFileUploadTodo.Dispose();
        }
        protected void btnAddTodo_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTodoContent.Text.Trim()) && !string.IsNullOrEmpty(txtTodoTitle.Text.Trim()) && oriFileUploadTodo.HasFile
                    )
            {
                string filePath = UploadFile(oriFileUploadTodo);
                int type = OrientationConstant.ToDo;
                var newOrientation = new HHD.Models.Orientation()
                {
                    Images = filePath,
                    OrientationType = type,
                    Content = txtTodoContent.Text,
                    Title = txtTodoTitle.Text,
                };
                OrientationBLL.AddOrientation(newOrientation);

                ClearToDo();
                LoadToDo();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancelTodo_Click(object sender, EventArgs e)
        {
            ClearToDo();
        }
        protected void btnAddFAQ_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFAQQuestion.Text.Trim()) && !string.IsNullOrEmpty(txtFAQContent.Text.Trim()) && oriFileUploadFAQ.HasFile
                    )
            {
                string filePath = UploadFile(oriFileUploadFAQ);
                int type = OrientationConstant.FAQ;
                var newOrientation = new HHD.Models.Orientation()
                {
                    Images = filePath,
                    OrientationType = type,
                    Content = txtFAQContent.Text,
                    Title = txtFAQQuestion.Text,
                };
                OrientationBLL.AddOrientation(newOrientation);

                ClearFAQ();
                LoadFAQ();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancelFAQ_Click(object sender, EventArgs e)
        {
            ClearFAQ();
        }
    }
}