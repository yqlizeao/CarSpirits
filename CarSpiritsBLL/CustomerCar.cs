using System;
using System.Data;
using System.Collections.Generic;
using CarSpirits.Model;
namespace CarSpirits.BLL
{
	/// <summary>
	/// CustomerCar
	/// </summary>
	public partial class CustomerCar
	{
		private readonly CarSpirits.DAL.CustomerCar dal=new CarSpirits.DAL.CustomerCar();
		public CustomerCar()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int 编号)
		{
			return dal.Exists(编号);
		}
        public bool Exists(string 用户名)
        {
            return dal.Exists(用户名);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CarSpirits.Model.CustomerCar model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CarSpirits.Model.CustomerCar model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int 编号)
		{
			
			return dal.Delete(编号);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string 编号list )
		{
			return dal.DeleteList(编号list );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CarSpirits.Model.CustomerCar GetModel(int 编号)
		{
			
			return dal.GetModel(编号);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CarSpirits.Model.CustomerCar> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CarSpirits.Model.CustomerCar> DataTableToList(DataTable dt)
		{
			List<CarSpirits.Model.CustomerCar> modelList = new List<CarSpirits.Model.CustomerCar>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CarSpirits.Model.CustomerCar model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

