using System;
using System.Data;
using System.Collections.Generic;

using CarSpirits.Model;
namespace CarSpirits.BLL
{
	/// <summary>
	/// CustomerOrder
	/// </summary>
	public partial class CustomerOrder
	{
		private readonly CarSpirits.DAL.CustomerOrder dal=new CarSpirits.DAL.CustomerOrder();
		public CustomerOrder()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string �û���)
		{
			return dal.Exists(�û���);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Add(CarSpirits.Model.CustomerOrder model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(CarSpirits.Model.CustomerOrder model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string �û���)
		{
			
			return dal.Delete(�û���);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string �û���list )
		{
			return dal.DeleteList(�û���list );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public CarSpirits.Model.CustomerOrder GetModel(string �û���)
		{
			
			return dal.GetModel(�û���);
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
		public List<CarSpirits.Model.CustomerOrder> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<CarSpirits.Model.CustomerOrder> DataTableToList(DataTable dt)
		{
			List<CarSpirits.Model.CustomerOrder> modelList = new List<CarSpirits.Model.CustomerOrder>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CarSpirits.Model.CustomerOrder model;
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
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

