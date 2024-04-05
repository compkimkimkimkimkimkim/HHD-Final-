using HHD.BusinessLogicLayer;
using HHD.Constant;
using HHD.DataAccessLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    string name = Request.QueryString["type"];

                    switch (name)
                    {
                        case "UoN":
                            var uon = UONBLL.GetByIdDTO(id);
                            if (uon != null)
                            {
                                
                            }
                            break;
                        case "StudentClub":
                           
                            break;
                        case "PSBC":
                            
                            break;
                        case "MarianSquare":
                            
                            break;
                        case "Orientation":
                           
                            break;
                        case "LocalTion":
                            DisplayLocalTion(id);
                            break;
                        case "EventLists":
                           
                            break;
                        case "AboutUs":
                          
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
                txtID.Text = location.LocaltionName;
                txtName.Text = location.LocaltionAddress;
                ViewState["LocationId"] = location.Id;

            }
        }
      
        protected void btnAction_Click(object sender, EventArgs e)
        {
            if (ViewState["LocationId"] != null)
            {
                int locationId = (int)ViewState["LocationId"];
                string LocaltionName = txtID.Text;
                string LocaltionAddress = txtName.Text;
                LocalTion edit = new LocalTion
                {
                    LocaltionName = LocaltionName,
                    LocaltionAddress = LocaltionAddress,
                 
                };
                bool success = LocalTionDAL.UpdateLocaltion( locationId, edit);
                if (success)
                {
                    lblMessage.Text = "Thành công";
                  
                    lblMessage.Visible = true;
                }
                else
                {
                    lblMessage.Text = "Thất bại.";
                    lblMessage.Text = txtID.Text;
                    lblMessage.Text = txtName.Text;
                    lblMessage.Visible = true;
                }

            }  
        }
    }
}