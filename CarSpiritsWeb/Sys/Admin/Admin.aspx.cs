using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using CarSpirits.Common;

namespace CarSpiritsWeb.Sys.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        
        CarSpirits.BLL.Admin bll = new CarSpirits.BLL.Admin();
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
                int delNum = DataHandler.DelData("Admin", selectID);
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
            CarSpirits.Model.Admin model = GetData(id);
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
        private CarSpirits.Model.Admin GetData(int id)
        {
            CarSpirits.Model.Admin model = new CarSpirits.Model.Admin();
            if (id > 0)
            {
                model = bll.GetModel(id);

            }
            else
            {

            }
            model.AdminName = Request.Form["ipt_adminname"] != "" ? Request.Form["ipt_adminname"] : "";
            model.LoginName = Request.Form["ipt_loginname"] != "" ? Request.Form["ipt_loginname"] : "";
            model.Loginpassword = Request.Form["ipt_loginpassword"] != "" ? Request.Form["ipt_loginpassword"] : "";
            model.Email = Request.Form["ipt_email"] != "" ? Request.Form["ipt_email"]: "";
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

            DataSet dsAdmin = DataHandler.GetList("Admin", "*", "ID", size, page, false, false, strWhere);
            int count = bll.GetList(strWhere).Tables[0].Rows.Count;//获取总数
            string strJSON = JsonHelper.CreateJsonParameters(dsAdmin.Tables[0], true, count);
            Response.Write(strJSON);
            Response.End();

        }
        #endregion
    }
}