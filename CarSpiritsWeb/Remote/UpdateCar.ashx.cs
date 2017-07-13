using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// UpdateCar 的摘要说明
    /// </summary>
    public class UpdateCar : IHttpHandler
    {
        CarSpirits.BLL.OwnCar bll = new CarSpirits.BLL.OwnCar();
        CarSpirits.Model.OwnCar model = new CarSpirits.Model.OwnCar();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "update": update(context);
                    break;
                default: break;
            }
        }
        private void update(HttpContext context)
        {
            model = bll.GetModel(int.Parse(context.Request["ID"].ToString()));

            if (context.Request["PlateNumber"].ToString() != null) // 修改后的车牌号
            {
            model.PlateNumber = context.Request["PlateNumber"].ToString();}
            if (context.Request["GasOline"].ToString() != null)
            { 
            StringBuilder gasoline = new StringBuilder();
            gasoline.Append(context.Request["GasOline"].ToString());
            gasoline.Append("#");
            model.GasOline = gasoline.ToString();}
            if (context.Request["Brand"].ToString() != null)
            { 
            model.Brand = context.Request["Brand"].ToString();}
            if (context.Request["Style"].ToString() != null)
            { 
            model.Style = context.Request["Style"].ToString();}
            if (context.Request["Color"].ToString() != null)
            { 
            model.Color = context.Request["Color"].ToString();}
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