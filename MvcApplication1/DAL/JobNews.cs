using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Conris.Utility;
namespace DBA.DAL
{
	/// <summary>
	/// 数据访问类:JobNews
	/// </summary>
	public partial class JobNews
	{
		public JobNews()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "JobNews"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JobNews");
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
		public int Add(DBA.Model.JobNews model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JobNews(");
			strSql.Append("JobName,Company,Category,Title,Time,CreateName,NewsContent,Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9,Str10)");
			strSql.Append(" values (");
			strSql.Append("@JobName,@Company,@Category,@Title,@Time,@CreateName,@NewsContent,@Str1,@Str2,@Str3,@Str4,@Str5,@Str6,@Str7,@Str8,@Str9,@Str10)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@JobName", SqlDbType.NVarChar,200),
					new SqlParameter("@Company", SqlDbType.NVarChar,200),
					new SqlParameter("@Category", SqlDbType.NVarChar,200),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@CreateName", SqlDbType.NVarChar,200),
					new SqlParameter("@NewsContent", SqlDbType.Text),
					new SqlParameter("@Str1", SqlDbType.NVarChar,200),
					new SqlParameter("@Str2", SqlDbType.NVarChar,200),
					new SqlParameter("@Str3", SqlDbType.NVarChar,200),
					new SqlParameter("@Str4", SqlDbType.NVarChar,200),
					new SqlParameter("@Str5", SqlDbType.NVarChar,200),
					new SqlParameter("@Str6", SqlDbType.NVarChar,200),
					new SqlParameter("@Str7", SqlDbType.NVarChar,200),
					new SqlParameter("@Str8", SqlDbType.NVarChar,200),
					new SqlParameter("@Str9", SqlDbType.NVarChar,200),
					new SqlParameter("@Str10", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.JobName;
			parameters[1].Value = model.Company;
			parameters[2].Value = model.Category;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.Time;
			parameters[5].Value = model.CreateName;
			parameters[6].Value = model.NewsContent;
			parameters[7].Value = model.Str1;
			parameters[8].Value = model.Str2;
			parameters[9].Value = model.Str3;
			parameters[10].Value = model.Str4;
			parameters[11].Value = model.Str5;
			parameters[12].Value = model.Str6;
			parameters[13].Value = model.Str7;
			parameters[14].Value = model.Str8;
			parameters[15].Value = model.Str9;
			parameters[16].Value = model.Str10;

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
		public bool Update(DBA.Model.JobNews model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JobNews set ");
			strSql.Append("JobName=@JobName,");
			strSql.Append("Company=@Company,");
			strSql.Append("Category=@Category,");
			strSql.Append("Title=@Title,");
			strSql.Append("Time=@Time,");
			strSql.Append("CreateName=@CreateName,");
			strSql.Append("NewsContent=@NewsContent,");
			strSql.Append("Str1=@Str1,");
			strSql.Append("Str2=@Str2,");
			strSql.Append("Str3=@Str3,");
			strSql.Append("Str4=@Str4,");
			strSql.Append("Str5=@Str5,");
			strSql.Append("Str6=@Str6,");
			strSql.Append("Str7=@Str7,");
			strSql.Append("Str8=@Str8,");
			strSql.Append("Str9=@Str9,");
			strSql.Append("Str10=@Str10");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@JobName", SqlDbType.NVarChar,200),
					new SqlParameter("@Company", SqlDbType.NVarChar,200),
					new SqlParameter("@Category", SqlDbType.NVarChar,200),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@CreateName", SqlDbType.NVarChar,200),
					new SqlParameter("@NewsContent", SqlDbType.Text),
					new SqlParameter("@Str1", SqlDbType.NVarChar,200),
					new SqlParameter("@Str2", SqlDbType.NVarChar,200),
					new SqlParameter("@Str3", SqlDbType.NVarChar,200),
					new SqlParameter("@Str4", SqlDbType.NVarChar,200),
					new SqlParameter("@Str5", SqlDbType.NVarChar,200),
					new SqlParameter("@Str6", SqlDbType.NVarChar,200),
					new SqlParameter("@Str7", SqlDbType.NVarChar,200),
					new SqlParameter("@Str8", SqlDbType.NVarChar,200),
					new SqlParameter("@Str9", SqlDbType.NVarChar,200),
					new SqlParameter("@Str10", SqlDbType.NVarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.JobName;
			parameters[1].Value = model.Company;
			parameters[2].Value = model.Category;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.Time;
			parameters[5].Value = model.CreateName;
			parameters[6].Value = model.NewsContent;
			parameters[7].Value = model.Str1;
			parameters[8].Value = model.Str2;
			parameters[9].Value = model.Str3;
			parameters[10].Value = model.Str4;
			parameters[11].Value = model.Str5;
			parameters[12].Value = model.Str6;
			parameters[13].Value = model.Str7;
			parameters[14].Value = model.Str8;
			parameters[15].Value = model.Str9;
			parameters[16].Value = model.Str10;
			parameters[17].Value = model.ID;

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
			strSql.Append("delete from JobNews ");
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
			strSql.Append("delete from JobNews ");
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
		public DBA.Model.JobNews GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,JobName,Company,Category,Title,Time,CreateName,NewsContent,Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9,Str10 from JobNews ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			DBA.Model.JobNews model=new DBA.Model.JobNews();
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
		public DBA.Model.JobNews DataRowToModel(DataRow row)
		{
			DBA.Model.JobNews model=new DBA.Model.JobNews();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["JobName"]!=null)
				{
					model.JobName=row["JobName"].ToString();
				}
				if(row["Company"]!=null)
				{
					model.Company=row["Company"].ToString();
				}
				if(row["Category"]!=null)
				{
					model.Category=row["Category"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["CreateName"]!=null)
				{
					model.CreateName=row["CreateName"].ToString();
				}
				if(row["NewsContent"]!=null)
				{
					model.NewsContent=row["NewsContent"].ToString();
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
				if(row["Str4"]!=null)
				{
					model.Str4=row["Str4"].ToString();
				}
				if(row["Str5"]!=null)
				{
					model.Str5=row["Str5"].ToString();
				}
				if(row["Str6"]!=null)
				{
					model.Str6=row["Str6"].ToString();
				}
				if(row["Str7"]!=null)
				{
					model.Str7=row["Str7"].ToString();
				}
				if(row["Str8"]!=null)
				{
					model.Str8=row["Str8"].ToString();
				}
				if(row["Str9"]!=null)
				{
					model.Str9=row["Str9"].ToString();
				}
				if(row["Str10"]!=null)
				{
					model.Str10=row["Str10"].ToString();
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
			strSql.Append("select ID,JobName,Company,Category,Title,Time,CreateName,NewsContent,Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9,Str10 ");
			strSql.Append(" FROM JobNews ");
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
			strSql.Append(" ID,JobName,Company,Category,Title,Time,CreateName,NewsContent,Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9,Str10 ");
			strSql.Append(" FROM JobNews ");
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
			strSql.Append("select count(1) FROM JobNews ");
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
			strSql.Append(")AS Row, T.*  from JobNews T ");
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
			parameters[0].Value = "JobNews";
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

