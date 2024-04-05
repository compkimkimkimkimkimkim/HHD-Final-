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
    public partial class UoNCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TitleUON();
            LoadUoNRanking();
            OverViewUoN();
            LoadOther();
        }
        public void TitleUON()
        {
            titlene.Rows.Clear();

            var listLevel1 = UONBLL.GetByType(UoNConstant.TitleOUN);

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
                editButton.Command += EditUoNOverView_Click;

                cell4.Controls.Add(editButton);

                row.Cells.Add(cell4);
                titlene.Rows.Add(row);
            }
        }
        
        
        public void LoadUoNRanking()
        {
            UoN_Ranking.Rows.Clear();

            var listLevel1 = UONBLL.GetByType(UoNConstant.UoN_Rank);

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
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Rank.ToString();
                cell2.Controls.Add(lb1);
                cell2.CssClass = "width20";
                row.Cells.Add(cell2);



                TableCell cell3 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Description.ToString();
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


                UoN_Ranking.Rows.Add(row);
            }
        }
        public void OverViewUoN()
        {
            Overview_tbl.Rows.Clear();

            var listLevel1 = UONBLL.GetByType(UoNConstant.Overviewuon);
            foreach (var item in listLevel1)
            {
                TableRow row = new TableRow();


                TableCell cell1 = new TableCell();
                Label lb1 = new Label();
                lb1.CssClass = "size15";
                lb1.Text = item.Title;
                cell1.Controls.Add(lb1);
                cell1.CssClass = "width10";
                row.Cells.Add(cell1);

                TableCell cell4 = new TableCell();
                Label lb2 = new Label();
                lb2.CssClass = "size15";
                lb2.Text = item.Content;
                cell4.Controls.Add(lb2);
                cell4.CssClass = "width50";
                row.Cells.Add(cell4);


                TableCell cell3 = new TableCell();
                Image image = new Image();
                image.CssClass = "pic300";
                image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.Images);
                cell3.Controls.Add(image);
                cell3.CssClass = "width30";
                row.Cells.Add(cell3);

                TableCell cell5 = new TableCell();
                Button editButton = new Button();
                editButton.CssClass = "tablebtn";
                editButton.Text = "EDIT";
                cell5.CssClass = "width10";
                editButton.CommandArgument = item.id.ToString();
                editButton.CommandName = "Edit";
                editButton.Command += EditUoNOverView_Click;
                cell5.Controls.Add(editButton);

                row.Cells.Add(cell5);
                Overview_tbl.Rows.Add(row);
            }
        }
        public void LoadOther()
        {
            Other_tbl.Rows.Clear();

            var listLevel1 = UONBLL.GetByType(UoNConstant.Other);
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
                cell3.CssClass = "width30";
                row.Cells.Add(cell3);

                TableCell cell5 = new TableCell();
                Label lb5 = new Label();
                lb5.CssClass = "size15";
                lb5.Text = item.Description + "";
                cell5.Controls.Add(lb5);
                cell5.CssClass = "width30";
                row.Cells.Add(cell5);

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
                editButton.Command += EditUoNOtherContent_Click;
                cell4.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.CssClass = "tablebtn";
                deleteButton.Text = "DELETE";
                deleteButton.CommandArgument = item.id.ToString();
                deleteButton.CommandName = "Delete";
                deleteButton.Command += DeleteOtherContentOUN_Click;
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
        public void ClearRank()
        {
            txtRank.Text = string.Empty;
            txtRankDescription.Text = string.Empty;
            UoNFileUploadRank.Dispose();
        }
        
        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("UONEdit.aspx?id=" + id.ToString() + $"&type={typeof(UoN).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditUoNOverView_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(UoN).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={UoNConstant.Overviewuon}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void EditUoNOtherContent_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite={typeof(UoN).Name}" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type={UoNConstant.Other}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }
        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            UONBLL.DeleteUON(id);

            TitleUON();
            LoadUoNRanking();
            OverViewUoN();
            LoadOther();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        public void DeleteTitleOUN_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            UONBLL.DeleteUON(id);
            TitleUON();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        public void DeleteOtherContentOUN_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            UONBLL.DeleteUON(id);
            LoadOther();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        public void DeleteOverOUN_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            UONBLL.DeleteUON(id);
            
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text.Trim()) && !string.IsNullOrEmpty(txtContent.Text.Trim()) && UoNFileUploadNew.HasFile && !string.IsNullOrEmpty(txtDescription.Text))
            {
                string filePath = UploadFile(UoNFileUploadNew);
                int type = UoNConstant.Other;
                var newUoN = new UoN()
                {
                    Images = filePath,
                    UoNType = type,
                    Content = txtContent.Text,
                    Title = txtTitle.Text,
                    Description = txtDescription.Text
                };
                UONBLL.AddUoN(newUoN);

                LoadOther();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtContent.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTitle.Text = string.Empty;
            UoNFileUploadNew.Dispose();
        }
        protected void btnAddRank_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRankDescription.Text.Trim()) && !string.IsNullOrEmpty(txtRank.Text.Trim()) && UoNFileUploadRank.HasFile
                    )
            {
                string filePath = UploadFile(UoNFileUploadRank);
                int type = UoNConstant.UoN_Rank;
                var newUoN = new UoN()
                {
                    Images = filePath,
                    UoNType = type,
                    Rank = int.Parse(txtRank.Text),
                    Description = txtRankDescription.Text
                };
                UONBLL.AddUoN(newUoN);
                ClearRank();
                LoadUoNRanking();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void btnCancelRank_Click(object sender, EventArgs e)
        {
            ClearRank();
        }
        
    }
}