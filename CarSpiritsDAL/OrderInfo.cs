using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// ���ݷ�����:OrderInfo
	/// </summary>
	public partial class OrderInfo
	{
		public OrderInfo()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OrderInfo");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		public bool Exists(string OrderID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OrderInfo");
            strSql.Append(" where OrderID=@OrderID");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderID", SqlDbType.NVarChar,20)
			};
            parameters[0].Value = OrderID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(CarSpirits.Model.OrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderInfo(");
			strSql.Append("CustomerID,OrderID,PlateNumber,GasStation,GasOline,Price,OrderTime)");
			strSql.Append(" values (");
			strSql.Append("@CustomerID,@OrderID,@PlateNumber,@GasStation,@GasOline,@Price,@OrderTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderID", SqlDbType.NVarChar,50),
					new SqlParameter("@PlateNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GasStation", SqlDbType.NVarChar,50),
					new SqlParameter("@GasOline", SqlDbType.NVarChar,20),
					new SqlParameter("@Price", SqlDbType.Decimal,5),
					new SqlParameter("@OrderTime", SqlDbType.DateTime)};
			parameters[0].Value = model.CustomerID;
			parameters[1].Value = model.OrderID;
			parameters[2].Value = model.PlateNumber;
			parameters[3].Value = model.GasStation;
			parameters[4].Value = model.GasOline;
			parameters[5].Value = model.Price;
			parameters[6].Value = model.OrderTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// ����һ������
		/// </summary>
		public bool Update(CarSpirits.Model.OrderInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderInfo set ");
			strSql.Append("CustomerID=@CustomerID,");
			strSql.Append("OrderID=@OrderID,");
			strSql.Append("PlateNumber=@PlateNumber,");
			strSql.Append("GasStation=@GasStation,");
			strSql.Append("GasOline=@GasOline,");
			strSql.Append("Price=@Price,");
			strSql.Append("OrderTime=@OrderTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderID", SqlDbType.NVarChar,50),
					new SqlParameter("@PlateNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GasStation", SqlDbType.NVarChar,50),
					new SqlParameter("@GasOline", SqlDbType.NVarChar,20),
					new SqlParameter("@Price", SqlDbType.Decimal,5),
					new SqlParameter("@OrderTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.CustomerID;
			parameters[1].Value = model.OrderID;
			parameters[2].Value = model.PlateNumber;
			parameters[3].Value = model.GasStation;
			parameters[4].Value = model.GasOline;
			parameters[5].Value = model.Price;
			parameters[6].Value = model.OrderTime;
			parameters[7].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OrderInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OrderInfo ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public CarSpirits.Model.OrderInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,CustomerID,OrderID,PlateNumber,GasStation,GasOline,Price,OrderTime from OrderInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			CarSpirits.Model.OrderInfo model=new CarSpirits.Model.OrderInfo();
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
		public CarSpirits.Model.OrderInfo DataRowToModel(DataRow row)
		{
			CarSpirits.Model.OrderInfo model=new CarSpirits.Model.OrderInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["CustomerID"]!=null)
				{
					model.CustomerID=row["CustomerID"].ToString();
				}
				if(row["OrderID"]!=null)
				{
					model.OrderID=row["OrderID"].ToString();
				}
				if(row["PlateNumber"]!=null)
				{
					model.PlateNumber=row["PlateNumber"].ToString();
				}
				if(row["GasStation"]!=null)
				{
					model.GasStation=row["GasStation"].ToString();
				}
				if(row["GasOline"]!=null)
				{
					model.GasOline=row["GasOline"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["OrderTime"]!=null && row["OrderTime"].ToString()!="")
				{
					model.OrderTime=DateTime.Parse(row["OrderTime"].ToString());
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
			strSql.Append("select id,CustomerID,OrderID,PlateNumber,GasStation,GasOline,Price,OrderTime ");
			strSql.Append(" FROM OrderInfo ");
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
			strSql.Append(" id,CustomerID,OrderID,PlateNumber,GasStation,GasOline,Price,OrderTime ");
			strSql.Append(" FROM OrderInfo ");
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
			strSql.Append("select count(1) FROM OrderInfo ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from OrderInfo T ");
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
			parameters[0].Value = "OrderInfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		
	}
}

