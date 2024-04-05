using HHD.BusinessLogicLayer;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditLocation3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    string name = Request.QueryString["type"];

                    switch (name)
                    {
                        
                        case "LocalTion":
                            DisplayLocalTion(id);
                            break;
                       
                        default:
                            // Xử lý cho trường hợp mặc định (nếu cần)
                            break;
                    }
                }
            }

        }
        private void DisplayLocalTion(int id)
        {
            LocalTion location = LocaltionBLL.GetByIdDTO(id);
            if (location != null)
            {
                TextBox1.Text = location.LocaltionName;
                TextBox2.Text = location.BusNumbers;
                ViewState["LocationId"] = location.Id;

            }
        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            if (ViewState["LocationId"] != null)
            {
                int locationId = (int)ViewState["LocationId"];
                string LocaltionName = TextBox1.Text;
                string busNumbers = TextBox2.Text;
                LocalTion edit = new LocalTion
                {
                    LocaltionName = LocaltionName,
                    BusNumbers = busNumbers,

                };
                bool success = LocalTionDAL.UpdateLocaltionbus(locationId, edit);
                if (success)
                {
                    lblMessage.Text = "Successful";

                    lblMessage.Visible = true;
                }
                else
                {
                    lblMessage.Text = "Failed";
                  
                    lblMessage.Visible = true;
                }

            }
        }
    }
}