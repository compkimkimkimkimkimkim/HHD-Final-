using HHD.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Orientation = HHD.Model.Orientation;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class Edit_All : System.Web.UI.Page
    {
        private int id = 0;
        private string fromSite = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    id = int.Parse(Request.QueryString["id"]);
                    fromSite = Request.QueryString["fromSite"];
                    switch (fromSite)
                    {
                        case "PSBC":
                            bool isType1 = false;
                            if (!string.IsNullOrEmpty(Request.QueryString["type"]))
                            {
                                if (Request.QueryString["type"] == "1")
                                {
                                    isType1 = true;
                                    divName.Visible = true;
                                }
                                else
                                {
                                    divTitle.Visible = true;
                                    divContent.Visible = true;
                                }
                            }
                            else
                            {
                                divTitle.Visible = true;
                            }
                            divImage.Visible = true;
                            PSBC bean = new PSBC();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (isType1)
                                    txtName.Value = bean.Name;
                                else
                                {
                                    if (string.IsNullOrEmpty(Request.QueryString["type"]))
                                        txtContent.Value = bean.Content;
                                    txtTitle.Value = bean.Title;
                                }
                            }
                            break;
                        case "UoN":
                            bool isType4 = false;
                            if (!string.IsNullOrEmpty(Request.QueryString["type"]))
                            {
                                if (Request.QueryString["type"] == "4")
                                {
                                    isType4 = true;
                                    divDescription.Visible = true;
                                }
                            }
                            divTitle.Visible = true;
                            divContent.Visible = true;
                            divImage.Visible = true;
                            UoN beanUoN = new UoN();
                            beanUoN = beanUoN.SelectByID(id);
                            if (beanUoN != null)
                            {
                                txtTitle.Value = beanUoN.Title;
                                txtContent.Value = beanUoN.Content;
                                if (isType4)
                                    txtDescription.Value = beanUoN.Description;
                            }
                            break;
                        case "Home":
                            int type = Convert.ToInt32(Request.QueryString["type"]);
                            switch (type)
                            {
                                case 2:
                                    {
                                        divLinkVideo.Visible = true;
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            txtLink.Value = home.Link;
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        divImage.Visible = true;
                                        divName.Visible = true;
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            txtName.Value = home.Name;
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        divDescription.Visible = true;
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            txtDescription.Value = home.Description;
                                        }
                                    }
                                    break;
                                case 5:
                                    {
                                        divImage.Visible = true;
                                        divDescription.Visible = true;
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            txtDescription.Value = home.Description;
                                        }
                                    }
                                    break;
                            }
                            break;
                        case "Community":
                            divTitle.Visible = true;
                            divContent.Visible = true;
                            ManagerCommunity manager = new ManagerCommunity();
                            manager = manager.SelectByID(id);
                            if (manager != null)
                            {
                                txtTitle.Value = manager.Title;
                                txtContent.Value = manager.Content;
                            }
                            break;
                        case "StudentClub":
                            divImage.Visible = true;
                            break;
                        case "Location":
                            divImage.Visible = true;
                            break;
                        case "Marina":
                            divImage.Visible = true;
                            break;
                        case "EventLists":
                            divImage.Visible = true;
                            break;
                        case "AboutUs":
                            divImage.Visible = true;
                            break;
                        case "Orientation":
                            divTitle.Visible = true;
                            divContent.Visible = true;
                            Orientation Ori = new Orientation();
                            Ori = Ori.SelectByID(id);
                            if (Ori != null)
                            {
                                txtTitle.Value = Ori.Title;
                                txtContent.Value = Ori.Content;
                            }
                            break;
                        default:
                            // Xử lý cho trường hợp mặc định (nếu cần)
                            break;
                    }
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(Request.QueryString["id"]);
                fromSite = Request.QueryString["fromSite"];
                switch (fromSite)
                {
                    case "PSBC":
                        if (id != 0)
                        {
                            bool isType1 = false;
                            if (!string.IsNullOrEmpty(Request.QueryString["type"]))
                            {
                                if (Request.QueryString["type"] == "1")
                                {
                                    isType1 = true;
                                }
                            }
                            PSBC bean = new PSBC();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (isType1)
                                    bean.Name = txtName.Value;
                                else
                                {
                                    bean.Title = txtTitle.Value;
                                    if (string.IsNullOrEmpty(Request.QueryString["type"]))
                                        bean.Content = txtContent.Value;
                                }
                                
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.Images = filePath;
                                }
                                bean.Update(bean);
                            }

                        }
                        break;
                    case "UoN":
                        if (id != 0)
                        {
                            bool isType4 = false;
                            if (!string.IsNullOrEmpty(Request.QueryString["type"]))
                            {
                                if (Request.QueryString["type"] == "4")
                                {
                                    isType4 = true;
                                }
                            }
                            UoN bean = new UoN();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                bean.Title = txtTitle.Value;
                                bean.Content = txtContent.Value;
                                if (isType4)
                                    bean.Description = txtDescription.Value;
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.Images = filePath;
                                }
                                bean.Update(bean);
                            }

                        }
                        break;
                    case "Home":
                        if (id != 0)
                        {
                            int type = Convert.ToInt32(Request.QueryString["type"]);
                            switch (type)
                            {
                                case 2:
                                    {
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            home.Link = txtLink.Value;
                                            home.Update(home);
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            home.Name = txtName.Value;
                                            if (PSBFileUploadUni.HasFile)
                                            {
                                                string filePath = UploadFile(PSBFileUploadUni);
                                                home.Image = filePath;
                                            }
                                            home.Update(home);
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            home.Description = txtDescription.Value;
                                            home.Update(home);
                                        }
                                    }
                                    break;
                                case 5:
                                    {
                                        Home home = new Home();
                                        home = home.SelectByID(id);
                                        if (home != null)
                                        {
                                            home.Description = txtDescription.Value;
                                            if (PSBFileUploadUni.HasFile)
                                            {
                                                string filePath = UploadFile(PSBFileUploadUni);
                                                home.Image = filePath;
                                            }
                                            home.Update(home);
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case "Location":
                        if (id != 0)
                        {
                            Localtion bean = new Localtion();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.Images = filePath;
                                }
                                bean.Update(bean);
                            }
                        }
                        break;
                    case "StudentClub":
                        if (id != 0)
                        {
                            StudentClub bean = new StudentClub();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.Images = filePath;
                                }
                                bean.Update(bean);
                            }
                        }
                        break;
                    case "Marina":
                        if (id != 0)
                        {
                            LevelMary bean = new LevelMary();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.filePath = filePath;
                                }
                                bean.Update(bean);
                            }
                        }
                        break;
                    case "EventLists":
                        if (id != 0)
                        {
                            EventList bean = new EventList();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.EventPoster = filePath;
                                }
                                bean.Update(bean);
                            }
                        }
                        break;
                    case "AboutUs":
                        if (id != 0)
                        {
                            AboutU bean = new AboutU();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                if (PSBFileUploadUni.HasFile)
                                {
                                    string filePath = UploadFile(PSBFileUploadUni);
                                    bean.Images = filePath;
                                }
                                bean.Update(bean);
                            }
                        }
                        break;
                    case "Orientation":
                        if (id != 0)
                        {
                            Orientation bean = new Orientation();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                bean.Title = txtTitle.Value;
                                bean.Content = txtContent.Value;
                                bean.Update(bean);
                            }
                        }
                        break;
                    case "Community":
                        if (id != 0)
                        {
                            ManagerCommunity bean = new ManagerCommunity();
                            bean = bean.SelectByID(id);
                            if (bean != null)
                            {
                                bean.Title = txtTitle.Value;
                                bean.Content = txtContent.Value;
                                bean.Update(bean);
                            }
                        }
                        break;
                    default:
                        // Xử lý cho trường hợp mặc định (nếu cần)
                        break;
                }
                if (!string.IsNullOrEmpty(Request.QueryString["prevURL"]))
                {
                    Response.Redirect(Request.QueryString["prevURL"]);
                }

            }
            catch (Exception ex)
            {

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
    }
}