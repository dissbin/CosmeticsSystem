/**  版本信息模板在安装目录下，可自行修改。
* Goods.cs
*
* 功 能： N/A
* 类 名： Goods
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
	/// Goods
	/// </summary>
	public partial class Goods
	{
		private readonly DBA.DAL.Goods dal=new DBA.DAL.Goods();
        DBA.BLL.Warning wbll = new Warning();
		public Goods()
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
		public int  Add(DBA.Model.Goods model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DBA.Model.Goods model)
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
		public DBA.Model.Goods GetModel(int ID)
		{
			return dal.GetModel(ID);
		}
        public DBA.Model.Goods GetIsbn(String ISBN)
        {
            return dal.GetIsbn(ISBN);
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
		public List<DBA.Model.Goods> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DBA.Model.Goods> DataTableToList(DataTable dt)
		{
			List<DBA.Model.Goods> modelList = new List<DBA.Model.Goods>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DBA.Model.Goods model;
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
        public bool Edit(DBA.Model.Goods model)
        {
            DBA.Model.Warning warn = wbll.GetModel(Convert.ToInt32(model.Str1));
            model.Min = warn.Min;
            model.Max = warn.Max;
            model.WarnName = warn.WarnType;
            if (model.ID == 0)
            {
                model.GoodsKC =0;
                Add(model);
                return true;
            }
            else
            {
                return Update(model);
            }
        }
        public List<DBA.Model.Goods> SearchProject(Conris.DBA.ViewModel.GoodsSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" 1=1");
            if (!string.IsNullOrEmpty(model.Flag))
            {

                sb.Append(" And  (GoodsKC is null or  GoodsKC<=10)");
            }
            if (!string.IsNullOrEmpty(model.GoodsName))
            {

                sb.Append(" And GoodsName like '%" + model.GoodsName + "%'");
            }
            if (!string.IsNullOrEmpty(model.GoodsCBS))
            {

                sb.Append(" And GoodsCBS like '%" + model.GoodsCBS + "%'");
            }
            if (!string.IsNullOrEmpty(model.ISBN))
            {

                sb.Append(" And ISBN like '%" + model.ISBN + "%'");
            }
            if (!string.IsNullOrEmpty(model.GoodsZZ))
            {

                sb.Append(" And GoodsZZ like '%" + model.GoodsZZ + "%'");
            }
            if (!string.IsNullOrEmpty(model.CategoryID))
            {

                sb.Append(" And CategoryID = '" + model.CategoryID + "'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }

        public List<DBA.Model.Goods> SearchProject2(Conris.DBA.ViewModel.GoodsSearch model)
        {
            if (model == null)
                return null;
            StringBuilder sb = new StringBuilder(" (GoodsKC>Max or GoodsKC<Min)");
            if (!string.IsNullOrEmpty(model.GoodsName))
            {

                sb.Append(" And GoodsName like '%" + model.GoodsName + "%'");
            }
            if (!string.IsNullOrEmpty(model.GoodsCBS))
            {

                sb.Append(" And GoodsCBS like '%" + model.GoodsCBS + "%'");
            }
            if (!string.IsNullOrEmpty(model.ISBN))
            {

                sb.Append(" And ISBN like '%" + model.ISBN + "%'");
            }
            if (!string.IsNullOrEmpty(model.GoodsZZ))
            {

                sb.Append(" And GoodsZZ like '%" + model.GoodsZZ + "%'");
            }
            if (!string.IsNullOrEmpty(model.CategoryID))
            {

                sb.Append(" And CategoryID = '" + model.CategoryID + "'");
            }
            sb.Append(" Order by ID Desc");
            return GetModelList(sb.ToString());
        }
        #endregion  ExtensionMethod
	}
}

