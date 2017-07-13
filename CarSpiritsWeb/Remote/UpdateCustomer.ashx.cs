using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// UpdateCustomer 的摘要说明
    /// </summary>
    public class UpdateCustomer : IHttpHandler
    {
        CarSpirits.BLL.Customer bll = new CarSpirits.BLL.Customer();
        CarSpirits.Model.Customer model = new CarSpirits.Model.Customer();//新建一个空model
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "update": update(context); break;
                case "updatepwd": updatepwd(context); break;
                default: break;
                
            }
        }
        private void update(HttpContext context)
        {
            model = bll.GetModel(context.Request["LoginName"].ToString());//根据loginname(用户名)得到实体并且赋到model里面

            if (context.Request["CustomerName"].ToString() != null)
            { 
            model.CustomerName = context.Request["CustomerName"].ToString();
            }
            if (context.Request["Sex"].ToString() != null)
            { 
            model.Sex = context.Request["Sex"].ToString();
            }
            if (context.Request["PhoneNum"].ToString() != null)
            { 
            model.PhoneNum = context.Request["PhoneNum"].ToString();
            }
            if (context.Request["Email"].ToString() != null)
            {
                model.Email = context.Request["Email"].ToString();
            }

            if(bll.Update(model)){
                context.Response.Write("{\"Result\":\"1\"}");
            }
            else
            {
                context.Response.Write("{\"Result\":\"0\"}");
            }
        }
        private void updatepwd(HttpContext context)
        {
            model = bll.GetModel(context.Request["LoginName"].ToString());//根据loginname得到实体并且赋到model里面

            model.LoginPwd = context.Request["LoginPwd"].ToString();

            if (bll.Update(model))
            {
                context.Response.Write("{\"Result\":\"1\"}");
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