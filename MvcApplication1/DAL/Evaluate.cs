using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Conris.Utility;
namespace DBA.DAL
{
	/// <summary>
	/// 数据访问类:Evaluate
	/// </summary>
	public partial class Evaluate
	{
		public Evaluate()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Evaluate"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Evaluate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DBA.Model.Evaluate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Evaluate(");
			strSql.Append("GHSID,GHS,ND,YD,Score,EUrl,Str1,Str2,Str3)");
			strSql.Append(" values (");
			strSql.Append("@GHSID,@GHS,@ND,@YD,@Score,@EUrl,@Str1,@Str2,@Str3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GHSID", SqlDbType.NVarChar,200),
					new SqlParameter("@GHS", SqlDbType.NVarChar,200),
					new SqlParameter("@ND", SqlDbType.NVarChar,200),
					new SqlParameter("@YD", SqlDbType.NVarChar,200),
					new SqlParameter("@Score", SqlDbType.NVarChar,200),
					new SqlParameter("@EUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Str1", SqlDbType.NVarChar,200),
					new SqlParameter("@Str2", SqlDbType.NVarChar,200),
					new SqlParameter("@Str3", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.GHSID;
			parameters[1].Value = model.GHS;
			parameters[2].Value = model.ND;
			parameters[3].Value = model.YD;
			parameters[4].Value = model.Score;
			parameters[5].Value = model.EUrl;
			parameters[6].Value = model.Str1;
			parameters[7].Value = model.Str2;
			parameters[8].Value = model.Str3;

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
		public bool Update(DBA.Model.Evaluate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Evaluate set ");
			strSql.Append("GHSID=@GHSID,");
			strSql.Append("GHS=@GHS,");
			strSql.Append("ND=@ND,");
			strSql.Append("YD=@YD,");
			strSql.Append("Score=@Score,");
			strSql.Append("EUrl=@EUrl,");
			strSql.Append("Str1=@Str1,");
			strSql.Append("Str2=@Str2,");
			strSql.Append("Str3=@Str3");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GHSID", SqlDbType.NVarChar,200),
					new SqlParameter("@GHS", SqlDbType.NVarChar,200),
					new SqlParameter("@ND", SqlDbType.NVarChar,200),
					new SqlParameter("@YD", SqlDbType.NVarChar,200),
					new SqlParameter("@Score", SqlDbType.NVarChar,200),
					new SqlParameter("@EUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Str1", SqlDbType.NVarChar,200),
					new SqlParameter("@Str2", SqlDbType.NVarChar,200),
					new SqlParameter("@Str3", SqlDbType.NVarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GHSID;
			parameters[1].Value = model.GHS;
			parameters[2].Value = model.ND;
			parameters[3].Value = model.YD;
			parameters[4].Value = model.Score;
			parameters[5].Value = model.EUrl;
			parameters[6].Value = model.Str1;
			parameters[7].Value = model.Str2;
			parameters[8].Value = model.Str3;
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
			strSql.Append("delete from Evaluate ");
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
			strSql.Append("delete from Evaluate ");
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
		public DBA.Model.Evaluate GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GHSID,GHS,ND,YD,Score,EUrl,Str1,Str2,Str3 from Evaluate ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			DBA.Model.Evaluate model=new DBA.Model.Evaluate();
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
		public DBA.Model.Evaluate DataRowToModel(DataRow row)
		{
			DBA.Model.Evaluate model=new DBA.Model.Evaluate();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GHSID"]!=null)
				{
					model.GHSID=row["GHSID"].ToString();
				}
				if(row["GHS"]!=null)
				{
					model.GHS=row["GHS"].ToString();
				}
				if(row["ND"]!=null)
				{
					model.ND=row["ND"].ToString();
				}
				if(row["YD"]!=null)
				{
					model.YD=row["YD"].ToString();
				}
				if(row["Score"]!=null)
				{
					model.Score=row["Score"].ToString();
				}
				if(row["EUrl"]!=null)
				{
					model.EUrl=row["EUrl"].ToString();
				}
				if(row["Str1"]!=null)
				{
					model.Str1=row["Str1"].ToString();
				}
				if(row["Str2"]!=null)
				{
					model.Str2=row["Str2"].ToString();
				}
				if(row["Str3"]!=null)
				{
					model.Str3=row["Str3"].ToString();
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
			strSql.Append("select ID,GHSID,GHS,ND,YD,Score,EUrl,Str1,Str2,Str3 ");
			strSql.Append(" FROM Evaluate ");
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
			strSql.Append(" ID,GHSID,GHS,ND,YD,Score,EUrl,Str1,Str2,Str3 ");
			strSql.Append(" FROM Evaluate ");
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
			strSql.Append("select count(1) FROM Evaluate ");
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
			strSql.Append(")AS Row, T.*  from Evaluate T ");
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
			parameters[0].Value = "Evaluate";
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

