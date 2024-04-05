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
    public partial class PSBCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TitlePSB();
            OverViewPSB();

            LoadUni();
            LoadOther();
        }
        public void TitlePSB()
        {
            TitlePSB_pln.Rows.Clear();
            var listLevel1 = PSBCBLL.GetByType(PSBCConstant.TitlePSb);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic200";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width20";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Title.ToString();
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width20";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Content.ToString();
                cell3.Controls.Add(lb2);
                cell3.CssClass = "width50";
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell4.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditPSBCTitle_Click;

                cell4.Controls.Add(editButton);


                row.Cells.Add(cell4);

                TitlePSB_pln.Rows.Add(row);
            }
        }
        public void OverViewPSB()
        {
            Overview_pln.Rows.Clear();
            var listLevel1 = PSBCBLL.GetByType(PSBCConstant.OverViewPSB);

            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic100";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width20";
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                Label lb = new Label();
                lb.CssClass = "size15";
                lb.Text = item.Title;
                cell2.Controls.Add(lb);
                cell2.CssClass = "width70";
                row.Cells.Add(cell2);



                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditPSBCOverView_Click;
                cell3.Controls.Add(editButton);
                row.Cells.Add(cell3);

                Overview_pln.Rows.Add(row);
            }
        }
        public void LoadUni()
        {
            University_tbl.Rows.Clear();
            var listLevel1 = PSBCBLL.GetByType(PSBCConstant.University);

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
                Label lb = new Label();
                lb.CssClass = "size15";
                lb.Text = item.Name;
                cell2.Controls.Add(lb);
                cell2.CssClass = "width45";
                row.Cells.Add(cell2);



                TableCell cell3 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell3.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditPSBCPartner_Click;
                cell3.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += Delete_Click;
                cell3.Controls.Add(deleteButton);
                row.Cells.Add(cell3);

                University_tbl.Rows.Add(row);
            }
        }
        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("EditPSB.aspx?id=" + id.ToString() + $"&type={typeof(PSBC).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditPSBCOverView_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(PSBC).Name}" + $"&prevURL={Request.Url.AbsoluteUri}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditPSBCTitle_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(PSBC).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={PSBCConstant.TitlePSb}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }

        public void EditPSBCPartner_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(PSBC).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={PSBCConstant.University}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            PSBCBLL.DeletePSBC(id);
            TitlePSB();
            OverViewPSB();

            LoadUni();
            LoadOther();
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        public void DeleteTitlePSB_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            PSBCBLL.DeletePSBC(id);
            TitlePSB();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        public void DeleteOverView_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            PSBCBLL.DeletePSBC(id);
            OverViewPSB();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        public void ClearUni()
        {
            txtUniName.Text = string.Empty;
            PSBFileUploadUni.Dispose();
        }
        public void ClearContent()
        {
            txtContentContent.Text = string.Empty;
            txtContentTitle.Text = string.Empty;
            PSBFileUploadNew.Dispose();

        }
        public void LoadOther()
        {
            Other_tbl.Rows.Clear();

            var listLevel1 = PSBCBLL.GetByType(PSBCConstant.Other);
            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();

                TableCell cell2 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Title.ToString();
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width10";
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Content.ToString();
                cell3.Controls.Add(lb2);
                cell3.CssClass = "width50";
                row.Cells.Add(cell3);

                TableCell cell1 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic300";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell1.Controls.Add(image);
                cell1.CssClass = "width30";
                row.Cells.Add(cell1);

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

                Other_tbl.Rows.Add(row);
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
                int type = PSBCConstant.University;
                var newPSBC = new PSBC()
                {
                    Images = filePath,
                    PSBCType = type,
                    Name = txtUniName.Text,
                };
                PSBCBLL.AddPSBC(newPSBC);
                ClearUni();
                LoadUni();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancelUni_Click(object sender, EventArgs e)
        {
            ClearUni();
        }
        protected void btnAddContent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContentTitle.Text.Trim()) && !string.IsNullOrEmpty(txtContentContent.Text.Trim()) && PSBFileUploadNew.HasFile)
            {
                string filePath = UploadFile(PSBFileUploadNew);
                int type = PSBCConstant.Other;
                var newPSBC = new PSBC()
                {
                    Images = filePath,
                    PSBCType = type,
                    Content = txtContentContent.Text,
                    Title = txtContentTitle.Text,
                };
                PSBCBLL.AddPSBC(newPSBC);
                ClearContent();
                LoadOther();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancelContent_Click(object sender, EventArgs e)
        {
            ClearContent();
        }
    }
}