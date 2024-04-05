using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class LocationCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title();
            LoadCampus();
            LoadMrt();
            LoadBus();
        }


        public void LoadCampus()
        {
            campus_tbl.Rows.Clear();

            var listcampus = LocaltionBLL.GetByType(LocalTionConstant.Campus);

            foreach (var item in listcampus)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Label label = new Label();
                label.CssClass = "size15";
                label.Text = item.LocaltionName;
                cell1.Controls.Add(label);
                cell1.CssClass = "width45";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label label2 = new Label();
                label2.CssClass = "size15";
                label2.Text = item.LocaltionAddress;
                cell2.Controls.Add(label2);
                cell2.CssClass = "width45";

                row.Cells.Add(cell2);

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


                campus_tbl.Rows.Add(row);
            }
        }


        public void LoadMrt()
        {
            cmstitledivcover_tbl.Rows.Clear();

            var listcmstitle = LocaltionBLL.GetByType(LocalTionConstant.MRT);

            foreach (var item in listcmstitle)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Label label = new Label();
                label.CssClass = "size15";
                label.Text = item.LineColour;
                cell1.Controls.Add(label);
                cell1.CssClass = "width30";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label label2 = new Label();
                label2.CssClass = "size15";
                label2.Text = item.LocaltionName;
                cell2.Controls.Add(label2);
                cell2.CssClass = "width40";

                row.Cells.Add(cell2);



                TableCell cell3 = new TableCell();
                Label label3 = new Label();
                label3.CssClass = "size15";
                label3.Text = item.Distance.ToString() + "m";
                cell3.Controls.Add(label3);
                cell3.CssClass = "width10";

                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                Label label4 = new Label();
                label4.CssClass = "size15";
                label4.Text = item.Minutes.ToString() + "mins";
                cell4.Controls.Add(label4);
                cell4.CssClass = "width10";

                row.Cells.Add(cell4);



                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click2;

                // Gắn sự kiện cho nút EDIT ở đây
                cell5.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.Id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;

                // Gắn sự kiện cho nút DELETE ở đây
                cell5.Controls.Add(deleteButton);

                row.Cells.Add(cell5);


                cmstitledivcover_tbl.Rows.Add(row);
            }
        }


        public void LoadBus()
        {
            bus_tbl.Rows.Clear();

            var listcmstitle = LocaltionBLL.GetByType(LocalTionConstant.Bus);

            foreach (var item in listcmstitle)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Label label = new Label();
                label.CssClass = "size15";
                label.Text = item.LocaltionName;
                cell1.Controls.Add(label);
                cell1.CssClass = "width20";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label label2 = new Label();
                label2.CssClass = "size15";
                label2.Text = item.BusNumbers;
                cell2.Controls.Add(label2);
                cell2.CssClass = "width70";

                row.Cells.Add(cell2);



                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += Edit_Click3;
                // Gắn sự kiện cho nút EDIT ở đây
                cell5.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.Id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;

                // Gắn sự kiện cho nút DELETE ở đây
                cell5.Controls.Add(deleteButton);

                row.Cells.Add(cell5);


                bus_tbl.Rows.Add(row);
            }
        }

        public void Title()
        {
            tbTitle.Rows.Clear();

            var listLevel1 = LocaltionBLL.GetByType(LocalTionConstant.Title);

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
                editButton.CommandArgument = item.Id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditTitle_Click;

                // Gắn sự kiện cho nút EDIT ở đây
                cell4.Controls.Add(editButton);
                row.Cells.Add(cell4);


                tbTitle.Rows.Add(row);
            }
        }
        public void Clear()
        {
            txtCampusName.Text = string.Empty;
            txtCampusLocation.Text = string.Empty;
        }
        public void ClearMRT()
        {
            txtMrtColour.Text = string.Empty;
            txtMrtName.Text = string.Empty;
            txtMrtMins.Text = string.Empty;
            txtMrtLong.Text = string.Empty;
        }
        public void ClearBus()
        {
            txtBusName.Text = string.Empty;
            txtBusNumber.Text = string.Empty;
        }
        protected void btnAddCampus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCampusName.Text.Trim()) && !string.IsNullOrEmpty(txtCampusLocation.Text.Trim()))
            {
                int type = LocalTionConstant.Campus;
                var newLocalTion = new LocalTion()
                {
                    LocaltionName = txtCampusName.Text,
                    LocaltionAddress = txtCampusLocation.Text,
                    LocaltionType = type,
                };
                LocaltionBLL.AddLocaltion(newLocalTion);
                Clear();

                //Load lai trang
                LoadCampus();
                Response.Redirect(Request.Url.AbsoluteUri);

            }
        }
        public void EditTitle_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=Location" + $"&prevURL={Request.Url.AbsoluteUri}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }

        protected void btnCancelCampus_Click(object sender, EventArgs e)
        {
            txtCampusName.Text = string.Empty;
            txtCampusLocation.Text = string.Empty;
        }



        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit.aspx?id=" + id.ToString() + $"&type={typeof(LocalTion).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

        }
        public void Edit_Click2(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Editlocation2.aspx?id=" + id.ToString() + $"&type={typeof(LocalTion).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

        }
        public void Edit_Click3(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("EditLocation3.aspx?id=" + id.ToString() + $"&type={typeof(LocalTion).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal

        }
        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            LocalTionDAL.DeleteLocaltion(id);
            LoadCampus();
            LoadMrt();
            LoadBus();

            // Buộc trang web tải lại hoàn toàn
            Response.Redirect(Request.Url.AbsoluteUri);


        }

        protected void btnAddMrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMrtColour.Text.Trim()) && !string.IsNullOrEmpty(txtMrtName.Text.Trim()) && !string.IsNullOrEmpty(txtMrtLong.Text.Trim()) && !string.IsNullOrEmpty(txtMrtMins.Text.Trim()))
            {
                int type = LocalTionConstant.MRT;
                var newLocalTion = new LocalTion()
                {
                    LineColour = txtMrtColour.Text,
                    LocaltionName = txtMrtName.Text,
                    LocaltionType = type,
                    Distance = decimal.Parse(txtMrtLong.Text),
                    Minutes = int.Parse(txtMrtMins.Text),
                };
                LocaltionBLL.AddLocaltion(newLocalTion);
                ClearMRT();

                //Load lai trang
                LoadMrt();
                Response.Redirect(Request.Url.AbsoluteUri);

            }
        }


        protected void btnCancelMrt_Click(object sender, EventArgs e)
        {
            ClearMRT();
        }

        protected void btnAddBus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusNumber.Text.Trim()) && !string.IsNullOrEmpty(txtBusName.Text.Trim()))
            {
                int type = LocalTionConstant.Bus;
                var newLocalTion = new LocalTion()
                {
                    LocaltionName = txtBusName.Text,
                    BusNumbers = txtBusNumber.Text,
                    LocaltionType = type,
                };
                LocaltionBLL.AddLocaltion(newLocalTion);
                ClearBus();

                //Load lai trang
                LoadBus();
                Response.Redirect(Request.Url.AbsoluteUri);

            }
        }

        protected void btnCancelBus_Click(object sender, EventArgs e)
        {
            ClearBus();
        }
    }
}