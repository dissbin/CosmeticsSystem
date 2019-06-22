/**  版本信息模板在安装目录下，可自行修改。
* Users.cs
*
* 功 能： N/A
* 类 名： Users
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/9 10:11:16   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;

using DBA.Model;
using System.Text;
using Conris.Utility;
namespace DBA.BLL
{
	/// <summary>
	/// Users
	/// </summary>
	public partial class Users
	{
		private readonly DBA.DAL.Users dal=new DBA.DAL.Users();
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(DBA.Model.Users model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(DBA.Model.Users model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DBA.Model.Users GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

	

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Users> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);//能放查询结果的类
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Users> DataTableToList(DataTable dt)
		{
            List<DBA.Model.Users> modelList = new List<DBA.Model.Users>();//新建一个存放好多用户对象的链表
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.Users model;//数据库模型对象
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);//将DataSet中的数据放到model（数据库模型对象）中
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
        #region  ExtensionMethod
        public bool Edit(DBA.Model.Users model)
        {
            if (model.ID == 0)
            {
                Add(model);
                return true;
            }
            else
            {
                return Update(model);
            }
        }
        public List<DBA.Model.Users> SearchProject(Conris.DBA.ViewModel.UsersSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" 1=1");
            if (!string.IsNullOrEmpty(model.Name))
            {

                sb.Append(" And UserName like '%" + model.Name + "%'");
            }
            if (!string.IsNullOrEmpty(model.UserType))
            {

                sb.Append(" And UserType like '%" + model.UserType + "%'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }

        /// 是否存在该记录
        /// </summary>
        public string Login(string LoginName, string LoginPsd, bool IsStay)
        {
            string str = string.Format(" LoginName='{0}' and LoginPSD='{1}'  ", LoginName, LoginPsd);
            List<DBA.Model.Users> list = GetModelList(str);//从数据库模型获取用户的信息，返回值：好多用户的一张链表
            if (list.Count != 0)
            {
                AuthenHelper.Logout();
                AuthenHelper.CreateTicket(list[0].UserName, list[0].ID.ToString(), IsStay, DateTime.Now.AddHours(2), "");
                return "1";
            }
            else
                return "0";
        }

        //登出
        public bool LogOut()
        {
            try
            {
                AuthenHelper.Logout();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetNowUserName()
        {
            return AuthenHelper.GetLoginUserName();
        }
        public static string GetNowUserID()
        {
            return AuthenHelper.GetLoginUserData();
        }
        public static string GetNowUserType()
        {
            string ID = AuthenHelper.GetLoginUserData();
            DBA.DAL.Users dale = new DAL.Users();
            return dale.GetModel(Convert.ToInt32(ID)).Usertype.Trim();


        }
        #endregion  ExtensionMethod
	}
}

