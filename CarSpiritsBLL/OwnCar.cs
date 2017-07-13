using System;
using System.Data;
using System.Collections.Generic;
using CarSpirits.Model;
namespace CarSpirits.BLL
{
	/// <summary>
	/// OwnCar
	/// </summary>
	public partial class OwnCar
	{
		private readonly CarSpirits.DAL.OwnCar dal=new CarSpirits.DAL.OwnCar();
		public OwnCar()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}
        public bool Exists(string PlateNumber)
        {
            return dal.Exists(PlateNumber);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(CarSpirits.Model.OwnCar model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CarSpirits.Model.OwnCar model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CarSpirits.Model.OwnCar GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}
        public CarSpirits.Model.OwnCar GetModel(string PlateNumber)
        {

            return dal.GetModel(PlateNumber);
        }

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>


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
		public List<CarSpirits.Model.OwnCar> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CarSpirits.Model.OwnCar> DataTableToList(DataTable dt)
		{
			List<CarSpirits.Model.OwnCar> modelList = new List<CarSpirits.Model.OwnCar>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CarSpirits.Model.OwnCar model;
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
		
	}
}

