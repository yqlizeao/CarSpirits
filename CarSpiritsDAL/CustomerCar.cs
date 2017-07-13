using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// 数据访问类:CustomerCar
	/// </summary>
	public partial class CustomerCar
	{
		public CustomerCar()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int 编号)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerCar");
			strSql.Append(" where 编号=@编号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4)			};
			parameters[0].Value = 编号;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        public bool Exists(string 用户名)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CustomerCar");
            strSql.Append(" where 用户名=@用户名 ");
            SqlParameter[] parameters = {
					new SqlParameter("@用户名", SqlDbType.NVarChar,100)		};
            parameters[0].Value = 用户名;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CarSpirits.Model.CustomerCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CustomerCar(");
			strSql.Append("编号,客户编号,用户名,客户姓名,车牌号,油号,品牌,车型,颜色,油量,里数,车身维护信息)");
			strSql.Append(" values (");
			strSql.Append("@编号,@客户编号,@用户名,@客户姓名,@车牌号,@油号,@品牌,@车型,@颜色,@油量,@里数,@车身维护信息)");
			SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4),
					new SqlParameter("@客户编号", SqlDbType.NVarChar,50),
					new SqlParameter("@用户名", SqlDbType.NVarChar,100),
					new SqlParameter("@客户姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@车牌号", SqlDbType.NVarChar,20),
					new SqlParameter("@油号", SqlDbType.NVarChar,20),
					new SqlParameter("@品牌", SqlDbType.NVarChar,50),
					new SqlParameter("@车型", SqlDbType.NVarChar,50),
					new SqlParameter("@颜色", SqlDbType.NVarChar,20),
					new SqlParameter("@油量", SqlDbType.NVarChar,50),
					new SqlParameter("@里数", SqlDbType.NVarChar,50),
					new SqlParameter("@车身维护信息", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.编号;
			parameters[1].Value = model.客户编号;
			parameters[2].Value = model.用户名;
			parameters[3].Value = model.客户姓名;
			parameters[4].Value = model.车牌号;
			parameters[5].Value = model.油号;
			parameters[6].Value = model.品牌;
			parameters[7].Value = model.车型;
			parameters[8].Value = model.颜色;
			parameters[9].Value = model.油量;
			parameters[10].Value = model.里数;
			parameters[11].Value = model.车身维护信息;

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
		public bool Update(CarSpirits.Model.CustomerCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerCar set ");
			strSql.Append("编号=@编号,");
			strSql.Append("客户编号=@客户编号,");
			strSql.Append("用户名=@用户名,");
			strSql.Append("客户姓名=@客户姓名,");
			strSql.Append("车牌号=@车牌号,");
			strSql.Append("油号=@油号,");
			strSql.Append("品牌=@品牌,");
			strSql.Append("车型=@车型,");
			strSql.Append("颜色=@颜色,");
			strSql.Append("油量=@油量,");
			strSql.Append("里数=@里数,");
			strSql.Append("车身维护信息=@车身维护信息");
			strSql.Append(" where 编号=@编号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4),
					new SqlParameter("@客户编号", SqlDbType.NVarChar,50),
					new SqlParameter("@用户名", SqlDbType.NVarChar,100),
					new SqlParameter("@客户姓名", SqlDbType.NVarChar,50),
					new SqlParameter("@车牌号", SqlDbType.NVarChar,20),
					new SqlParameter("@油号", SqlDbType.NVarChar,20),
					new SqlParameter("@品牌", SqlDbType.NVarChar,50),
					new SqlParameter("@车型", SqlDbType.NVarChar,50),
					new SqlParameter("@颜色", SqlDbType.NVarChar,20),
					new SqlParameter("@油量", SqlDbType.NVarChar,50),
					new SqlParameter("@里数", SqlDbType.NVarChar,50),
					new SqlParameter("@车身维护信息", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.编号;
			parameters[1].Value = model.客户编号;
			parameters[2].Value = model.用户名;
			parameters[3].Value = model.客户姓名;
			parameters[4].Value = model.车牌号;
			parameters[5].Value = model.油号;
			parameters[6].Value = model.品牌;
			parameters[7].Value = model.车型;
			parameters[8].Value = model.颜色;
			parameters[9].Value = model.油量;
			parameters[10].Value = model.里数;
			parameters[11].Value = model.车身维护信息;

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
		public bool Delete(int 编号)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerCar ");
			strSql.Append(" where 编号=@编号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4)			};
			parameters[0].Value = 编号;

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
		public bool DeleteList(string 编号list )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerCar ");
			strSql.Append(" where 编号 in ("+编号list + ")  ");
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
		public CarSpirits.Model.CustomerCar GetModel(int 编号)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 编号,客户编号,用户名,客户姓名,车牌号,油号,品牌,车型,颜色,油量,里数,车身维护信息 from CustomerCar ");
			strSql.Append(" where 编号=@编号 ");
			SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.Int,4)			};
			parameters[0].Value = 编号;

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
		/// 得到一个对象实体
		/// </summary>
		public CarSpirits.Model.CustomerCar DataRowToModel(DataRow row)
		{
			CarSpirits.Model.CustomerCar model=new CarSpirits.Model.CustomerCar();
			if (row != null)
			{
				if(row["编号"]!=null && row["编号"].ToString()!="")
				{
					model.编号=int.Parse(row["编号"].ToString());
				}
				if(row["客户编号"]!=null)
				{
					model.客户编号=row["客户编号"].ToString();
				}
				if(row["用户名"]!=null)
				{
					model.用户名=row["用户名"].ToString();
				}
				if(row["客户姓名"]!=null)
				{
					model.客户姓名=row["客户姓名"].ToString();
				}
				if(row["车牌号"]!=null)
				{
					model.车牌号=row["车牌号"].ToString();
				}
				if(row["油号"]!=null)
				{
					model.油号=row["油号"].ToString();
				}
				if(row["品牌"]!=null)
				{
					model.品牌=row["品牌"].ToString();
				}
				if(row["车型"]!=null)
				{
					model.车型=row["车型"].ToString();
				}
				if(row["颜色"]!=null)
				{
					model.颜色=row["颜色"].ToString();
				}
				if(row["油量"]!=null)
				{
					model.油量=row["油量"].ToString();
				}
				if(row["里数"]!=null)
				{
					model.里数=row["里数"].ToString();
				}
				if(row["车身维护信息"]!=null)
				{
					model.车身维护信息=row["车身维护信息"].ToString();
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
			strSql.Append("select 编号,客户编号,用户名,客户姓名,车牌号,油号,品牌,车型,颜色,油量,里数,车身维护信息 ");
			strSql.Append(" FROM CustomerCar ");
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
			strSql.Append(" 编号,客户编号,用户名,客户姓名,车牌号,油号,品牌,车型,颜色,油量,里数,车身维护信息 ");
			strSql.Append(" FROM CustomerCar ");
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
				strSql.Append("order by T.编号 desc");
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
			parameters[0].Value = "CustomerCar";
			parameters[1].Value = "编号";
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

