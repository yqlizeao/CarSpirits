using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarSpiritsWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["username"] != null)
            {
                string LoginName = Request.Form["username"];
                string LoginPassWord = Request.Form["userpwd"];
                CarSpirits.BLL.Admin bll = new CarSpirits.BLL.Admin();
                if (bll.Exists(LoginName, LoginPassWord))
                {
                    Response.Redirect("Index.aspx");
                }


            }

            

        }
    }
}