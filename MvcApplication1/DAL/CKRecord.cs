/**  版本信息模板在安装目录下，可自行修改。
* CKRecord.cs
*
* 功 能： N/A
* 类 名： CKRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/9 10:11:15   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Conris.Utility;
namespace DBA.DAL
{
	/// <summary>
	/// 数据访问类:CKRecord
	/// </summary>
	public partial class CKRecord
	{
		public CKRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CKRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CKRecord");
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
		public int Add(DBA.Model.CKRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CKRecord(");
			strSql.Append("CreateUserName,ISBN,Time,BookID,BookName,Num,Price,Str1,Str2,Str3)");
			strSql.Append(" values (");
			strSql.Append("@CreateUserName,@ISBN,@Time,@BookID,@BookName,@Num,@Price,@Str1,@Str2,@Str3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CreateUserName", SqlDbType.NChar,10),
					new SqlParameter("@ISBN", SqlDbType.NChar,30),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@BookName", SqlDbType.NChar,50),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.NChar,50),
					new SqlParameter("@Str1", SqlDbType.NChar,10),
					new SqlParameter("@Str2", SqlDbType.NChar,10),
					new SqlParameter("@Str3", SqlDbType.NChar,10)};
			parameters[0].Value = model.CreateUserName;
			parameters[1].Value = model.ISBN;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.BookID;
			parameters[4].Value = model.BookName;
			parameters[5].Value = model.Num;
			parameters[6].Value = model.Price;
			parameters[7].Value = model.Str1;
			parameters[8].Value = model.Str2;
			parameters[9].Value = model.Str3;

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
		public bool Update(DBA.Model.CKRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CKRecord set ");
			strSql.Append("CreateUserName=@CreateUserName,");
			strSql.Append("ISBN=@ISBN,");
			strSql.Append("Time=@Time,");
			strSql.Append("BookID=@BookID,");
			strSql.Append("BookName=@BookName,");
			strSql.Append("Num=@Num,");
			strSql.Append("Price=@Price,");
			strSql.Append("Str1=@Str1,");
			strSql.Append("Str2=@Str2,");
			strSql.Append("Str3=@Str3");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CreateUserName", SqlDbType.NChar,10),
					new SqlParameter("@ISBN", SqlDbType.NChar,30),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@BookName", SqlDbType.NChar,50),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.NChar,50),
					new SqlParameter("@Str1", SqlDbType.NChar,10),
					new SqlParameter("@Str2", SqlDbType.NChar,10),
					new SqlParameter("@Str3", SqlDbType.NChar,10),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CreateUserName;
			parameters[1].Value = model.ISBN;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.BookID;
			parameters[4].Value = model.BookName;
			parameters[5].Value = model.Num;
			parameters[6].Value = model.Price;
			parameters[7].Value = model.Str1;
			parameters[8].Value = model.Str2;
			parameters[9].Value = model.Str3;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from CKRecord ");
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
			strSql.Append("delete from CKRecord ");
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
		public DBA.Model.CKRecord GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CreateUserName,ISBN,Time,BookID,BookName,Num,Price,Str1,Str2,Str3 from CKRecord ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			DBA.Model.CKRecord model=new DBA.Model.CKRecord();
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
		public DBA.Model.CKRecord DataRowToModel(DataRow row)
		{
			DBA.Model.CKRecord model=new DBA.Model.CKRecord();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["CreateUserName"]!=null)
				{
					model.CreateUserName=row["CreateUserName"].ToString();
				}
				if(row["ISBN"]!=null)
				{
					model.ISBN=row["ISBN"].ToString();
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["BookID"]!=null && row["BookID"].ToString()!="")
				{
					model.BookID=int.Parse(row["BookID"].ToString());
				}
				if(row["BookName"]!=null)
				{
					model.BookName=row["BookName"].ToString();
				}
				if(row["Num"]!=null && row["Num"].ToString()!="")
				{
					model.Num=int.Parse(row["Num"].ToString());
				}
				if(row["Price"]!=null)
				{
					model.Price=row["Price"].ToString();
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
        public DBA.Model.CKRecordCount CountDataRowToModel(DataRow row)
        {
            DBA.Model.CKRecordCount model = new DBA.Model.CKRecordCount();
            if (row != null)
            {
                if (row["ISBN"] != null)
                {
                    model.ISBN = row["ISBN"].ToString();
                }
                if (row["BookName"] != null)
                {
                    model.BookName = row["BookName"].ToString();
                }
                if (row["SumNum"] != null && row["SumNum"].ToString() != "")
                {
                    model.SumNum = int.Parse(row["SumNum"].ToString());
                }
                if (row["SumPrice"] != null)
                {
                    model.SumPrice = int.Parse(row["SumPrice"].ToString());
                }
                if (row["SumProfit"] != null)
                {
                    model.SumProfit = int.Parse(row["SumProfit"].ToString());
                }
                if (row["Time"] != null)
                {
                    model.Time = row["Time"].ToString();
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
			strSql.Append("select ID,CreateUserName,ISBN,Time,BookID,BookName,Num,Price,Str1,Str2,Str3 ");
			strSql.Append(" FROM CKRecord ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetCountList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Convert(varchar(10),MAX(Time),105) Time,MAX(ISBN) as ISBN,BookName,count(*) SumNum,sum(price) SumPrice,SUM(Str2) SumProfit ");
            strSql.Append("FROM CKRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by BookName ");
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
			strSql.Append(" ID,CreateUserName,ISBN,Time,BookID,BookName,Num,Price,Str1,Str2,Str3 ");
			strSql.Append(" FROM CKRecord ");
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
			strSql.Append("select count(1) FROM CKRecord ");
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
			strSql.Append(")AS Row, T.*  from CKRecord T ");
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
			parameters[0].Value = "CKRecord";
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

