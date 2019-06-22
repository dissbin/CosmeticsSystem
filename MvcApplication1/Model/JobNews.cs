using System;
namespace DBA.Model
{
	/// <summary>
	/// JobNews:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JobNews
	{
		public JobNews()
		{}
		#region Model
		private int _id;
		private string _jobname;
		private string _company;
		private string _category;
		private string _title;
		private DateTime? _time;
		private string _createname;
		private string _newscontent;
		private string _str1;
		private string _str2;
		private string _str3;
		private string _str4;
		private string _str5;
		private string _str6;
		private string _str7;
		private string _str8;
		private string _str9;
		private string _str10;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobName
		{
			set{ _jobname=value;}
			get{return _jobname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Category
		{
			set{ _category=value;}
			get{return _category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
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
		public string CreateName
		{
			set{ _createname=value;}
			get{return _createname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewsContent
		{
			set{ _newscontent=value;}
			get{return _newscontent;}
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
		/// <summary>
		/// 
		/// </summary>
		public string Str4
		{
			set{ _str4=value;}
			get{return _str4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str5
		{
			set{ _str5=value;}
			get{return _str5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str6
		{
			set{ _str6=value;}
			get{return _str6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str7
		{
			set{ _str7=value;}
			get{return _str7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str8
		{
			set{ _str8=value;}
			get{return _str8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str9
		{
			set{ _str9=value;}
			get{return _str9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Str10
		{
			set{ _str10=value;}
			get{return _str10;}
		}
		#endregion Model

	}
}

