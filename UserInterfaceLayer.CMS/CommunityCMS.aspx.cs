using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class CommunityCMS : System.Web.UI.Page, ICallbackEventHandler
    {
        public int postId = -1;
        List<int> selectCategories = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region Đăng ký ICallback, ICallbackEventHandler
                String cbReference = Page.ClientScript.GetCallbackEventReference(this, "arg", "ReceiverDiagram", "context");
                String callbackScript = "function CallDiagram(arg, context)" + "{ " + cbReference + ";}";
                Page.ClientScript.RegisterClientScriptBlock(GetType(), "Diagram", callbackScript, true);
                #endregion
                GetTitle();
                GetRulesPage();
                List<Category> categories = GetCategories();
                List<Category> filteredCategories = categories.Where(cat => cat.Name == "ADMIN").ToList();



                rptCategories.DataSource = filteredCategories;
                rptCategories.DataBind();
                BindRepeaterData();
                if (!string.IsNullOrEmpty(Request.QueryString["postId"]))
                {
                    postId = Convert.ToInt32(Request.QueryString["postId"]);
                    PopulatePostData(postId);

                    ViewState["postId"] = postId;
                }
                loadCommunityPageWelcome();

            }
            else
            {

                if (ViewState["selectCategories"] != null)
                {
                    selectCategories = (List<int>)ViewState["selectCategories"];
                }
            }
        }
        private void loadCommunityPageWelcome()
        {
            try
            {
                string sql = "SELECT * FROM Community";
                DataTable dt = SqlHelper.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    //rptCommunityPage.DataSource = dt;
                    //rptCommunityPage.DataBind();
                }
                else
                {
                    Console.WriteLine("No Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fail Connection");
            }
        }
        public void GetRulesPage()
        {
            string sql = @"SELECT Content, Title,id
                   FROM ManagerCommunity
                   WHERE ManagerCommunityType <> 1";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                string script = @"<table class='tbl'>";
                foreach (DataRow rowdt in dt.Rows)
                {
                    script += @" 
                            <tr>
                        <td class='width30'>
                            <label class='size15'>" + rowdt["Title"] + @"</label></td>
                        <td class='width60'>
                            <label class='size15'>" + rowdt["Content"] + @"</label></td>
                        <td class='width10'>
                            <input type='button' class='tablebtn' onclick='linkto(""" + "/UserInterfaceLayer.CMS/Edit_All.aspx?id=" + rowdt["id"] + @"&fromSite=Community" + @"&prevURL=" + Request.Url.AbsoluteUri + @""")' value='EDIT' /> <input type='button' class='tablebtn' onclick='saveRules(""Delete"",""" + rowdt["id"] + @""")' value='DELETE' />
                        </td>
                    </tr>";
                }
                script += @"</table>";
                TBRules_Page.InnerHtml = script;
            }
        }
        public void DeleteEvent_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            HHD.Model.ManagerCommunity bean = new HHD.Model.ManagerCommunity();
            bean = bean.SelectByID(id);
            bean.Delete(bean);
            GetRulesPage();
            Response.Redirect(Request.Url.AbsoluteUri);

        }
        public void EditRules_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("Edit_All.aspx?id=" + id.ToString() + $"&fromSite=Community" + $"&prevURL={Request.Url.AbsoluteUri}" + $"&type=2"); // Chuyển hướng đến trang webform của bạn
            ScriptManager.RegisterStartupScript(this, GetType(), "ShowModal", "<script>$('#myModal').modal('show');</script>", false); // Hiển thị modal
        }


        public void GetTitle()
        {


            string sql = @"SELECT Content, Title,id
                   FROM ManagerCommunity
                   WHERE ManagerCommunityType = 1";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                string script = @" <table class='tbl'>
                            <tr>
                        <td class='width30'>
                            <label class='size15'>" + dt.Rows[0]["Title"] + @"</label></td>
                        <td class='width60'>
                            <label class='size15'>" + dt.Rows[0]["Content"] + @"</label></td>
                        <td class='width10'>
                            <input type='button' class='tablebtn' onclick='linkto(""" + "/UserInterfaceLayer.CMS/Edit_All.aspx?id=" + dt.Rows[0]["id"] + @"&fromSite=Community" + @"&prevURL=" + Request.Url.AbsoluteUri + @""")' value='EDIT' />
                        </td>
                    </tr></table>";
                TBWelcome_Page.InnerHtml = script;
            }
        }
        private void BindRepeaterData()
        {
            int id = 0;
            List<CommunityCustom> communityCustoms = CommunityBLL.GetCommunityListAdmin(id);

            listne.DataSource = communityCustoms;
            listne.DataBind();


        }

        public void Deletecomuni_Click(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            CommunityBLL.DeleteCommunity(id);

            BindRepeaterData();

        }

        private void PopulatePostData(int postId)
        {
            HHD.Models.Community community = CommunityBLL.GetCommunity(postId);
            List<CommunityCategoryCustom> communityCategories = CommunityCategoryBLL.GetCommunityCategoryList(postId);
            List<CommunityPicture> communityPictures = CommunityPictureBLL.GetCommunityPictureList(postId);

            if (community != null)
            {
                string pass = "123123";
                txbName.Value = community.Name;
                txbTitle.Value = community.Title;
                txContent.Value = community.Content;
                pass = community.Password;
                pass = community.Password;
                pass = community.Password;

                if (communityCategories.Count > 0)
                {
                    selectCategories = communityCategories.Select(item => item.CategoryId).ToList();
                    ViewState["selectCategories"] = selectCategories;
                    rptCategories.DataBind();
                }

                if (communityPictures.Count > 0)
                {
                    if (communityPictures.Count >= 1)
                    {
                        image_preview1.Src = communityPictures[0].Path;

                        choose1.Attributes.Add("class", "choose have-image");

                        choosebtn1.Attributes.Add("class", "btn choosebtn");

                        image_preview1.Attributes.Add("class", "image_preview");
                    }

                    if (communityPictures.Count >= 2)
                    {
                        image_preview2.Src = communityPictures[1].Path;

                        choose2.Attributes.Add("class", "choose have-image");

                        choosebtn2.Attributes.Add("class", "btn choosebtn");

                        image_preview2.Attributes.Add("class", "image_preview");
                    }

                    if (communityPictures.Count >= 3)
                    {
                        image_preview3.Src = communityPictures[2].Path;

                        choose3.Attributes.Add("class", "choose have-image");

                        choosebtn3.Attributes.Add("class", "btn choosebtn");

                        image_preview3.Attributes.Add("class", "image_preview");
                    }

                    if (communityPictures.Count >= 4)
                    {
                        image_preview4.Src = communityPictures[3].Path;

                        choose4.Attributes.Add("class", "choose have-image");

                        choosebtn4.Attributes.Add("class", "btn choosebtn");

                        image_preview4.Attributes.Add("class", "image_preview");
                    }

                    if (communityPictures.Count >= 5)
                    {
                        image_preview5.Src = communityPictures[4].Path;

                        choose5.Attributes.Add("class", "choose have-image");

                        choosebtn5.Attributes.Add("class", "btn choosebtn");

                        image_preview5.Attributes.Add("class", "image_preview");
                    }

                    if (communityPictures.Count >= 6)
                    {
                        image_preview6.Src = communityPictures[5].Path;

                        choose6.Attributes.Add("class", "choose have-image");

                        choosebtn6.Attributes.Add("class", "btn choosebtn");

                        image_preview6.Attributes.Add("class", "image_preview");
                    }
                }
            }
        }

        protected void rptCategories_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Button btnCategory = (Button)e.Item.FindControl("btnCategory");
                if (btnCategory != null)
                {
                    int categoryId = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Id"));


                    if (selectCategories.Contains(categoryId))
                    {
                        btnCategory.CssClass = "category_item selected";
                    }
                    else
                    {
                        btnCategory.CssClass = "category_item";
                    }
                }
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

            int categoryId = int.Parse(btn.CommandArgument);

            if (selectCategories.Contains(categoryId))
            {
                selectCategories.Remove(categoryId);
            }
            else
            {
                selectCategories.Add(categoryId);
            }

            if (btn.CssClass.Contains("selected"))
            {
                btn.CssClass = "category_item";
            }
            else
            {

                btn.CssClass = "category_item selected";
            }


            ViewState["selectCategories"] = selectCategories;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CommunityCMS.aspx");
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {

            int postId = ViewState["postId"] != null ? (int)ViewState["postId"] : -1;
            if (postId != -1)
            {

                UpdatePost(postId);
            }
            else
            {

                CreateNewPost();
            }
        }

        private void UpdatePost(int postId)
        {

            string fullName = txbName.Value;
            string title = txbTitle.Value;
            string content = txContent.Value;
            string password = "123123";
            string cpassword = "1323123";

            if (string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Password is required");
                return;
            }

            if (password != cpassword)
            {
                ShowErrorMessage("Confirm password is incorrect");
                return;
            }

            HHD.Models.Community community = CommunityBLL.GetCommunity(postId);
            List<CommunityPicture> communityPictures = CommunityPictureBLL.GetCommunityPictureList(postId);
            community.Name = fullName;
            community.Title = title;
            community.Password = password;
            community.Content = content;

            if (CommunityBLL.UpdateCommunity(community))
            {
                List<string> list = new List<string>();

                if (fileInput1.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput1.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput1.PostedFile.SaveAs(filePath);

                    if (communityPictures.Count >= 1)
                    {
                        communityPictures[0].Path = path;
                        CommunityPictureBLL.UpdateCommunityPicture(communityPictures[0]);
                    }
                    else
                    {
                        list.Add(path);
                    }
                }
                if (fileInput2.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput2.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput2.PostedFile.SaveAs(filePath);

                    if (communityPictures.Count >= 2)
                    {
                        communityPictures[1].Path = path;
                        CommunityPictureBLL.UpdateCommunityPicture(communityPictures[1]);
                    }
                    else
                    {
                        list.Add(path);
                    }
                }
                if (fileInput3.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput3.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput3.PostedFile.SaveAs(filePath);

                    if (communityPictures.Count >= 3)
                    {
                        communityPictures[2].Path = path;
                        CommunityPictureBLL.UpdateCommunityPicture(communityPictures[2]);
                    }
                    else
                    {
                        list.Add(path);
                    }
                }

                if (fileInput4.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput4.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput4.PostedFile.SaveAs(filePath);

                    if (communityPictures.Count >= 4)
                    {
                        communityPictures[3].Path = path;
                        CommunityPictureBLL.UpdateCommunityPicture(communityPictures[3]);
                    }
                    else
                    {
                        list.Add(path);
                    }
                }
                if (fileInput5.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput5.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);

                    fileInput5.PostedFile.SaveAs(filePath);

                    if (communityPictures.Count >= 5)
                    {
                        communityPictures[4].Path = path;
                        CommunityPictureBLL.UpdateCommunityPicture(communityPictures[4]);
                    }
                    else
                    {
                        list.Add(path);
                    }
                }
                if (fileInput6.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput6.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);

                    fileInput6.PostedFile.SaveAs(filePath);

                    if (communityPictures.Count >= 6)
                    {
                        communityPictures[5].Path = path;
                        CommunityPictureBLL.UpdateCommunityPicture(communityPictures[5]);
                    }
                    else
                    {
                        list.Add(path);
                    }
                }

                if (selectCategories.Count > 0)
                {
                    CommunityCategoryBLL.DeleteCommunityCategory(postId);
                    foreach (var category in selectCategories)
                    {
                        CommunityCategoryBLL.AddCommunityCategory(new CommunityCategory()
                        {
                            CategoryId = category,
                            CommunityId = postId
                        });
                    }
                }

                if (list.Count > 0)
                {
                    foreach (var path in list)
                    {
                        CommunityPictureBLL.AddCommunityPicture(new CommunityPicture()
                        {
                            Path = path,
                            CommunityId = postId
                        });
                    }
                }

                ShowErrorMessageAndRedirect("Succeed", "CommunityCMS.aspx");
            }
            else
            {
                ShowErrorMessage("Failed");
            }
        }

        private void CreateNewPost()
        {
            string fullName = txbName.Value;
            string title = txbTitle.Value;
            string content = txContent.Value;
            string password = "123123";
            string cpassword = "123123";

            if (string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Password is required");
                return;
            }

            if (password != cpassword)
            {
                ShowErrorMessage("Confirm password is incorrect");
                return;
            }

            HHD.Models.Community community = new HHD.Models.Community()
            {
                Name = fullName,
                Title = title,
                Password = password,
                Content = content,
                CreationTime = DateTime.Now
            };

            int id = CommunityBLL.AddCommunity(community);

            if (id > 0)
            {
                List<string> list = new List<string>();

                if (fileInput1.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput1.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput1.PostedFile.SaveAs(filePath);

                    list.Add(path);
                }
                if (fileInput2.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput2.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput2.PostedFile.SaveAs(filePath);

                    list.Add(path);
                }
                if (fileInput3.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput3.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput3.PostedFile.SaveAs(filePath);

                    list.Add(path);
                }

                if (fileInput4.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput4.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput4.PostedFile.SaveAs(filePath);

                    list.Add(path);
                }
                if (fileInput5.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput5.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput5.PostedFile.SaveAs(filePath);

                    list.Add(path);
                }
                if (fileInput6.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(fileInput6.PostedFile.FileName);
                    string path = "~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName;
                    string filePath = Server.MapPath("~/UserInterfaceLayer.Site/ImagesCommunity/" + fileName);


                    fileInput6.PostedFile.SaveAs(filePath);

                    list.Add(path);
                }

                if (selectCategories.Count > 0)
                {
                    foreach (var category in selectCategories)
                    {
                        CommunityCategoryBLL.AddCommunityCategory(new CommunityCategory()
                        {
                            CategoryId = category,
                            CommunityId = id
                        });
                    }
                }

                if (list.Count > 0)
                {
                    foreach (var path in list)
                    {
                        CommunityPictureBLL.AddCommunityPicture(new CommunityPicture()
                        {
                            Path = path,
                            CommunityId = id
                        });
                    }
                }

                ShowErrorMessageAndRedirect("Succeed", "CommunityCMS.aspx");
            }
            else
            {
                ShowErrorMessage("Failed");
            }
        }

        private void ShowErrorMessage(string errorMessage)
        {
            string script = "<script type=\"text/javascript\">" +
                            "alert('" + errorMessage.Replace("'", "\\'") + "');" +
                            "</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Error", script);
        }

        private void ShowErrorMessageAndRedirect(string errorMessage, string redirectUrl)
        {
            string script = "<script type=\"text/javascript\">" +
                            "alert('" + errorMessage.Replace("'", "\\'") + "');" +
                            "window.location='" + redirectUrl + "';" +
                            "</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Error", script);
        }


        protected void EditItem_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "EditItem")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"EditCommunity.aspx?id={id}&type={typeof(Community).Name}");
            }
        }

        protected void Edit_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "EditItem")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"EditCommunityPicture.aspx?id={id}&type={typeof(CommunityPicture).Name}");
            }
        }
        private string StringScript = "";
        public void RaiseCallbackEvent(string eventArgument)
        {
            string[] arr = eventArgument.Split(new string[] { "$$" }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length > 0)
            {
                switch (arr[0])
                {
                    case "Add":
                        if (!string.IsNullOrEmpty(arr[2]) && !string.IsNullOrEmpty(arr[3]))
                        {
                            HHD.Model.ManagerCommunity bean = new HHD.Model.ManagerCommunity();
                            bean.ManagerCommunityType = 2;
                            bean.Title = arr[2];
                            bean.Content = arr[3];
                            bean.Insert(bean);
                        }
                        break;
                    case "Delete":
                        int id = int.Parse(arr[1]);
                        HHD.Model.ManagerCommunity beandel = new HHD.Model.ManagerCommunity();
                        beandel = beandel.SelectByID(id);
                        beandel.Delete(beandel);
                        break;
                }
            }
        }

        public string GetCallbackResult()
        {
            return StringScript;
        }
    }
}