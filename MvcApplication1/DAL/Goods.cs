using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Conris.Utility;
using System.IO;

namespace DBA.DAL
{
    /// <summary>
    /// 数据访问类:Goods
    /// </summary>
    public partial class Goods
    {
        public Goods()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Goods");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DBA.Model.Goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Goods(");
            strSql.Append("GoodsName,GoodsCBS,ISBN,GoodsZZ,GoodsKC,Price,CategoryID,Str1,Str2,GoodsKey,GoodsJJ,Max,Min,WarnName)");
            strSql.Append(" values (");
            strSql.Append("@GoodsName,@GoodsCBS,@ISBN,@GoodsZZ,@GoodsKC,@Price,@CategoryID,@Str1,@Str2,@GoodsKey,@GoodsJJ,@Max,@Min,@WarnName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsName", SqlDbType.NChar,20),
					new SqlParameter("@GoodsCBS", SqlDbType.NChar,50),
					new SqlParameter("@ISBN", SqlDbType.NChar,10),
					new SqlParameter("@GoodsZZ", SqlDbType.NChar,10),
					new SqlParameter("@GoodsKC", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.NChar,10),
					new SqlParameter("@CategoryID", SqlDbType.Int,4),
					new SqlParameter("@Str1", SqlDbType.NChar,10),
					new SqlParameter("@Str2", SqlDbType.NChar,10),
					new SqlParameter("@GoodsKey", SqlDbType.NChar,10),
					new SqlParameter("@GoodsJJ", SqlDbType.NChar,500),
					new SqlParameter("@Max", SqlDbType.NVarChar,50),
					new SqlParameter("@Min", SqlDbType.NVarChar,50),
					new SqlParameter("@WarnName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.GoodsName;
            parameters[1].Value = model.GoodsCBS;
            parameters[2].Value = model.ISBN;
            parameters[3].Value = model.GoodsZZ;
            parameters[4].Value = model.GoodsKC;
            parameters[5].Value = model.Price;
            parameters[6].Value = model.CategoryID;
            parameters[7].Value = model.Str1;
            parameters[8].Value = model.Str2;
            parameters[9].Value = model.GoodsKey;
            parameters[10].Value = model.GoodsJJ;
            parameters[11].Value = model.Max;
            parameters[12].Value = model.Min;
            parameters[13].Value = model.WarnName;

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
        public bool Update(DBA.Model.Goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Goods set ");
            strSql.Append("GoodsName=@GoodsName,");
            strSql.Append("GoodsCBS=@GoodsCBS,");
            strSql.Append("ISBN=@ISBN,");
            strSql.Append("GoodsZZ=@GoodsZZ,");
            strSql.Append("GoodsKC=@GoodsKC,");
            strSql.Append("Price=@Price,");
            strSql.Append("CategoryID=@CategoryID,");
            strSql.Append("Str1=@Str1,");
            strSql.Append("Str2=@Str2,");
            strSql.Append("GoodsKey=@GoodsKey,");
            strSql.Append("GoodsJJ=@GoodsJJ,");
            strSql.Append("Max=@Max,");
            strSql.Append("Min=@Min,");
            strSql.Append("WarnName=@WarnName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsName", SqlDbType.NChar,20),
					new SqlParameter("@GoodsCBS", SqlDbType.NChar,50),
					new SqlParameter("@ISBN", SqlDbType.NChar,10),
					new SqlParameter("@GoodsZZ", SqlDbType.NChar,10),
					new SqlParameter("@GoodsKC", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.NChar,10),
					new SqlParameter("@CategoryID", SqlDbType.Int,4),
					new SqlParameter("@Str1", SqlDbType.NChar,10),
					new SqlParameter("@Str2", SqlDbType.NChar,10),
					new SqlParameter("@GoodsKey", SqlDbType.NChar,10),
					new SqlParameter("@GoodsJJ", SqlDbType.NChar,500),
					new SqlParameter("@Max", SqlDbType.NVarChar,50),
					new SqlParameter("@Min", SqlDbType.NVarChar,50),
					new SqlParameter("@WarnName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.GoodsName;
            parameters[1].Value = model.GoodsCBS;
            parameters[2].Value = model.ISBN;
            parameters[3].Value = model.GoodsZZ;
            parameters[4].Value = model.GoodsKC;
            parameters[5].Value = model.Price;
            parameters[6].Value = model.CategoryID;
            parameters[7].Value = model.Str1;
            parameters[8].Value = model.Str2;
            parameters[9].Value = model.GoodsKey;
            parameters[10].Value = model.GoodsJJ;
            parameters[11].Value = model.Max;
            parameters[12].Value = model.Min;
            parameters[13].Value = model.WarnName;
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

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Goods ");
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
            strSql.Append("delete from Goods ");
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
        
        public DBA.Model.Goods GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,GoodsName,GoodsCBS,ISBN,GoodsZZ,GoodsKC,Price,CategoryID,Str1,Str2,GoodsKey,GoodsJJ,Max,Min,WarnName,StoreHouse from Goods ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            DBA.Model.Goods model = new DBA.Model.Goods();
            
            
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            
            //DataRow t = new DataRow();
            //    t = ds.Tables[0].Rows[0];
            //Console.WriteLine(ds.Tables[0].Rows[0].ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                 
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public DBA.Model.Goods GetIsbn(String ISBN)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,GoodsName,GoodsCBS,ISBN,GoodsZZ,GoodsKC,Price,CategoryID,Str1,Str2,GoodsKey,GoodsJJ,Max,Min,WarnName,StoreHouse from Goods ");
            strSql.Append(" where ISBN=@ISBN");
            SqlParameter[] parameters = {
					new SqlParameter("@ISBN", SqlDbType.VarChar,4)
			};
            parameters[0].Value = ISBN;

            DBA.Model.Goods model = new DBA.Model.Goods();


            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            //DataRow t = new DataRow();
            //    t = ds.Tables[0].Rows[0];
            //Console.WriteLine(ds.Tables[0].Rows[0].ToString());
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
        public DBA.Model.Goods DataRowToModel(DataRow row)
        {
            DBA.Model.Goods model = new DBA.Model.Goods();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["GoodsName"] != null)
                {
                    model.GoodsName = row["GoodsName"].ToString();
                }
                if (row["GoodsCBS"] != null)
                {
                    model.GoodsCBS = row["GoodsCBS"].ToString();
                }
                if (row["ISBN"] != null)
                {
                    model.ISBN = row["ISBN"].ToString();
                }
                if (row["GoodsZZ"] != null)
                {
                    model.GoodsZZ = row["GoodsZZ"].ToString();
                }
                if (row["GoodsKC"] != null && row["GoodsKC"].ToString() != "")
                {
                    model.GoodsKC = int.Parse(row["GoodsKC"].ToString());
                }
                if (row["Price"] != null)
                {
                    model.Price = row["Price"].ToString();
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
                if (row["GoodsKey"] != null)
                {
                    model.GoodsKey = row["GoodsKey"].ToString();
                }
                if (row["GoodsJJ"] != null)
                {
                    model.GoodsJJ = row["GoodsJJ"].ToString();
                }
                if (row["Max"] != null)
                {
                    model.Max = row["Max"].ToString();
                }
                if (row["Min"] != null)
                {
                    model.Min = row["Min"].ToString();
                }
                if (row["WarnName"] != null)
                {
                    model.WarnName = row["WarnName"].ToString();
                }
                if (row["StoreHouse"] != null)
                {
                    model.Storehouse = row["StoreHouse"].ToString();
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
            strSql.Append("select ID,GoodsName,GoodsCBS,ISBN,GoodsZZ,GoodsKC,Price,CategoryID,Str1,Str2,GoodsKey,GoodsJJ,Max,Min,WarnName,StoreHouse ");
            strSql.Append(" FROM Goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
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
            strSql.Append(" ID,GoodsName,GoodsCBS,ISBN,GoodsZZ,GoodsKC,Price,CategoryID,Str1,Str2,GoodsKey,GoodsJJ,Max,Min,WarnName ");
            strSql.Append(" FROM Goods ");
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
            strSql.Append("select count(1) FROM Goods ");
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
            strSql.Append(")AS Row, T.*  from Goods T ");
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
            parameters[0].Value = "Goods";
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

