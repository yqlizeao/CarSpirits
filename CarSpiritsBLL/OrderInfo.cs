using System;
using System.Data;
using System.Collections.Generic;

using CarSpirits.Model;
namespace CarSpirits.BLL
{
	/// <summary>
	/// OrderInfo
	/// </summary>
	public partial class OrderInfo
	{
		private readonly CarSpirits.DAL.OrderInfo dal=new CarSpirits.DAL.OrderInfo();
		public OrderInfo()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
        public bool Exists(string OrderID)
        {
            return dal.Exists(OrderID);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(CarSpirits.Model.OrderInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(CarSpirits.Model.OrderInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public CarSpirits.Model.OrderInfo GetModel(int id)
		{
			
			return dal.GetModel(id);
		}


		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<CarSpirits.Model.OrderInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<CarSpirits.Model.OrderInfo> DataTableToList(DataTable dt)
		{
			List<CarSpirits.Model.OrderInfo> modelList = new List<CarSpirits.Model.OrderInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CarSpirits.Model.OrderInfo model;
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		
	}
}

