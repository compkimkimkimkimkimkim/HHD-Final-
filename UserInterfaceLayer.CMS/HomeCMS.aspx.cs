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
    public partial class HomeCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Event();
            muc4();
            Campus();
            UniInfo();
            Community();
        }
        public void Event()
        {
            TitlePage_tbl.Rows.Clear();

            var listLevel1 = HomeBLL.GetByType(HomeConstant.CurrentEventList);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Image);
                cell1.Controls.Add(image);
                cell1.CssClass = "width95";
                row.Cells.Add(cell1);

                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.IdHome.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditEVent_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell3.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.IdHome.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += DeleteEvent_Click;

                // Gắn sự kiện cho nút DELETE ở đây
                cell3.Controls.Add(deleteButton);
                row.Cells.Add(cell3);
                TitlePage_tbl.Rows.Add(row);
            }
        }
        public void Campus()
        {
            tbCampus.Rows.Clear();

            var listLevel1 = HomeBLL.GetByType(HomeConstant.CampusLifeSection);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Image);
                cell1.Controls.Add(image);
                cell1.CssClass = "width45";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Name.ToString();
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width50";
                row.Cells.Add(cell2);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.IdHome.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditHomeCampus_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell4.Controls.Add(editButton);
                row.Cells.Add(cell4);


                tbCampus.Rows.Add(row);
            }
        }
        public void UniInfo()
        {
            tbUniInfo.Rows.Clear();

            var listLevel1 = HomeBLL.GetByType(HomeConstant.UniInfoSection);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell2 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Description.ToString();
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width90";
                row.Cells.Add(cell2);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.IdHome.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditHomeUniInfo_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell4.Controls.Add(editButton);
                row.Cells.Add(cell4);


                tbUniInfo.Rows.Add(row);
            }
        }
        public void Community()
        {
            tbCommunity.Rows.Clear();

            var listLevel1 = HomeBLL.GetByType(HomeConstant.CommunicateWithFriends);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic300";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Image);
                cell1.Controls.Add(image);
                cell1.CssClass = "width45";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Description.ToString();
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width45";
                row.Cells.Add(cell2);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.IdHome.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditHomeCommunity_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell4.Controls.Add(editButton);
                row.Cells.Add(cell4);


                tbCommunity.Rows.Add(row);
            }
        }
        public void muc4()
        {
            Testimonial.Rows.Clear();

            var listLevel1 = HomeBLL.GetByType(HomeConstant.Testimonial);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell3 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Link + "";
                cell3.Controls.Add(lb2);
                cell3.CssClass = "width50";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width120";
                editButton.CommandArgument = item.IdHome.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditHomeTestimonial_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell4.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.IdHome.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Deletemuc4;


                cell4.CssClass = "width10";
                // Gắn sự kiện cho nút DELETE ở đây
                cell4.Controls.Add(deleteButton);
                row.Cells.Add(cell4);


                Testimonial.Rows.Add(row);
            }
        }
        public void EditMUC4_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditHome4.aspx?id=" + id.ToString() + $"&type={typeof(Home).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditHomeTestimonial_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(Home).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={HomeConstant.Testimonial}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditHomeCampus_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(Home).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={HomeConstant.CampusLifeSection}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditHomeCommunity_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(Home).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={HomeConstant.CommunicateWithFriends}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditHomeUniInfo_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(Home).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={HomeConstant.UniInfoSection}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void Deletemuc4(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            HomeBLL.DeleteHome(id);
            muc4();
            Response.Redirect(Request.Url.AbsoluteUri);
        }




        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("EditHome2.aspx?id=" + id.ToString() + $"&type={typeof(Home).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
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


        protected void btnAddEVENTPoster_Click(object sender, EventArgs e)
        {
            if (TitlePageFileUploadposter.HasFile)
            {
                int type = HomeConstant.CurrentEventList;
                string filePath = UploadFile(TitlePageFileUploadposter);
                var eventTypeCurrent = new Home()
                {
                    Image = filePath,
                    category = type,

                };
                HomeBLL.AddHome(eventTypeCurrent);

                Event();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        public void btnAddTestimonial_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtlink.Text))
            {
                int type = HomeConstant.Testimonial;
                var linkTestimonial = new Home()
                {
                    Link = txtlink.Text,
                    category = type
                };
                HomeBLL.AddHome(linkTestimonial);
                muc4();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }

        protected void btnCancelTestimonial_Click(object sender, EventArgs e)
        {
            txtlink.Text = string.Empty;
        }
        public void EditEVent_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditHome.aspx?id=" + id.ToString() + $"&type={typeof(Home).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

            Event();
        }
        public void DeleteEvent_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            HomeBLL.DeleteHome(id);
            Event();
            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }
}