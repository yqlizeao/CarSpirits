using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// 数据访问类:Customer
	/// </summary>
	public partial class Customer
	{
		public Customer()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Customer");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        public bool Exists(string LoginName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Customer");
            strSql.Append(" where LoginName=@LoginName");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.NVarChar,100)
			};
            parameters[0].Value = LoginName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool Exists(string LoginName, string LoginPwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Customer");
            strSql.Append(" where LoginName=@LoginName and LoginPwd=@LoginPwd ");
            			SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.NVarChar,100),
                    new SqlParameter("@LoginPwd", SqlDbType.NVarChar,100)
			};
			parameters[0].Value = LoginName;
            parameters[1].Value = LoginPwd;
			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		
        }
        public bool Exists(string LoginName, string PhoneNum,string Email)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Customer");
            strSql.Append(" where LoginName=@LoginName and PhoneNum=@PhoneNum and Email=@Email");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.NVarChar,100),
                    new SqlParameter("@PhoneNum", SqlDbType.NVarChar,50),
                    new SqlParameter("@Email", SqlDbType.NVarChar,50),
			};
            parameters[0].Value = LoginName;
            parameters[1].Value = PhoneNum;
            parameters[2].Value = Email;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);

        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(CarSpirits.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Customer(");
            strSql.Append("CustomerID,CustomerName,LoginName,LoginPwd,Sex,PhoneNum,Email,Remark)");
			strSql.Append(" values (");
            strSql.Append("@CustomerID,@CustomerName,@LoginName,@LoginPwd,@Sex,@PhoneNum,@Email,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerName", SqlDbType.NVarChar,50),
					new SqlParameter("@LoginName", SqlDbType.NVarChar,100),
					new SqlParameter("@LoginPwd", SqlDbType.NVarChar,100),
					new SqlParameter("@Sex", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNum", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@CreateDate", SqlDbType.DateTime)};
			parameters[0].Value = model.CustomerID;
			parameters[1].Value = model.CustomerName;
			parameters[2].Value = model.LoginName;
			parameters[3].Value = model.LoginPwd;
			parameters[4].Value = model.Sex;
			parameters[5].Value = model.PhoneNum;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.CreateDate;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(CarSpirits.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Customer set ");
			strSql.Append("CustomerID=@CustomerID,");
			strSql.Append("CustomerName=@CustomerName,");
			strSql.Append("LoginName=@LoginName,");
			strSql.Append("LoginPwd=@LoginPwd,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("PhoneNum=@PhoneNum,");
			strSql.Append("Email=@Email,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("CreateDate=@CreateDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.NVarChar,50),
					new SqlParameter("@CustomerName", SqlDbType.NVarChar,50),
					new SqlParameter("@LoginName", SqlDbType.NVarChar,100),
					new SqlParameter("@LoginPwd", SqlDbType.NVarChar,100),
					new SqlParameter("@Sex", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNum", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CustomerID;
			parameters[1].Value = model.CustomerName;
			parameters[2].Value = model.LoginName;
			parameters[3].Value = model.LoginPwd;
			parameters[4].Value = model.Sex;
			parameters[5].Value = model.PhoneNum;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.CreateDate;
			parameters[9].Value = model.ID;

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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Customer ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public CarSpirits.Model.Customer GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CustomerID,CustomerName,LoginName,LoginPwd,Sex,PhoneNum,Email,Remark,CreateDate from Customer ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			CarSpirits.Model.Customer model=new CarSpirits.Model.Customer();
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
        public CarSpirits.Model.Customer GetModel(string LoginName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CustomerID,CustomerName,LoginName,LoginPwd,Sex,PhoneNum,Email,Remark,CreateDate from Customer ");
            strSql.Append(" where LoginName=@LoginName ");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.NVarChar,100)			};
            parameters[0].Value = LoginName;

            CarSpirits.Model.Customer model = new CarSpirits.Model.Customer();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CarSpirits.Model.Customer DataRowToModel(DataRow row)
		{
			CarSpirits.Model.Customer model=new CarSpirits.Model.Customer();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["CustomerID"]!=null)
				{
					model.CustomerID=row["CustomerID"].ToString();
				}
				if(row["CustomerName"]!=null)
				{
					model.CustomerName=row["CustomerName"].ToString();
				}
				if(row["LoginName"]!=null)
				{
					model.LoginName=row["LoginName"].ToString();
				}
				if(row["LoginPwd"]!=null)
				{
					model.LoginPwd=row["LoginPwd"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["PhoneNum"]!=null)
				{
					model.PhoneNum=row["PhoneNum"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomerID,CustomerName,LoginName,LoginPwd,Sex,PhoneNum,Email,Remark,CreateDate ");
			strSql.Append(" FROM Customer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,CustomerID,CustomerName,LoginName,LoginPwd,Sex,PhoneNum,Email,Remark,CreateDate ");
			strSql.Append(" FROM Customer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Customer ");
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
		/// 分页获取数据列表
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Customer T ");
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
		/// 分页获取数据列表
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
			parameters[0].Value = "Customer";
			parameters[1].Value = "ID";
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

