using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// 数据访问类:CustomerOrder
	/// </summary>
	public partial class CustomerOrder
	{
		public CustomerOrder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string 用户名)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerOrder");
			strSql.Append(" where 用户名=@用户名 ");
			SqlParameter[] parameters = {
					new SqlParameter("@用户名", SqlDbType.NVarChar,100)			};
			parameters[0].Value = 用户名;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CarSpirits.Model.CustomerOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CustomerOrder(");
			strSql.Append("订单号,用户名,用户姓名,手机号,车牌号,加油站,油号,金额,下单时间)");
			strSql.Append(" values (");
			strSql.Append("@订单号,@用户名,@用户姓名,@手机号,@车牌号,@加油站,@油号,@金额,@下单时间)");
			SqlParameter[] parameters = {
					new SqlParameter("@订单号", SqlDbType.NVarChar,20),
					new SqlParameter("@用户名", SqlDbType.NVarChar,100),
					new SqlParameter("@用户姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@手机号", SqlDbType.NVarChar,50),
					new SqlParameter("@车牌号", SqlDbType.NVarChar,20),
					new SqlParameter("@加油站", SqlDbType.NVarChar,50),
					new SqlParameter("@油号", SqlDbType.NVarChar,20),
					new SqlParameter("@金额", SqlDbType.Decimal,5),
					new SqlParameter("@下单时间", SqlDbType.DateTime)};
			parameters[0].Value = model.订单号;
			parameters[1].Value = model.用户名;
			parameters[2].Value = model.用户姓名;
			parameters[3].Value = model.手机号;
			parameters[4].Value = model.车牌号;
			parameters[5].Value = model.加油站;
			parameters[6].Value = model.油号;
			parameters[7].Value = model.金额;
			parameters[8].Value = model.下单时间;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(CarSpirits.Model.CustomerOrder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerOrder set ");
			strSql.Append("订单号=@订单号,");
			strSql.Append("用户名=@用户名,");
			strSql.Append("用户姓名=@用户姓名,");
			strSql.Append("手机号=@手机号,");
			strSql.Append("车牌号=@车牌号,");
			strSql.Append("加油站=@加油站,");
			strSql.Append("油号=@油号,");
			strSql.Append("金额=@金额,");
			strSql.Append("下单时间=@下单时间");
			strSql.Append(" where 用户名=@用户名 ");
			SqlParameter[] parameters = {
					new SqlParameter("@订单号", SqlDbType.NVarChar,20),
					new SqlParameter("@用户名", SqlDbType.NVarChar,100),
					new SqlParameter("@用户姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@手机号", SqlDbType.NVarChar,50),
					new SqlParameter("@车牌号", SqlDbType.NVarChar,20),
					new SqlParameter("@加油站", SqlDbType.NVarChar,50),
					new SqlParameter("@油号", SqlDbType.NVarChar,20),
					new SqlParameter("@金额", SqlDbType.Decimal,5),
					new SqlParameter("@下单时间", SqlDbType.DateTime)};
			parameters[0].Value = model.订单号;
			parameters[1].Value = model.用户名;
			parameters[2].Value = model.用户姓名;
			parameters[3].Value = model.手机号;
			parameters[4].Value = model.车牌号;
			parameters[5].Value = model.加油站;
			parameters[6].Value = model.油号;
			parameters[7].Value = model.金额;
			parameters[8].Value = model.下单时间;

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
		public bool Delete(string 用户名)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerOrder ");
			strSql.Append(" where 用户名=@用户名 ");
			SqlParameter[] parameters = {
					new SqlParameter("@用户名", SqlDbType.NVarChar,100)			};
			parameters[0].Value = 用户名;

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
		public bool DeleteList(string 用户名list )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerOrder ");
			strSql.Append(" where 用户名 in ("+用户名list + ")  ");
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
		public CarSpirits.Model.CustomerOrder GetModel(string 用户名)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 订单号,用户名,用户姓名,手机号,车牌号,加油站,油号,金额,下单时间 from CustomerOrder ");
			strSql.Append(" where 用户名=@用户名 ");
			SqlParameter[] parameters = {
					new SqlParameter("@用户名", SqlDbType.NVarChar,100)			};
			parameters[0].Value = 用户名;

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
		/// 得到一个对象实体
		/// </summary>
		public CarSpirits.Model.CustomerOrder DataRowToModel(DataRow row)
		{
			CarSpirits.Model.CustomerOrder model=new CarSpirits.Model.CustomerOrder();
			if (row != null)
			{
				if(row["订单号"]!=null)
				{
					model.订单号=row["订单号"].ToString();
				}
				if(row["用户名"]!=null)
				{
					model.用户名=row["用户名"].ToString();
				}
				if(row["用户姓名"]!=null)
				{
					model.用户姓名=row["用户姓名"].ToString();
				}
				if(row["手机号"]!=null)
				{
					model.手机号=row["手机号"].ToString();
				}
				if(row["车牌号"]!=null)
				{
					model.车牌号=row["车牌号"].ToString();
				}
				if(row["加油站"]!=null)
				{
					model.加油站=row["加油站"].ToString();
				}
				if(row["油号"]!=null)
				{
					model.油号=row["油号"].ToString();
				}
				if(row["金额"]!=null && row["金额"].ToString()!="")
				{
					model.金额=decimal.Parse(row["金额"].ToString());
				}
				if(row["下单时间"]!=null && row["下单时间"].ToString()!="")
				{
					model.下单时间=DateTime.Parse(row["下单时间"].ToString());
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
			strSql.Append("select 订单号,用户名,用户姓名,手机号,车牌号,加油站,油号,金额,下单时间 ");
			strSql.Append(" FROM CustomerOrder ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            strSql.Append(" order by 下单时间 desc");
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
			strSql.Append(" 订单号,用户名,用户姓名,手机号,车牌号,加油站,油号,金额,下单时间 ");
			strSql.Append(" FROM CustomerOrder ");
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
				strSql.Append("order by T.用户名 desc");
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
			parameters[0].Value = "CustomerOrder";
			parameters[1].Value = "用户名";
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

