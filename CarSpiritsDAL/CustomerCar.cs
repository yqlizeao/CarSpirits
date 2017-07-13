using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// ���ݷ�����:CustomerCar
	/// </summary>
	public partial class CustomerCar
	{
		public CustomerCar()
		{}
		#region  BasicMethod

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ���)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerCar");
			strSql.Append(" where ���=@��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@���", SqlDbType.Int,4)			};
			parameters[0].Value = ���;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        public bool Exists(string �û���)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CustomerCar");
            strSql.Append(" where �û���=@�û��� ");
            SqlParameter[] parameters = {
					new SqlParameter("@�û���", SqlDbType.NVarChar,100)		};
            parameters[0].Value = �û���;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Add(CarSpirits.Model.CustomerCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CustomerCar(");
			strSql.Append("���,�ͻ����,�û���,�ͻ�����,���ƺ�,�ͺ�,Ʒ��,����,��ɫ,����,����,����ά����Ϣ)");
			strSql.Append(" values (");
			strSql.Append("@���,@�ͻ����,@�û���,@�ͻ�����,@���ƺ�,@�ͺ�,@Ʒ��,@����,@��ɫ,@����,@����,@����ά����Ϣ)");
			SqlParameter[] parameters = {
					new SqlParameter("@���", SqlDbType.Int,4),
					new SqlParameter("@�ͻ����", SqlDbType.NVarChar,50),
					new SqlParameter("@�û���", SqlDbType.NVarChar,100),
					new SqlParameter("@�ͻ�����", SqlDbType.NVarChar,50),
					new SqlParameter("@���ƺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@�ͺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@Ʒ��", SqlDbType.NVarChar,50),
					new SqlParameter("@����", SqlDbType.NVarChar,50),
					new SqlParameter("@��ɫ", SqlDbType.NVarChar,20),
					new SqlParameter("@����", SqlDbType.NVarChar,50),
					new SqlParameter("@����", SqlDbType.NVarChar,50),
					new SqlParameter("@����ά����Ϣ", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.���;
			parameters[1].Value = model.�ͻ����;
			parameters[2].Value = model.�û���;
			parameters[3].Value = model.�ͻ�����;
			parameters[4].Value = model.���ƺ�;
			parameters[5].Value = model.�ͺ�;
			parameters[6].Value = model.Ʒ��;
			parameters[7].Value = model.����;
			parameters[8].Value = model.��ɫ;
			parameters[9].Value = model.����;
			parameters[10].Value = model.����;
			parameters[11].Value = model.����ά����Ϣ;

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
		public bool Update(CarSpirits.Model.CustomerCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerCar set ");
			strSql.Append("���=@���,");
			strSql.Append("�ͻ����=@�ͻ����,");
			strSql.Append("�û���=@�û���,");
			strSql.Append("�ͻ�����=@�ͻ�����,");
			strSql.Append("���ƺ�=@���ƺ�,");
			strSql.Append("�ͺ�=@�ͺ�,");
			strSql.Append("Ʒ��=@Ʒ��,");
			strSql.Append("����=@����,");
			strSql.Append("��ɫ=@��ɫ,");
			strSql.Append("����=@����,");
			strSql.Append("����=@����,");
			strSql.Append("����ά����Ϣ=@����ά����Ϣ");
			strSql.Append(" where ���=@��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@���", SqlDbType.Int,4),
					new SqlParameter("@�ͻ����", SqlDbType.NVarChar,50),
					new SqlParameter("@�û���", SqlDbType.NVarChar,100),
					new SqlParameter("@�ͻ�����", SqlDbType.NVarChar,50),
					new SqlParameter("@���ƺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@�ͺ�", SqlDbType.NVarChar,20),
					new SqlParameter("@Ʒ��", SqlDbType.NVarChar,50),
					new SqlParameter("@����", SqlDbType.NVarChar,50),
					new SqlParameter("@��ɫ", SqlDbType.NVarChar,20),
					new SqlParameter("@����", SqlDbType.NVarChar,50),
					new SqlParameter("@����", SqlDbType.NVarChar,50),
					new SqlParameter("@����ά����Ϣ", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.���;
			parameters[1].Value = model.�ͻ����;
			parameters[2].Value = model.�û���;
			parameters[3].Value = model.�ͻ�����;
			parameters[4].Value = model.���ƺ�;
			parameters[5].Value = model.�ͺ�;
			parameters[6].Value = model.Ʒ��;
			parameters[7].Value = model.����;
			parameters[8].Value = model.��ɫ;
			parameters[9].Value = model.����;
			parameters[10].Value = model.����;
			parameters[11].Value = model.����ά����Ϣ;

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
		public bool Delete(int ���)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerCar ");
			strSql.Append(" where ���=@��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@���", SqlDbType.Int,4)			};
			parameters[0].Value = ���;

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
		public bool DeleteList(string ���list )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerCar ");
			strSql.Append(" where ��� in ("+���list + ")  ");
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
		public CarSpirits.Model.CustomerCar GetModel(int ���)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ���,�ͻ����,�û���,�ͻ�����,���ƺ�,�ͺ�,Ʒ��,����,��ɫ,����,����,����ά����Ϣ from CustomerCar ");
			strSql.Append(" where ���=@��� ");
			SqlParameter[] parameters = {
					new SqlParameter("@���", SqlDbType.Int,4)			};
			parameters[0].Value = ���;

			CarSpirits.Model.CustomerCar model=new CarSpirits.Model.CustomerCar();
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
		public CarSpirits.Model.CustomerCar DataRowToModel(DataRow row)
		{
			CarSpirits.Model.CustomerCar model=new CarSpirits.Model.CustomerCar();
			if (row != null)
			{
				if(row["���"]!=null && row["���"].ToString()!="")
				{
					model.���=int.Parse(row["���"].ToString());
				}
				if(row["�ͻ����"]!=null)
				{
					model.�ͻ����=row["�ͻ����"].ToString();
				}
				if(row["�û���"]!=null)
				{
					model.�û���=row["�û���"].ToString();
				}
				if(row["�ͻ�����"]!=null)
				{
					model.�ͻ�����=row["�ͻ�����"].ToString();
				}
				if(row["���ƺ�"]!=null)
				{
					model.���ƺ�=row["���ƺ�"].ToString();
				}
				if(row["�ͺ�"]!=null)
				{
					model.�ͺ�=row["�ͺ�"].ToString();
				}
				if(row["Ʒ��"]!=null)
				{
					model.Ʒ��=row["Ʒ��"].ToString();
				}
				if(row["����"]!=null)
				{
					model.����=row["����"].ToString();
				}
				if(row["��ɫ"]!=null)
				{
					model.��ɫ=row["��ɫ"].ToString();
				}
				if(row["����"]!=null)
				{
					model.����=row["����"].ToString();
				}
				if(row["����"]!=null)
				{
					model.����=row["����"].ToString();
				}
				if(row["����ά����Ϣ"]!=null)
				{
					model.����ά����Ϣ=row["����ά����Ϣ"].ToString();
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
			strSql.Append("select ���,�ͻ����,�û���,�ͻ�����,���ƺ�,�ͺ�,Ʒ��,����,��ɫ,����,����,����ά����Ϣ ");
			strSql.Append(" FROM CustomerCar ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
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
			strSql.Append(" ���,�ͻ����,�û���,�ͻ�����,���ƺ�,�ͺ�,Ʒ��,����,��ɫ,����,����,����ά����Ϣ ");
			strSql.Append(" FROM CustomerCar ");
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
			strSql.Append("select count(1) FROM CustomerCar ");
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
				strSql.Append("order by T.��� desc");
			}
			strSql.Append(")AS Row, T.*  from CustomerCar T ");
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
			parameters[0].Value = "CustomerCar";
			parameters[1].Value = "���";
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

