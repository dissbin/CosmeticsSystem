using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Conris.Utility;
namespace DBA.DAL
{
    /// <summary>
    /// 数据访问类:RRecord
    /// </summary>
    public partial class RRecord
    {
        public RRecord()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RRecord");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool Reject(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RRecord set isReject='已退货' ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 增加一条数据
        /// </summary>
        public int Add(DBA.Model.RRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RRecord(");
            strSql.Append("CreateUserName,Time,BookID,ISBN,BookName,CategoryID,Str1,Str2,CKID,GG,GHSID,Str4,Str5,DW)");
            strSql.Append(" values (");
            strSql.Append("@CreateUserName,@Time,@BookID,@ISBN,@BookName,@CategoryID,@Str1,@Str2,@CKID,@GG,@GHSID,@Str4,@Str5,@DW)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CreateUserName", SqlDbType.NChar,10),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@ISBN", SqlDbType.NChar,30),
					new SqlParameter("@BookName", SqlDbType.NChar,10),
					new SqlParameter("@CategoryID", SqlDbType.Int,4),
					new SqlParameter("@Str1", SqlDbType.NChar,10),
					new SqlParameter("@Str2", SqlDbType.NChar,10),
					new SqlParameter("@CKID", SqlDbType.NVarChar,200),
					new SqlParameter("@GG", SqlDbType.NVarChar,200),
					new SqlParameter("@GHSID", SqlDbType.NVarChar,200),
					new SqlParameter("@Str4", SqlDbType.NVarChar,200),
					new SqlParameter("@Str5", SqlDbType.NVarChar,200),
					new SqlParameter("@DW", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.CreateUserName;
            parameters[1].Value = model.Time;
            parameters[2].Value = model.BookID;
            parameters[3].Value = model.ISBN;
            parameters[4].Value = model.BookName;
            parameters[5].Value = model.CategoryID;
            parameters[6].Value = model.Str1;
            parameters[7].Value = model.Str2;
            parameters[8].Value = model.CKID;
            parameters[9].Value = model.GG;
            parameters[10].Value = model.GHSID;
            parameters[11].Value = model.Str4;
            parameters[12].Value = model.Str5;
            parameters[13].Value = model.DW;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(DBA.Model.RRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RRecord set ");
            strSql.Append("CreateUserName=@CreateUserName,");
            strSql.Append("Time=@Time,");
            strSql.Append("BookID=@BookID,");
            strSql.Append("ISBN=@ISBN,");
            strSql.Append("BookName=@BookName,");
            strSql.Append("CategoryID=@CategoryID,");
            strSql.Append("Str1=@Str1,");
            strSql.Append("Str2=@Str2,");
            strSql.Append("CKID=@CKID,");
            strSql.Append("GG=@GG,");
            strSql.Append("GHSID=@GHSID,");
            strSql.Append("Str4=@Str4,");
            strSql.Append("Str5=@Str5,");
            strSql.Append("DW=@DW");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@CreateUserName", SqlDbType.NChar,10),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@ISBN", SqlDbType.NChar,30),
					new SqlParameter("@BookName", SqlDbType.NChar,10),
					new SqlParameter("@CategoryID", SqlDbType.Int,4),
					new SqlParameter("@Str1", SqlDbType.NChar,10),
					new SqlParameter("@Str2", SqlDbType.NChar,10),
					new SqlParameter("@CKID", SqlDbType.NVarChar,200),
					new SqlParameter("@GG", SqlDbType.NVarChar,200),
					new SqlParameter("@GHSID", SqlDbType.NVarChar,200),
					new SqlParameter("@Str4", SqlDbType.NVarChar,200),
					new SqlParameter("@Str5", SqlDbType.NVarChar,200),
					new SqlParameter("@DW", SqlDbType.NVarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.CreateUserName;
            parameters[1].Value = model.Time;
            parameters[2].Value = model.BookID;
            parameters[3].Value = model.ISBN;
            parameters[4].Value = model.BookName;
            parameters[5].Value = model.CategoryID;
            parameters[6].Value = model.Str1;
            parameters[7].Value = model.Str2;
            parameters[8].Value = model.CKID;
            parameters[9].Value = model.GG;
            parameters[10].Value = model.GHSID;
            parameters[11].Value = model.Str4;
            parameters[12].Value = model.Str5;
            parameters[13].Value = model.DW;
            parameters[14].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UsersUpdate(DBA.Model.Users PoorModel, DBA.Model.Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update RRecord set ");
            strSql.Append(" CreateUserName='"+model.UserName+"' ");
            strSql.Append(" where CreateUserName='"+PoorModel.UserName+"'");
            SqlParameter[] parameters = {
					new SqlParameter("@CreateUserName", SqlDbType.NChar,10)};

            parameters[0].Value = model.UserName;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RRecord ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RRecord ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public DBA.Model.RRecord GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CreateUserName,Time,BookID,ISBN,BookName,CategoryID,Str1,Str2,CKID,GG,GHSID,Str4,Str5,DW,isReject from RRecord ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            DBA.Model.RRecord model = new DBA.Model.RRecord();
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
        public DBA.Model.RRecord DataRowToModel(DataRow row)
        {
            DBA.Model.RRecord model = new DBA.Model.RRecord();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["CreateUserName"] != null)
                {
                    model.CreateUserName = row["CreateUserName"].ToString();
                }
                if (row["Time"] != null && row["Time"].ToString() != "")
                {
                    model.Time = DateTime.Parse(row["Time"].ToString());
                }
                if (row["BookID"] != null && row["BookID"].ToString() != "")
                {
                    model.BookID = int.Parse(row["BookID"].ToString());
                }
                if (row["ISBN"] != null)
                {
                    model.ISBN = row["ISBN"].ToString();
                }
                if (row["BookName"] != null)
                {
                    model.BookName = row["BookName"].ToString();
                }
                if (row["CategoryID"] != null && row["CategoryID"].ToString() != "")
                {
                    model.CategoryID = int.Parse(row["CategoryID"].ToString());
                }
                if (row["Str1"] != null)
                {
                    model.Str1 = row["Str1"].ToString();
                }
                if (row["Str2"] != null)
                {
                    model.Str2 = row["Str2"].ToString();
                }
                if (row["CKID"] != null)
                {
                    model.CKID = row["CKID"].ToString();
                }
                if (row["GG"] != null)
                {
                    model.GG = row["GG"].ToString();
                }
                if (row["GHSID"] != null)
                {
                    model.GHSID = row["GHSID"].ToString();
                }
                if (row["Str4"] != null)
                {
                    model.Str4 = row["Str4"].ToString();
                }
                if (row["Str5"] != null)
                {
                    model.Str5 = row["Str5"].ToString();
                }
                if (row["DW"] != null)
                {
                    model.DW = row["DW"].ToString();
                }
                if (row["IsReject"] != null)
                {
                    model.IsReject = row["IsReject"].ToString();
                }
            }
            return model;
        }
        public DBA.Model.RRecord CountDataRowToModel(DataRow row)
        {
            DBA.Model.RRecord model = new DBA.Model.RRecord();
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
                if (row["SumNum"] != null)
                {
                    model.SumNum = row["SumNum"].ToString();
                }
                if (row["SinglePrice"] != null)
                {
                    model.SinglePrice = row["SinglePrice"].ToString();
                }
                if(row["SumPrice"] != null)
                {
                    model.SumPrice = row["SumPrice"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,CreateUserName,Time,BookID,ISBN,BookName,CategoryID,Str1,Str2,CKID,GG,GHSID,Str4,Str5,DW,IsReject ");
            strSql.Append(" FROM RRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());        
        }
        public DataSet GetCountList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select MAX(ISBN) as ISBN,BookName,SUM(Str1) SumNum,MAX(Str2) SinglePrice,sum(Str4) SumPrice ");
            strSql.Append("  FROM RRecord  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by BookName  ");

            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,CreateUserName,Time,BookID,ISBN,BookName,CategoryID,Str1,Str2,CKID,GG,GHSID,Str4,Str5,DW,IsReject ");
            strSql.Append(" FROM RRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM RRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from RRecord T ");
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
            parameters[0].Value = "RRecord";
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

