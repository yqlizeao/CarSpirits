using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CarSpiritsWeb.Remote
{
    /// <summary>
    /// Order 的摘要说明
    /// </summary>
    public class Order : IHttpHandler
    {
        CarSpirits.BLL.OrderInfo bll = new CarSpirits.BLL.OrderInfo();
        CarSpirits.Model.OrderInfo model = new CarSpirits.Model.OrderInfo();
        CarSpirits.BLL.Customer customerbll = new CarSpirits.BLL.Customer();
        CarSpirits.Model.Customer customermodel = new CarSpirits.Model.Customer();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            switch (context.Request["type"])
            {
                case "order": order(context);
                    break;
                default: break;
            }
        }
        private void order(HttpContext context)
        {
            StringBuilder carid = new StringBuilder();
            carid.Append("CS-");
            carid.Append(System.DateTime.Now.ToString("yyyyMMddhhmmss"));
            model.OrderID = carid.ToString();
            customermodel.LoginName = context.Request["LoginName"].ToString();
            model.CustomerID = customerbll.GetModel(customermodel.LoginName).CustomerID.ToString();
            model.PlateNumber = context.Request["PlateNumber"].ToString();
            model.GasStation = context.Request["GasStation"].ToString();

            StringBuilder gasoline = new StringBuilder();
            gasoline.Append(context.Request["GasOline"].ToString());
            gasoline.Append("#");
            model.GasOline = gasoline.ToString();

            string price = context.Request["Price"].ToString();
            decimal money = decimal.Parse(price);
            model.Price = money;

              
            if (bll.Exists(model.OrderID))
            {
                context.Response.Write("{\"Result\":\"0\"}");//存在此订单，无法添加bug：一秒内一个订单
            }
            else
            {
                if (bll.Add(model) > 0)
                {
                    context.Response.Write("{\"Result\":\"1\",\"OrderID\":\"" + model.OrderID + "\",\"PlateNumber\":\"" + model.PlateNumber + "\",\"GasStation\":\"" + model.GasStation + "\",\"GasOline\":\"" + model.GasOline + "\",\"Price\":\"" + model.Price + "\",\"OrderTime\":\"" + model.OrderTime + "\"}");
                }
                else
                {
                    context.Response.Write("{\"Result\":\"2\"}");//数据库问题 没有添加成功
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