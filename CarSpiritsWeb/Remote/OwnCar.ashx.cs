using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// OwnCar 的摘要说明
    /// </summary>
    public class OwnCar : IHttpHandler
    {
        CarSpirits.BLL.OwnCar bll = new CarSpirits.BLL.OwnCar();
        CarSpirits.Model.OwnCar model = new CarSpirits.Model.OwnCar();
        CarSpirits.BLL.Customer customerbll = new CarSpirits.BLL.Customer();
        CarSpirits.Model.Customer customermodel = new CarSpirits.Model.Customer();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "addcar": addcar(context);
                    break;
                default: break;
            }
         
        }
        private void addcar(HttpContext context)
        {
            customermodel.LoginName = context.Request["LoginName"].ToString();
            model.CustomerID = customerbll.GetModel(customermodel.LoginName).CustomerID.ToString();
            model.PlateNumber = context.Request["PlateNumber"].ToString();
            StringBuilder gasoline = new StringBuilder();
            gasoline.Append(context.Request["GasOline"].ToString());
            gasoline.Append("#");
            model.GasOline = gasoline.ToString();
            model.Brand = context.Request["Brand"].ToString();
            model.Style = context.Request["Style"].ToString();
            model.Color = context.Request["Color"].ToString();
            if (context.Request["OilMass"].ToString() != null)
            { 
            model.OilMass = context.Request["OilMass"].ToString();
            }
            if (context.Request["Mileage"].ToString() != null)
            { 
            model.Mileage = context.Request["Mileage"].ToString();
            }
            if (context.Request["CarBreakDown"].ToString() != null)
            { 
            model.CarBreakDown = context.Request["CarBreakDown"].ToString();
            }
            //if (bll.Exists(model.PlateNumber))
            //{
            //    context.Response.Write("{\"Result\":\"0\"}");//存在此辆车，无法添加
            //}
            //else
            //{
            //    if (bll.Add(model) > 0)
            //    {
            //        context.Response.Write("{\"Result\":\"1\"}");
            //    }
            //} //该方法可避免车牌号相同的重复添加，但是考虑到实际，觉得此办法容易产生报错或添加失败便取消此办法
            if (bll.Add(model) > 0)
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