using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HHD
{
    public partial class CMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void FuncCam(object sender, EventArgs e)
        {
            HtmlGenericControl camDiv = (HtmlGenericControl)FindControl("Cam");

            if (camDiv != null)
            {
                if (camDiv.Style["display"] == "none")
                {
                    camDiv.Style["display"] = "block";
                }
                else
                {
                    camDiv.Style["display"] = "none";
                }
            }
        }
        protected void FuncUni(object sender, EventArgs e)
        {
            HtmlGenericControl uniDiv = (HtmlGenericControl)FindControl("Uni");

            if (uniDiv != null)
            {
                if (uniDiv.Style["display"] == "none")
                {
                    uniDiv.Style["display"] = "block";
                }
                else
                {
                    uniDiv.Style["display"] = "none";
                }
            }
        }
        protected void openModal(object sender, EventArgs e)
        {
            myModal.Style["display"] = "block";
            previewFrame.Attributes["src"] = "~/UserInterfaceLayer.Site/Home.aspx";
        }
        protected void closeModal(object sender, EventArgs e)
        {
            myModal.Style["display"] = "none";
            previewFrame.Attributes["src"] = "";
        }
    }
}