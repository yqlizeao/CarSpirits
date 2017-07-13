using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CarSpirits.Common;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// FindOrder 的摘要说明
    /// </summary>
    public class FindOrder : IHttpHandler
    {
        CarSpirits.BLL.CustomerOrder bll = new CarSpirits.BLL.CustomerOrder();
        CarSpirits.Model.CustomerOrder model = new CarSpirits.Model.CustomerOrder();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "find": find(context);
                    break;
                default: break;
            }

        }
        private void find(HttpContext context)
        {
            if(bll.Exists(context.Request["LoginName"].ToString())){
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