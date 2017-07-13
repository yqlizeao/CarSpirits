using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// Register 的摘要说明
    /// </summary>
    public class Register : IHttpHandler
    {
        CarSpirits.BLL.Customer bll = new CarSpirits.BLL.Customer();
        CarSpirits.Model.Customer model = new CarSpirits.Model.Customer();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "register": register(context); break;
                default: break;
            }
        }
        private void register(HttpContext context)
        {
            model.CustomerID =  System.Guid.NewGuid().ToString();
            model.CustomerName = context.Request["CustomerName"].ToString();
            model.LoginName = context.Request["LoginName"].ToString();
            model.LoginPwd = context.Request["LoginPwd"].ToString();
            model.Sex = context.Request["Sex"].ToString();
            model.PhoneNum = context.Request["PhoneNum"].ToString();
            if (context.Request["Email"].ToString()!=null)
            {
            model.Email = context.Request["Email"].ToString();
              }
            if (bll.Exists(model.LoginName))
            {
                context.Response.Write("{\"Result\":\"0\"}");//存在此用户名
            }
            else
            {
                if (bll.Add(model) > 0)
                {
                    context.Response.Write("{\"Result\":\"1\"}");
                }
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