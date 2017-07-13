using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using CarSpirits.Common;

namespace CarSpiritsWeb.Sys.Customer
{
    public partial class UpdateCarInfo : System.Web.UI.Page
    {
        
        CarSpirits.BLL.OwnCar bll = new CarSpirits.BLL.OwnCar();
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = "";
            if (Request.Form["action"] != "")
                action = Request.Form["action"];


            switch (action)
            {
                case "query"://查询数据
                    QueryData();
                    break;
                case "queryone"://查询指定ID 的数据，修改时用
                    QueryOneData();
                    break;
                case "submit"://提交数据，添加或修改
                    UpdateData();
                    break;
                case "del"://删除数据
                    DelData();
                    break;
                default:
                    break;
            }
        }
        #region 删除指定ID 的数据
        /// <summary>
        /// 删除数据
        /// </summary>
        private void DelData()
        {
            string writeMsg = "删除失败！";

            string selectID = Request.Form["cbx_select"] != "" ? Request.Form["cbx_select"] : "";
            if (selectID != string.Empty && selectID != "0")
            {
                int delNum = DataHandler.DelData("OwnCar", selectID);
                if (delNum > 0)
                {
                    writeMsg = string.Format("删除成功，本次共删除{0}条", delNum.ToString());
                }
                else
                {
                    writeMsg = "删除失败！";
                }

            }

            Response.Clear();
            Response.Write(writeMsg);
            Response.End();
        }
        #endregion

        #region 添加或修改提交的数据
        /// <summary>
        /// 添加或修改数据
        /// </summary>
        private void UpdateData()
        {
            int id = Request.Form["id"] != "" ? Convert.ToInt32(Request.Form["id"]) : 0;
            CarSpirits.Model.OwnCar model = GetData(id);
            string writeMsg = "操作失败！";
            if (model != null)
            {
                if (id < 1)
                {

                    if (bll.Add(model) > 0)
                    {
                        writeMsg = "增加成功!";
                    }
                    else
                    {
                        writeMsg = "增加失败!";
                    }

                }
                else
                {

                    if (bll.Update(model))
                    {
                        writeMsg = "更新成功!";
                    }
                    else
                    {
                        writeMsg = "更新失败!";
                    }

                }
            }
            Response.Clear();
            Response.Write(writeMsg);
            Response.End();
        }
        /// <summary>
        /// 取得数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private CarSpirits.Model.OwnCar GetData(int id)
        {
            CarSpirits.Model.OwnCar model = new CarSpirits.Model.OwnCar();
            if (id > 0)
            {
                model = bll.GetModel(id);

            }
            else
            {

            }
            model.PlateNumber = Request.Form["ipt_platenumber"] != "" ? Request.Form["ipt_platenumber"] : "";
            model.GasOline = Request.Form["ipt_gasoline"] != "" ? Request.Form["ipt_gasoline"] : "";
            model.Brand = Request.Form["ipt_brand"] != "" ? Request.Form["ipt_brand"] : "";
            model.Style = Request.Form["ipt_style"] != "" ? Request.Form["ipt_style"] : "";
            model.Color = Request.Form["ipt_color"] != "" ? Request.Form["ipt_color"] : "";
            model.OilMass = Request.Form["ipt_oilmass"] != "" ? Request.Form["ipt_oilmass"] : "";
            model.Mileage = Request.Form["ipt_mileage"] != "" ? Request.Form["ipt_mileage"] : "";
            model.CarBreakDown = Request.Form["ipt_carbreakdown"] != "" ? Request.Form["ipt_carbreakdown"] : "";
            return model;
        }
        #endregion

        #region 查询指定ID 的数据
        /// <summary>
        /// 获取指定ID的数据
        /// </summary>
        private void QueryOneData()
        {

            int userid = Request.Form["id"] != "" ? Convert.ToInt32(Request.Form["id"]) : 0;
            DataSet ds = bll.GetList(1, "id=" + userid, "ID ASC");
            string strJSON = JsonHelper.CreateJsonOne(ds.Tables[0], false);
            Response.Clear();
            Response.Write(strJSON);
            Response.End();
        }
        #endregion

        #region 查询数据
        /// <summary>
        /// 组合搜索条件
        /// </summary>
        /// <returns></returns>
        private string GetWhere()
        {
            StringBuilder sb = new StringBuilder("1=1");
            string searchType = Request.Form["search_type"] != "" ? Request.Form["search_type"] : string.Empty;
            string searchValue = Request.Form["search_value"] != "" ? Request.Form["search_value"] : string.Empty;
            //string searchType = "";
            //string searchValue = "";
            if (searchType != null && searchValue != null)
            {
                sb.AppendFormat(" and charindex('{0}',{1})>0", searchValue, searchType);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        private void QueryData()
        {

            int page = Request.Form["page"] != "" ? Convert.ToInt32(Request.Form["page"]) : 0;
            int size = Request.Form["rows"] != "" ? Convert.ToInt32(Request.Form["rows"]) : 0;
            string sort = Request.Form["sort"] != "" ? Request.Form["sort"] : "";
            string order = Request.Form["order"] != "" ? Request.Form["order"] : "";
            if (page < 1) return;
            string orderField = sort.Replace("JSON_", "");
            string strWhere = GetWhere();

            DataSet dsCustomer = DataHandler.GetList("OwnCar", "*", "ID", size, page, false, false, strWhere);
            int count = bll.GetList(strWhere).Tables[0].Rows.Count;//获取总数
            string strJSON = JsonHelper.CreateJsonParameters(dsCustomer.Tables[0], true, count);
            Response.Write(strJSON);
            Response.End();

        }
        #endregion
    }
}