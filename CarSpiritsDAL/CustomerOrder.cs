using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// ���ݷ�����:CustomerOrder
	/// </summary>
	public partial class CustomerOrder
	{
		public CustomerOrder()
		{}
		#region  BasicMethod

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string �û���)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerOrder");
			strSql.Append(" where �û���=@�û��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@�û���", SqlDbType.NVarChar,100)			};
			parameters[0].Value = �û���;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Add(CarSpirits.Model.CustomerOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CustomerOrder(");
			strSql.Append("������,�û���,�û�����,�ֻ���,���ƺ�,����վ,�ͺ�,���,�µ�ʱ��)");
			strSql.Append(" values (");
			strSql.Append("@������,@�û���,@�û�����,@�ֻ���,@���ƺ�,@����վ,@�ͺ�,@���,@�µ�ʱ��)");
			SqlParameter[] parameters = {
					new SqlParameter("@������", SqlDbType.NVarChar,20),
					new SqlParameter("@�û���", SqlDbType.NVarChar,100),
					new SqlParameter("@�û�����", SqlDbType.NVarChar,50),
					new SqlParameter("@�ֻ���", SqlDbType.NVarChar,50),
					new SqlParameter("@���ƺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@����վ", SqlDbType.NVarChar,50),
					new SqlParameter("@�ͺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@���", SqlDbType.Decimal,5),
					new SqlParameter("@�µ�ʱ��", SqlDbType.DateTime)};
			parameters[0].Value = model.������;
			parameters[1].Value = model.�û���;
			parameters[2].Value = model.�û�����;
			parameters[3].Value = model.�ֻ���;
			parameters[4].Value = model.���ƺ�;
			parameters[5].Value = model.����վ;
			parameters[6].Value = model.�ͺ�;
			parameters[7].Value = model.���;
			parameters[8].Value = model.�µ�ʱ��;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(CarSpirits.Model.CustomerOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerOrder set ");
			strSql.Append("������=@������,");
			strSql.Append("�û���=@�û���,");
			strSql.Append("�û�����=@�û�����,");
			strSql.Append("�ֻ���=@�ֻ���,");
			strSql.Append("���ƺ�=@���ƺ�,");
			strSql.Append("����վ=@����վ,");
			strSql.Append("�ͺ�=@�ͺ�,");
			strSql.Append("���=@���,");
			strSql.Append("�µ�ʱ��=@�µ�ʱ��");
			strSql.Append(" where �û���=@�û��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@������", SqlDbType.NVarChar,20),
					new SqlParameter("@�û���", SqlDbType.NVarChar,100),
					new SqlParameter("@�û�����", SqlDbType.NVarChar,50),
					new SqlParameter("@�ֻ���", SqlDbType.NVarChar,50),
					new SqlParameter("@���ƺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@����վ", SqlDbType.NVarChar,50),
					new SqlParameter("@�ͺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@���", SqlDbType.Decimal,5),
					new SqlParameter("@�µ�ʱ��", SqlDbType.DateTime)};
			parameters[0].Value = model.������;
			parameters[1].Value = model.�û���;
			parameters[2].Value = model.�û�����;
			parameters[3].Value = model.�ֻ���;
			parameters[4].Value = model.���ƺ�;
			parameters[5].Value = model.����վ;
			parameters[6].Value = model.�ͺ�;
			parameters[7].Value = model.���;
			parameters[8].Value = model.�µ�ʱ��;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string �û���)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerOrder ");
			strSql.Append(" where �û���=@�û��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@�û���", SqlDbType.NVarChar,100)			};
			parameters[0].Value = �û���;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// ����ɾ������
		/// </summary>
		public bool DeleteList(string �û���list )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerOrder ");
			strSql.Append(" where �û��� in ("+�û���list + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public CarSpirits.Model.CustomerOrder GetModel(string �û���)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ������,�û���,�û�����,�ֻ���,���ƺ�,����վ,�ͺ�,���,�µ�ʱ�� from CustomerOrder ");
			strSql.Append(" where �û���=@�û��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@�û���", SqlDbType.NVarChar,100)			};
			parameters[0].Value = �û���;

			CarSpirits.Model.CustomerOrder model=new CarSpirits.Model.CustomerOrder();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public CarSpirits.Model.CustomerOrder DataRowToModel(DataRow row)
		{
			CarSpirits.Model.CustomerOrder model=new CarSpirits.Model.CustomerOrder();
			if (row != null)
			{
				if(row["������"]!=null)
				{
					model.������=row["������"].ToString();
				}
				if(row["�û���"]!=null)
				{
					model.�û���=row["�û���"].ToString();
				}
				if(row["�û�����"]!=null)
				{
					model.�û�����=row["�û�����"].ToString();
				}
				if(row["�ֻ���"]!=null)
				{
					model.�ֻ���=row["�ֻ���"].ToString();
				}
				if(row["���ƺ�"]!=null)
				{
					model.���ƺ�=row["���ƺ�"].ToString();
				}
				if(row["����վ"]!=null)
				{
					model.����վ=row["����վ"].ToString();
				}
				if(row["�ͺ�"]!=null)
				{
					model.�ͺ�=row["�ͺ�"].ToString();
				}
				if(row["���"]!=null && row["���"].ToString()!="")
				{
					model.���=decimal.Parse(row["���"].ToString());
				}
				if(row["�µ�ʱ��"]!=null && row["�µ�ʱ��"].ToString()!="")
				{
					model.�µ�ʱ��=DateTime.Parse(row["�µ�ʱ��"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ������,�û���,�û�����,�ֻ���,���ƺ�,����վ,�ͺ�,���,�µ�ʱ�� ");
			strSql.Append(" FROM CustomerOrder ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            strSql.Append(" order by �µ�ʱ�� desc");
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ������,�û���,�û�����,�ֻ���,���ƺ�,����վ,�ͺ�,���,�µ�ʱ�� ");
			strSql.Append(" FROM CustomerOrder ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ��ȡ��¼����
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM CustomerOrder ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.�û��� desc");
			}
			strSql.Append(")AS Row, T.*  from CustomerOrder T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "CustomerOrder";
			parameters[1].Value = "�û���";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

