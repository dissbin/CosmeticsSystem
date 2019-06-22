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
using System.Collections.Generic;

using DBA.Model;
using System.Text;
namespace DBA.BLL
{
	/// <summary>
	/// CKRecord
	/// </summary>
	public partial class CKRecord
	{
		private readonly DBA.DAL.CKRecord dal=new DBA.DAL.CKRecord();
		public CKRecord()
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
		public int  Add(DBA.Model.CKRecord model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DBA.Model.CKRecord model)
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
		public DBA.Model.CKRecord GetModel(int ID)
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
		public List<DBA.Model.CKRecord> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        public List<DBA.Model.CKRecordCount> GetCountModelList(string strWhere)
        {
            DataSet ds = dal.GetCountList(strWhere);
            return CountDataTableToList(ds.Tables[0]);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<DBA.Model.CKRecordCount> CountDataTableToList(DataTable dt)
        {
            List<DBA.Model.CKRecordCount> modelList = new List<DBA.Model.CKRecordCount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DBA.Model.CKRecordCount model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.CountDataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }
		public List<DBA.Model.CKRecord> DataTableToList(DataTable dt)
		{
			List<DBA.Model.CKRecord> modelList = new List<DBA.Model.CKRecord>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.CKRecord model;
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
        public bool Edit(DBA.Model.CKRecord model)
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
        public List<DBA.Model.CKRecord> SearchProject(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" 1=1");
            if (!string.IsNullOrEmpty(model.GoodsName))
            {

                sb.Append(" And BookName like '%" + model.GoodsName + "%'");
            }
            if (!string.IsNullOrEmpty(model.ISBN))
            {

                sb.Append(" And ISBN like '%" + model.ISBN + "%'");
            }
            if (!string.IsNullOrEmpty(model.GoodsZZ))
            {

                sb.Append(" And BookZZ like '%" + model.GoodsZZ + "%'");
            }
            if (!string.IsNullOrEmpty(model.StartTime))
            {
                sb.Append(" And Time>='" + model.StartTime + "'");
            }
            if (!string.IsNullOrEmpty(model.EndTime))
            {
                sb.Append(" And Time<='" + model.EndTime + "'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }
        public List<DBA.Model.CKRecordCount> SearchProject2(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" 1=1");
            if (!string.IsNullOrEmpty(model.Time))
            {
                sb.Append(" And Time like '%" + model.Time+ "%'");
            }
            return GetCountModelList(sb.ToString());
        }
        #endregion  ExtensionMethod
	}
}

