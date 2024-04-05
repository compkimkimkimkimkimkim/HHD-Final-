using HHD.BusinessLogicLayer;
using HHD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHD.UserInterfaceLayer.CMS
{
    public partial class EditRulerComunity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddRuler_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            if (txtTitleRuler.Text != null
                    )
            {

                int type = 100;
                var newUoN = new Community()
                {
                    Id = id,
                    Name = "MR.ADMIN",
                    Password = "123123",
                    Title = txtTitleRuler.Text,
                    Content = txtTitleRuler.Text,
                    CategoryId = type,
                    CreationTime = DateTime.Now,





                };
                CommunityBLL.UpdateCommunity(newUoN);





            }
        }

    }
}