using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CarSpirits.DBUtility;
namespace CarSpirits.DAL
{
	/// <summary>
	/// 数据访问类:OwnCar
	/// </summary>
	public partial class OwnCar
	{
		public OwnCar()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OwnCar");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        public bool Exists(string PlateNumber)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OwnCar");
            strSql.Append(" where PlateNumber=@PlateNumber");
            SqlParameter[] parameters = {
					new SqlParameter("@PlateNumber", SqlDbType.NVarChar,20)
			};
            parameters[0].Value = PlateNumber;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(CarSpirits.Model.OwnCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OwnCar(");
			strSql.Append("CustomerID,PlateNumber,GasOline,Brand,Style,Color,OilMass,Mileage,CarBreakDown)");
			strSql.Append(" values (");
			strSql.Append("@CustomerID,@PlateNumber,@GasOline,@Brand,@Style,@Color,@OilMass,@Mileage,@CarBreakDown)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.NVarChar,50),
					new SqlParameter("@PlateNumber", SqlDbType.NVarChar,20),
					new SqlParameter("@GasOline", SqlDbType.NVarChar,20),
					new SqlParameter("@Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Style", SqlDbType.NVarChar,50),
					new SqlParameter("@Color", SqlDbType.NVarChar,20),
					new SqlParameter("@OilMass", SqlDbType.NVarChar,50),
					new SqlParameter("@Mileage", SqlDbType.NVarChar,50),
					new SqlParameter("@CarBreakDown", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.CustomerID;
			parameters[1].Value = model.PlateNumber;
			parameters[2].Value = model.GasOline;
			parameters[3].Value = model.Brand;
			parameters[4].Value = model.Style;
			parameters[5].Value = model.Color;
			parameters[6].Value = model.OilMass;
			parameters[7].Value = model.Mileage;
			parameters[8].Value = model.CarBreakDown;

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
		public bool Update(CarSpirits.Model.OwnCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OwnCar set ");
			strSql.Append("CustomerID=@CustomerID,");
			strSql.Append("PlateNumber=@PlateNumber,");
			strSql.Append("GasOline=@GasOline,");
			strSql.Append("Brand=@Brand,");
			strSql.Append("Style=@Style,");
			strSql.Append("Color=@Color,");
			strSql.Append("OilMass=@OilMass,");
			strSql.Append("Mileage=@Mileage,");
			strSql.Append("CarBreakDown=@CarBreakDown");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerID", SqlDbType.NVarChar,50),
					new SqlParameter("@PlateNumber", SqlDbType.NVarChar,20),
					new SqlParameter("@GasOline", SqlDbType.NVarChar,20),
					new SqlParameter("@Brand", SqlDbType.NVarChar,50),
					new SqlParameter("@Style", SqlDbType.NVarChar,50),
					new SqlParameter("@Color", SqlDbType.NVarChar,20),
					new SqlParameter("@OilMass", SqlDbType.NVarChar,50),
					new SqlParameter("@Mileage", SqlDbType.NVarChar,50),
					new SqlParameter("@CarBreakDown", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CustomerID;
			parameters[1].Value = model.PlateNumber;
			parameters[2].Value = model.GasOline;
			parameters[3].Value = model.Brand;
			parameters[4].Value = model.Style;
			parameters[5].Value = model.Color;
			parameters[6].Value = model.OilMass;
			parameters[7].Value = model.Mileage;
			parameters[8].Value = model.CarBreakDown;
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
			strSql.Append("delete from OwnCar ");
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
			strSql.Append("delete from OwnCar ");
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
		public CarSpirits.Model.OwnCar GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CustomerID,PlateNumber,GasOline,Brand,Style,Color,OilMass,Mileage,CarBreakDown from OwnCar ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			CarSpirits.Model.OwnCar model=new CarSpirits.Model.OwnCar();
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
        public CarSpirits.Model.OwnCar GetModel(string PlateNumber)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CustomerID,PlateNumber,GasOline,Brand,Style,Color,OilMass,Mileage,CarBreakDown from OwnCar ");
            strSql.Append(" where PlateNumber=@PlateNumber");
            SqlParameter[] parameters = {
					new SqlParameter("@PlateNumber", SqlDbType.NVarChar,20)
			};
            parameters[0].Value = PlateNumber;

            CarSpirits.Model.OwnCar model = new CarSpirits.Model.OwnCar();
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
		public CarSpirits.Model.OwnCar DataRowToModel(DataRow row)
		{
			CarSpirits.Model.OwnCar model=new CarSpirits.Model.OwnCar();
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
				if(row["PlateNumber"]!=null)
				{
					model.PlateNumber=row["PlateNumber"].ToString();
				}
				if(row["GasOline"]!=null)
				{
					model.GasOline=row["GasOline"].ToString();
				}
				if(row["Brand"]!=null)
				{
					model.Brand=row["Brand"].ToString();
				}
				if(row["Style"]!=null)
				{
					model.Style=row["Style"].ToString();
				}
				if(row["Color"]!=null)
				{
					model.Color=row["Color"].ToString();
				}
				if(row["OilMass"]!=null)
				{
					model.OilMass=row["OilMass"].ToString();
				}
				if(row["Mileage"]!=null)
				{
					model.Mileage=row["Mileage"].ToString();
				}
				if(row["CarBreakDown"]!=null)
				{
					model.CarBreakDown=row["CarBreakDown"].ToString();
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
			strSql.Append("select ID,CustomerID,PlateNumber,GasOline,Brand,Style,Color,OilMass,Mileage,CarBreakDown ");
			strSql.Append(" FROM OwnCar ");
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
			strSql.Append(" ID,CustomerID,PlateNumber,GasOline,Brand,Style,Color,OilMass,Mileage,CarBreakDown ");
			strSql.Append(" FROM OwnCar ");
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
			strSql.Append("select count(1) FROM OwnCar ");
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
			strSql.Append(")AS Row, T.*  from OwnCar T ");
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
			parameters[0].Value = "OwnCar";
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

