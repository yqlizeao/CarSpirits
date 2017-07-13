using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CarSpirits.Common;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// MyCar 的摘要说明
    /// </summary>
    public class MyCar : IHttpHandler
    {
        CarSpirits.BLL.CustomerCar bll = new CarSpirits.BLL.CustomerCar();
        CarSpirits.Model.CustomerCar model = new CarSpirits.Model.CustomerCar();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "mycar": maycar(context);
                    break;
                default: break;
            }
        }
        private void maycar(HttpContext context)
        {
            if (bll.Exists(context.Request["LoginName"].ToString()))
            {
                string strwhere = "用户名=" + "'" + context.Request["LoginName"].ToString() + "'";
                DataSet ds = bll.GetList(strwhere);
                DataTable dt = ds.Tables[0];
                string strJSON = JsonHelper.CreateJsonParameters(dt);
                context.Response.Write(strJSON);
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