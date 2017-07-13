using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// ForgetPwd 的摘要说明
    /// </summary>
    public class ForgetPwd : IHttpHandler
    {

        CarSpirits.BLL.Customer bll = new CarSpirits.BLL.Customer();
        CarSpirits.Model.Customer model = new CarSpirits.Model.Customer();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "getpwd": getpwd(context);
                    break;
                default: break;
            }

        }
        private void getpwd(HttpContext context)
        {
            if (bll.Exists(context.Request["LoginName"].ToString(), context.Request["PhoneNum"].ToString(), context.Request["Email"].ToString()))
            {
                model = bll.GetModel(context.Request["LoginName"].ToString());
                model.LoginPwd = context.Request["LoginPwd"].ToString();
                bll.Update(model);
                context.Response.Write("{\"Result\":\"1\",\"LoginPwd\":\"" + model.LoginPwd +"\"}");
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