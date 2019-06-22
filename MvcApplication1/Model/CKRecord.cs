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
namespace DBA.Model
{
	/// <summary>
	/// CKRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CKRecord
	{
		public CKRecord()
		{}
		#region Model
		private int _id;
		private string _createusername;
		private string _isbn;
		private DateTime? _time;
		private int _bookid;
		private string _bookname;
		private int? _num;
		private string _price;
		private string _str1;
		private string _str2;
		private string _str3;
        private string _name;
        private string _sex;
        private string _age;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        public string Age
        {
            set { _age = value; }
            get { return _age; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string CreateUserName
		{
			set{ _createusername=value;}
			get{return _createusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISBN
		{
			set{ _isbn=value;}
			get{return _isbn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BookID
		{
			set{ _bookid=value;}
			get{return _bookid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BookName
		{
			set{ _bookname=value;}
			get{return _bookname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str1
		{
			set{ _str1=value;}
			get{return _str1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str2
		{
			set{ _str2=value;}
			get{return _str2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str3
		{
			set{ _str3=value;}
			get{return _str3;}
		}
		#endregion Model

	}
}

