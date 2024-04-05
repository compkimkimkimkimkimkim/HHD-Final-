using Antlr.Runtime;
using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class MarinaSquareCMS : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
        {
			GetTitle();

			LoadLevel3();
            LoadLevel2();
            LoadLevel1();
            LoadLevelB1();
        }
        public void LoadLevel3()
        {
			level3_tbl.Rows.Clear();

			var listLevel3 = MarianSquareBLL.GetByType(MarianSquareConstant.level3);

			foreach (var item in listLevel3)
			{
				TableRow row = new TableRow();

				TableCell cell1 = new TableCell();
				Image image = new Image();
				image.CssClass = "pic100";
				image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.filePath);
				cell1.Controls.Add(image);
				cell1.CssClass = "width45";
				row.Cells.Add(cell1);

				TableCell cell2 = new TableCell();
				Label label = new Label();
				label.CssClass = "size15";
				label.Text = item.name;
				cell2.Controls.Add(label);
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
				cell3.Controls.Add(editButton);

				Button deleteButton = new Button();
				deleteButton.CssClass = "tablebtn";
				deleteButton.Text = "DELETE";
				deleteButton.CommandArgument = item.Id.ToString();
				deleteButton.CommandName = "Delete";
				deleteButton.Command += Delete_Click;
				cell3.Controls.Add(deleteButton);
				row.Cells.Add(cell3);


				level3_tbl.Rows.Add(row);
			}
		} 
		public void LoadLevel2()
        {
			level2_tbl.Rows.Clear();

			var listLevel2 = MarianSquareBLL.GetByType(MarianSquareConstant.level2);

			foreach (var item in listLevel2)
			{
				TableRow row = new TableRow();

				TableCell cell1 = new TableCell();
				Image image = new Image();
				image.CssClass = "pic100";
				image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.filePath);
				cell1.Controls.Add(image);
				cell1.CssClass = "width45";
				row.Cells.Add(cell1);

				TableCell cell2 = new TableCell();
				Label label = new Label();
				label.CssClass = "size15";
				label.Text = item.name;
				cell2.Controls.Add(label);
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
				cell3.Controls.Add(editButton);
				Button deleteButton = new Button();
				deleteButton.CssClass = "tablebtn";
				deleteButton.Text = "DELETE";
				deleteButton.CommandArgument = item.Id.ToString();
				deleteButton.CommandName = "Delete";
				deleteButton.Command += Delete_Click;
				cell3.Controls.Add(deleteButton);
				row.Cells.Add(cell3);


				level2_tbl.Rows.Add(row);
			}
		} 
		public void LoadLevel1()
        {
			level1_tbl.Rows.Clear();

			var listLevel1 = MarianSquareBLL.GetByType(MarianSquareConstant.level1);

			foreach (var item in listLevel1)
			{
				TableRow row = new TableRow();

				TableCell cell1 = new TableCell();
				Image image = new Image();
				image.CssClass = "pic100";
				image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.filePath);
				cell1.Controls.Add(image);
				cell1.CssClass = "width45";
				row.Cells.Add(cell1);

				TableCell cell2 = new TableCell();
				Label label = new Label();
				label.CssClass = "size15";
				label.Text = item.name;
				cell2.Controls.Add(label);
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
				cell3.Controls.Add(editButton);

				Button deleteButton = new Button();
				deleteButton.CssClass = "tablebtn";
				deleteButton.Text = "DELETE";
				deleteButton.CommandArgument = item.Id.ToString();
				deleteButton.CommandName = "Delete";
				deleteButton.Command += Delete_Click;
				cell3.Controls.Add(deleteButton);
				row.Cells.Add(cell3);


				level1_tbl.Rows.Add(row);
			}
		} 
		public void LoadLevelB1()
        {
			levelb1_tbl.Rows.Clear();

			var listLevelB1 = MarianSquareBLL.GetByType(MarianSquareConstant.Basic1);

			foreach (var item in listLevelB1)
			{
				TableRow row = new TableRow();

				TableCell cell1 = new TableCell();
				Image image = new Image();
				image.CssClass = "pic100";
				image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.filePath);
				cell1.Controls.Add(image);
				cell1.CssClass = "width45";
				row.Cells.Add(cell1);

				TableCell cell2 = new TableCell();
				Label label = new Label();
				label.CssClass = "size15";
				label.Text = item.name;
				cell2.Controls.Add(label);
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
				cell3.Controls.Add(editButton);

				Button deleteButton = new Button();
				deleteButton.CssClass = "tablebtn";
				deleteButton.Text = "DELETE";
				deleteButton.CommandArgument = item.Id.ToString();
				deleteButton.CommandName = "Delete";
				deleteButton.Command += Delete_Click;
				cell3.Controls.Add(deleteButton);
				row.Cells.Add(cell3);


				levelb1_tbl.Rows.Add(row);
			}
		}

		protected void btnAddL3_Click(object sender, EventArgs e)
        {
		    
            if(!string.IsNullOrEmpty(txtL3Name.Text.Trim()) && MSFileUploadL3.HasFile)
            {
                string filePath = UploadFile(MSFileUploadL3);
                int type = MarianSquareConstant.level3;
                var newMariam = new MarianSquare()
                {
                    filePath = filePath,
                    name = txtL3Name.Text,
                    type = type,
                };
                MarianSquareBLL.AddMartianSquare(newMariam);
                Clear();
				LoadLevel3();
                Response.Redirect(Request.Url.AbsoluteUri);
            }


			
        }
		public void GetTitle()
		{
			tbTitle.Rows.Clear();

			var listLevel1 = MarianSquareBLL.GetByType(MarianSquareConstant.Title);

			foreach (var item in listLevel1)
			{
				TableRow row = new TableRow();

				TableCell cell1 = new TableCell();
				Image image = new Image();
				image.CssClass = "pic500";
				image.ImageUrl = Path.Combine("~/UserInterfaceLayer.Site/ImagesSite/", item.filePath);
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
				cell4.Controls.Add(editButton);
				row.Cells.Add(cell4);


				tbTitle.Rows.Add(row);
			}
		}
		public void EditTitle_Click(object sender, CommandEventArgs e)
		{
			int id = int.Parse(e.CommandArgument.ToString());
			Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=Marina" + $"&prevURL={Request.Url.AbsoluteUri}"); // Chuyển hướng đến trang webform của bạn
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
            } catch (Exception ex)
            {
                return null;
            }
        }
		protected void btnCancelL3_Click(object sender, EventArgs e)
		{
            MSFileUploadL3.Dispose();
            txtL3Name.Text = string.Empty;
		}

        public void Clear()
        {
			MSFileUploadL3.Dispose();
			txtL3Name.Text = string.Empty;
		}
        public void Edit_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("editmaria.aspx?id=" + id.ToString() + $"&type={typeof(MarianSquare).Name}"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }

        public void Delete_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            MarianSquareDAL.DeleteMarianSquare(id);

            LoadLevel3();
            LoadLevel2();
            LoadLevel1();
            LoadLevelB1();
            Response.Redirect(Request.Url.AbsoluteUri);
        }



        public void Clear2()
		{
			MSFileUploadL2.Dispose();
			txtL2Name.Text = string.Empty;
		}

		protected void btnAddL2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtL2Name.Text.Trim()) && MSFileUploadL2.HasFile)
			{
				string filePath = UploadFile(MSFileUploadL2);
				int type = MarianSquareConstant.level2;
				var newMariam = new MarianSquare()
				{
					filePath = filePath,
					name = txtL2Name.Text,
					type = type,
				};
				MarianSquareBLL.AddMartianSquare(newMariam);
				Clear2();
				LoadLevel2();
                Response.Redirect(Request.Url.AbsoluteUri);
            }

		}

		protected void btnCancelL2_Click(object sender, EventArgs e)
		{
			MSFileUploadL2.Dispose();
			txtL2Name.Text = string.Empty;
		}
		public void Clear1()
		{
			MSFileUploadL1.Dispose();
			txtL1Name.Text = string.Empty;
		}
		protected void btnAddL1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtL1Name.Text.Trim()) && MSFileUploadL1.HasFile)
			{
				string filePath = UploadFile(MSFileUploadL1);
				int type = MarianSquareConstant.level1;
				var newMariam = new MarianSquare()
				{
					filePath = filePath,
					name = txtL1Name.Text,
					type = type,
				};
				MarianSquareBLL.AddMartianSquare(newMariam);
				Clear1();
				LoadLevel1();
                Response.Redirect(Request.Url.AbsoluteUri);
            }

		}

		protected void btnCancelL1_Click(object sender, EventArgs e)
		{
			MSFileUploadL1.Dispose();
			txtL1Name.Text = string.Empty;
		}

		public void ClearB1()
		{
			MSFileUploadB1.Dispose();
			txtB1Name.Text = string.Empty;
		}


		protected void btnAddB1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtB1Name.Text.Trim()) && MSFileUploadB1.HasFile)
			{
				string filePath = UploadFile(MSFileUploadB1);
				int type = MarianSquareConstant.Basic1;
				var newMariam = new MarianSquare()
				{
					filePath = filePath,
					name = txtB1Name.Text,
					type = type,
				};
				MarianSquareBLL.AddMartianSquare(newMariam);
				ClearB1();
				LoadLevelB1();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
		}

		protected void btnCancelB1_Click(object sender, EventArgs e)
		{
			MSFileUploadB1.Dispose();
			txtB1Name.Text = string.Empty;
		}
	}
}