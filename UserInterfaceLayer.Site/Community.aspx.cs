using HHD.BusinessLogicLayer;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.Site
{
    public partial class Community : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetTitle();
                GetItemPost();
                List<Category> categories = GetCategories();
                List<Category> filteredCategories = categories.Where(cat => cat.Name != "ADMIN").ToList();

                rptCategories.DataSource = filteredCategories;
                rptCategories.DataSource = categories;
                rptCategories.DataBind();

                ViewState["PageSize"] = 10;
                int categoryId = GetCategoryId();
                BindRepeaterData(1, categoryId);
                BindPageNumbers();
            }
        }
        /// <summary>
        /// Get Title
        /// ManagerCommunityType = 1
        /// </summary>
        private void GetTitle()
        {
            try
            {
                string sql = @"SELECT Content, Title
                   FROM ManagerCommunity
                   WHERE ManagerCommunityType = 1";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txt_Title.InnerHtml = dt.Rows[0]["Title"] + "";
                    txt_Content.InnerHtml = dt.Rows[0]["Content"] + "";
                }

            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// Get Title
        /// ManagerCommunityType = 2
        /// </summary>
        private void GetItemPost()
        {
            try
            {
                string sql = @"SELECT Content, Title
                   FROM ManagerCommunity
                   WHERE ManagerCommunityType <> 1";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string strLayout = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        strLayout += @" 
                                <div class='item'>
                                    <h4>" + row["Title"] + @"</h4>
                                    <p>" + row["Content"] + @"</p>
                                </div>";
                    }
                    arrItem.InnerHtml = strLayout;
                }

            }
            catch (Exception ex)
            {
            }
        }
        private List<Category> GetCategories()
        {
            List<Category> categories = CategoryBLL.GetList();

            return categories;
        }

        protected void btnCategory_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btnCategoryAll.CssClass = "category_item";


            foreach (RepeaterItem item in rptCategories.Items)
            {
                Button btnCategory = (Button)item.FindControl("btnCategory");
                btnCategory.CssClass = "category_item";
            }


            btn.CssClass = "category_item selected";


            int categoryId = int.Parse(btn.CommandArgument);

            ViewState["CategoryId"] = categoryId;


            BindRepeaterData(1, categoryId);
            BindPageNumbers();
        }

        protected void btnCreatePost_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create_New_Post.aspx");
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            HtmlInputText txbName = (HtmlInputText)item.FindControl("txbName");
            HtmlInputText txbPassword = (HtmlInputText)item.FindControl("txbPassword");
            HtmlTextArea txContent = (HtmlTextArea)item.FindControl("txContent");

            string name = txbName.Value;
            string password = txbPassword.Value;
            string content = txContent.Value;

            int communityId = int.Parse(btn.CommandArgument);

            if (CommunityCommentBLL.AddCommunityComment(new CommunityComment()
            {
                CommunityId = communityId,
                Username = name,
                Password = password,
                Content = content,
                CreationTime = DateTime.Now
            }))
            {
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Value);
            string password = txtPassword.Text;



            if (CommunityCommentBLL.CheckPassword(id, password))
            {

                CommunityCommentBLL.Delete(id);
                Response.Redirect(Request.RawUrl);


                txtID.Value = "";
                txtPassword.Text = "";
            }
            else
            {
                ShowErrorMessage("Password is incorrect");
                return;
            }


            passwordPrompt.Style["display"] = "none";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Value = "";
            txtPassword.Text = "";

            passwordPrompt.Style["display"] = "none";
        }

        private void ShowErrorMessage(string errorMessage)
        {
            string script = "<script type=\"text/javascript\">" +
                            "alert('" + errorMessage.Replace("'", "\\'") + "');" +
                            "</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Error", script);
        }

        protected void btnCommunityEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCommunityID.Value);
            string password = txtCommunityPassword.Text;


            if (CommunityBLL.CheckPassword(id, password))
            {
                Response.Redirect("Create_New_Post.aspx?postId=" + id);


                txtCommunityID.Value = "";
                txtCommunityPassword.Text = "";
            }
            else
            {
                ShowErrorMessage("Password is incorrect");
                return;
            }


            edit_delete.Style["display"] = "none";
        }

        protected void btnCommunityDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCommunityID.Value);
            string password = txtCommunityPassword.Text;


            if (CommunityBLL.CheckPassword(id, password))
            {

                CommunityBLL.DeleteCommunity(id);
                Response.Redirect(Request.RawUrl);


                txtCommunityID.Value = "";
                txtCommunityPassword.Text = "";
            }
            else
            {
                ShowErrorMessage("Password is incorrect");
                return;
            }


            edit_delete.Style["display"] = "none";
        }

        protected void btnCommunityCancel_Click(object sender, EventArgs e)
        {
            txtCommunityID.Value = "";
            txtCommunityPassword.Text = "";
            edit_delete.Style["display"] = "none";
        }

        #region 分页
        protected void lnkFirst_Click(object sender, EventArgs e)
        {
            int categoryId = GetCategoryId();
            BindRepeaterData(1, categoryId);
            BindPageNumbers();
        }

        protected void lnkPrevious_Click(object sender, EventArgs e)
        {
            int currentPage = Convert.ToInt32(ViewState["CurrentPage"]);
            if (currentPage > 1)
            {
                int categoryId = GetCategoryId();
                BindRepeaterData(currentPage - 1, categoryId);
                BindPageNumbers();
            }
        }

        protected void rptPages_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pageNumber = Convert.ToInt32(e.CommandArgument);
            int categoryId = GetCategoryId();
            BindRepeaterData(pageNumber, categoryId);
            BindPageNumbers();
        }

        protected void lnkNext_Click(object sender, EventArgs e)
        {
            int currentPage = Convert.ToInt32(ViewState["CurrentPage"]);
            int totalPages = GetTotalPageCount();
            if (currentPage < totalPages)
            {
                int categoryId = GetCategoryId();
                BindRepeaterData(currentPage + 1, categoryId);
                BindPageNumbers();
            }
        }

        protected void lnkLast_Click(object sender, EventArgs e)
        {
            int totalPages = GetTotalPageCount();
            int categoryId = GetCategoryId();
            BindRepeaterData(totalPages, categoryId);
            BindPageNumbers();
        }

        private void BindRepeaterData(int pageNumber, int categoryId)
        {
            int pageSize = Convert.ToInt32(ViewState["PageSize"]);

            List<CommunityCustom> communityCustoms = CommunityBLL.GetCommunityList(categoryId, pageSize, pageNumber);

            rptCommunities.DataSource = communityCustoms;
            rptCommunities.DataBind();

            ViewState["CurrentPage"] = pageNumber;
        }

        private int GetTotalPageCount()
        {
            int categoryId = GetCategoryId();
            List<CommunityCustom> communityCustoms = CommunityBLL.GetCommunityList(categoryId);
            int totalRecords = communityCustoms.Count;
            int pageSize = Convert.ToInt32(ViewState["PageSize"]);
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            return totalPages;
        }

        private void BindPageNumbers()
        {
            DataTable dtPages = new DataTable();
            dtPages.Columns.Add("PageIndex");
            dtPages.Columns.Add("PageText");
            dtPages.Columns.Add("IsCurrentPage");

            int totalPages = GetTotalPageCount();
            int currentPage = Convert.ToInt32(ViewState["CurrentPage"]);
            int startPage, endPage;


            if (totalPages <= 10)
            {
                startPage = 1;
                endPage = totalPages;
            }
            else
            {
                if (currentPage <= 6)
                {
                    startPage = 1;
                    endPage = 10;
                }
                else if (currentPage >= totalPages - 4)
                {
                    startPage = totalPages - 9;
                    endPage = totalPages;
                }
                else
                {
                    startPage = currentPage - 5;
                    endPage = currentPage + 4;
                }
            }

            for (int i = startPage; i <= endPage; i++)
            {
                DataRow dr = dtPages.NewRow();
                dr["PageIndex"] = i;
                dr["PageText"] = i.ToString();
                dr["IsCurrentPage"] = (i == currentPage);
                dtPages.Rows.Add(dr);
            }

            rptPages.DataSource = dtPages;
            rptPages.DataBind();
        }

        private int GetCategoryId()
        {
            int categoryId = Convert.ToInt32(ViewState["CategoryId"]);
            return categoryId;
        }

        protected string GetPageCssClass(int pageIndex)
        {
            int currentPage = Convert.ToInt32(ViewState["CurrentPage"]);
            return (pageIndex == currentPage) ? "current" : "";
        }
        #endregion
    }
}