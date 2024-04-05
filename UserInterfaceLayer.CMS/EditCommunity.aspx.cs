using HHD.BusinessLogicLayer;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditCommunity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DisplayLocalTion(id);
                }
            }
        }
        private void DisplayLocalTion(int id)
        {
            Community community = CommunityBLL.GetByIdDTO(id);
            if (community != null)
            {
                txtID.Text = community.Title;
                txtName.Text = community.Content;
            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {

            string Title = txtID.Text;
            string Content = txtName.Text;
            Community edit = new Community
            {
                Title = Title,
                Content = Content,

            };
            bool success = CommunityDAL.UpdateCommunity2(edit, GetEventId());
            if (success)
            {
                lblMessage.Text = "Thành công";

                lblMessage.Visible = true;
                Response.Redirect("CommunityCMS.aspx");
            }
            else
            {
                lblMessage.Text = "Thất bại.";
                lblMessage.Text = txtID.Text;
                lblMessage.Text = txtName.Text;
                lblMessage.Visible = true;
            }
        }
        private int GetEventId()
        {
            int id = int.Parse(Request.QueryString["id"]);

            int eventId = id;
            return eventId;
        }
    }
}