using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CarSpirits.BLL;
using CarSpirits.Model;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {
        CarSpirits.BLL.Customer bll = new CarSpirits.BLL.Customer();
        CarSpirits.Model.Customer model = new CarSpirits.Model.Customer();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "login": login(context);
                    break;
                default: break;
            }

        }
        /// <summary>
        /// 判断登陆
        /// </summary>
        private void login(HttpContext context)
        {
           
            if (bll.Exists(context.Request["LoginName"].ToString(),context.Request["LoginPwd"].ToString()))
                
            {
                model = bll.GetModel(context.Request["LoginName"].ToString());//根据用户名（唯一）得到所有信息

                context.Response.Write("{\"Result\":\"1\",\"CustomerID\":\"" + model.CustomerID + "\",\"CustomerName\":\"" + model.CustomerName + "\",\"LoginName\":\"" + model.LoginName + "\",\"Sex\":\"" + model.Sex + "\",\"PhoneNum\":\"" + model.PhoneNum + "\",\"Email\":\"" + model.Email + "\"}");
            }
            else
            {
                context.Response.Write("{\"Result\":\"0\"}");
            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}