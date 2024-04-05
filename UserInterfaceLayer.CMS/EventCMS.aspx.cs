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

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EventCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TitlePage();
            LoadCurrent();
            LoadUpdate();
            LoadPast();

        }

        public void TitlePage()
        {
            TitlePage_tbl.Rows.Clear();

            var listLevel1 = EventListsBLL.GetByType(EventListsConstant.Title);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic500";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.EventPoster);
                cell1.Controls.Add(image);
                cell1.CssClass = "width90";
                row.Cells.Add(cell1);

                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditTitle_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell3.Controls.Add(editButton);

                row.Cells.Add(cell3);


                TitlePage_tbl.Rows.Add(row);
            }
        }
        public void EditTitle_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=EventLists" + $"&prevURL={Request.Url.AbsoluteUri}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void LoadUpdate()
        {
            Upcoming_tbl.Rows.Clear();

            var listLevel1 = EventListsBLL.GetByType(EventListsConstant.UpComing);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.EventPoster);
                cell1.Controls.Add(image);
                cell1.CssClass = "width90";
                row.Cells.Add(cell1);

                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click2;

                // Gắn sự kiện cho nút EDIT ở đây
                cell3.Controls.Add(editButton);
                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.Id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click2;

                // Gắn sự kiện cho nút DELETE ở đây
                cell3.Controls.Add(deleteButton);
                row.Cells.Add(cell3);


                Upcoming_tbl.Rows.Add(row);
            }
        }

        public void LoadPast()
        {
            Past_tbl.Rows.Clear();

            var listLevel1 = EventListsBLL.GetByType(EventListsConstant.Past);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();

                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.EventPoster);
                cell1.Controls.Add(image);
                cell1.CssClass = "width90";
                row.Cells.Add(cell1);



                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click3;

                // Gắn sự kiện cho nút EDIT ở đây
                cell3.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.Id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click3;

                // Gắn sự kiện cho nút DELETE ở đây
                cell3.Controls.Add(deleteButton);
                row.Cells.Add(cell3);


                Past_tbl.Rows.Add(row);
            }
        }

        public void LoadCurrent()
        {
            Current_tbl.Rows.Clear();

            var listLevel1 = EventListsBLL.GetByType(EventListsConstant.Currnet);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.EventPoster);
                cell1.Controls.Add(image);
                cell1.CssClass = "width90";
                row.Cells.Add(cell1);



                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell3.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.Id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;

                // Gắn sự kiện cho nút DELETE ở đây
                cell3.Controls.Add(deleteButton);
                row.Cells.Add(cell3);


                Current_tbl.Rows.Add(row);
            }
        }

        public void Clear()
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

        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditEventList.aspx?id=" + id.ToString() + $"&type={typeof(EventLists).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
            LoadCurrent();
        }
        public void Edit_ClickTile(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditEventList.aspx?id=" + id.ToString() + $"&type={typeof(EventLists).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
            TitlePage();
        }
        public void Edit_Click2(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditEventList.aspx?id=" + id.ToString() + $"&type={typeof(EventLists).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
            LoadUpdate();
        }
        public void Edit_Click3(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditEventList.aspx?id=" + id.ToString() + $"&type={typeof(EventLists).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
            LoadPast();
        }
        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            EventListsBLL.DeleteEvent(id);
            LoadCurrent();
            Response.Redirect(Request.Url.AbsoluteUri);


        }
        public void Delete_Click2(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            EventListsBLL.DeleteEvent(id);

            LoadPast();
            Response.Redirect(Request.Url.AbsoluteUri);


        }
        public void Delete_Click3(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            EventListsBLL.DeleteEvent(id);

            LoadUpdate();
            Response.Redirect(Request.Url.AbsoluteUri);

        }
        public void Delete_ClickTitlePage(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            EventListsBLL.DeleteEvent(id);

            TitlePage();
            Response.Redirect(Request.Url.AbsoluteUri);


        }
        protected void btnAddcureventPoster_Click(object sender, EventArgs e)
        {
            if (currenteventFileUploadposter.HasFile)
            {
                int type = EventListsConstant.Currnet;
                string filePath = UploadFile(currenteventFileUploadposter);
                var eventTypeCurrent = new EventLists()
                {
                    EventPoster = filePath,
                    EventType = type,
                };
                EventListsBLL.AddEvent(eventTypeCurrent);

                Clear();

                LoadCurrent();
                LoadPast();
                LoadUpdate();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancelcureventPoster_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddupeventPoster_Click(object sender, EventArgs e)
        {
            if (upeventFileUploadposter.HasFile)
            {
                int type = EventListsConstant.UpComing;
                string filePath = UploadFile(upeventFileUploadposter);
                var eventTypeCurrent = new EventLists()
                {
                    EventPoster = filePath,
                    EventType = type,
                };
                EventListsBLL.AddEvent(eventTypeCurrent);
                Clear();
                //Load lai trang
                LoadCurrent();
                LoadPast();
                LoadUpdate();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }

        protected void btnCancelupeventPoster_Click(object sender, EventArgs e)
        {

        }
        protected void btnAddpasteventPoster_Click(object sender, EventArgs e)
        {
            if (pasteventFileUploadposter.HasFile)
            {
                int type = EventListsConstant.Past;
                string filePath = UploadFile(pasteventFileUploadposter);
                var eventTypeCurrent = new EventLists()
                {
                    EventPoster = filePath,
                    EventType = type,
                };
                EventListsBLL.AddEvent(eventTypeCurrent);

                //Load lai trang
                LoadCurrent();
                LoadPast();
                LoadUpdate();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }

        protected void btnCancelpasteventPoster_Click(object sender, EventArgs e)
        {

        }
    }
}