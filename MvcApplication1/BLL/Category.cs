﻿/**  版本信息模板在安装目录下，可自行修改。
* Category.cs
*
* 功 能： N/A
* 类 名： Category
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
namespace DBA.BLL
{
	/// <summary>
	/// Category
	/// </summary>
	public partial class Category
	{
		private readonly DBA.DAL.Category dal=new DBA.DAL.Category();
		public Category()
		{}
		#region  BasicMethod

		

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
		public int  Add(DBA.Model.Category model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DBA.Model.Category model)
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
		public DBA.Model.Category GetModel(int ID)
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
		public List<DBA.Model.Category> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Category> DataTableToList(DataTable dt)
		{
			List<DBA.Model.Category> modelList = new List<DBA.Model.Category>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.Category model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
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
        public bool Edit(DBA.Model.Category model)
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
        public bool GEdit(DBA.Model.Category model)
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
        public List<DBA.Model.Category> SearchProject(Conris.DBA.ViewModel.CategorySearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" Str1='1'");
            if (!string.IsNullOrEmpty(model.Name))
            {

                sb.Append(" And CategoryName like '%" + model.Name + "%'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }

        public List<DBA.Model.Category> SearchProject2(Conris.DBA.ViewModel.CategorySearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" Str1='2'");
            if (!string.IsNullOrEmpty(model.Name))
            {

                sb.Append(" And CategoryName like '%" + model.Name + "%'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }

        public List<DBA.Model.Category> SearchProject3(Conris.DBA.ViewModel.CategorySearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" Str1='3'");
            if (!string.IsNullOrEmpty(model.Name))
            {

                sb.Append(" And CategoryName like '%" + model.Name + "%'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }
        #endregion  ExtensionMethod
	}
}

