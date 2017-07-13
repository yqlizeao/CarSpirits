using System;
using System.Data;
using System.Collections.Generic;

using CarSpirits.Model;
namespace CarSpirits.BLL
{
	/// <summary>
	/// Customer
	/// </summary>
	public partial class Customer
	{
		private readonly CarSpirits.DAL.Customer dal=new CarSpirits.DAL.Customer();
		public Customer()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}
        public bool Exists(string LoginName)
        {
            return dal.Exists(LoginName);
        }

        public bool Exists(string LoginName, string LoginPwd)
        {
            return dal.Exists(LoginName,LoginPwd);
        }
        public bool Exists(string LoginName, string PhoneNum,string Email)
        {
            return dal.Exists(LoginName,PhoneNum,Email);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(CarSpirits.Model.Customer model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(CarSpirits.Model.Customer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public CarSpirits.Model.Customer GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}
        public CarSpirits.Model.Customer GetModel(string LoginName)
        {

            return dal.GetModel(LoginName);
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
		public List<CarSpirits.Model.Customer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<CarSpirits.Model.Customer> DataTableToList(DataTable dt)
		{
			List<CarSpirits.Model.Customer> modelList = new List<CarSpirits.Model.Customer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CarSpirits.Model.Customer model;
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

