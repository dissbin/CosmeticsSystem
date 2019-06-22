using System;
using System.Data;
using System.Collections.Generic;

using DBA.Model;
using System.Text;
namespace DBA.BLL
{
	/// <summary>
	/// JobNews
	/// </summary>
	public partial class JobNews
	{
		private readonly DBA.DAL.JobNews dal=new DBA.DAL.JobNews();
		public JobNews()
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
		public int  Add(DBA.Model.JobNews model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DBA.Model.JobNews model)
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
		/// 得到一个对象实体
		/// </summary>
		public DBA.Model.JobNews GetModel(int ID)
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
		public List<DBA.Model.JobNews> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        public List<DBA.Model.JobNews> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataSet ds = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(ds.Tables[0]);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.JobNews> DataTableToList(DataTable dt)
		{
			List<DBA.Model.JobNews> modelList = new List<DBA.Model.JobNews>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.JobNews model;
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
        public bool Edit(DBA.Model.JobNews model)
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

        public List<DBA.Model.JobNews> SearchProject(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" Category!='日程安排'");
            if (!string.IsNullOrEmpty(model.JobName))
            {

                sb.Append(" And JobName like '%" + model.JobName + "%'");
            }
            if (!string.IsNullOrEmpty(model.Company))
            {

                sb.Append(" And Company like '%" + model.Company + "%'");
            }
            if (!string.IsNullOrEmpty(model.Category))
            {

                sb.Append(" And Category like '%" + model.Category + "%'");
            }
            if (!string.IsNullOrEmpty(model.Title))
            {
                sb.Append(" And Title like '%" + model.Title + "%'");
            }
             return GetModelList(sb.ToString());
        }

        public List<DBA.Model.JobNews> SearchProject2(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" Category='日程安排'");
            if (!string.IsNullOrEmpty(model.JobName))
            {

                sb.Append(" And JobName like '%" + model.JobName + "%'");
            }
            if (!string.IsNullOrEmpty(model.Company))
            {

                sb.Append(" And Company like '%" + model.Company + "%'");
            }
            if (!string.IsNullOrEmpty(model.Category))
            {

                sb.Append(" And Category like '%" + model.Category + "%'");
            }
            if (!string.IsNullOrEmpty(model.Title))
            {
                sb.Append(" And Title like '%" + model.Title + "%'");
            }
            return GetModelList(sb.ToString());
 
        }
        #endregion  ExtensionMethod
	}
}

