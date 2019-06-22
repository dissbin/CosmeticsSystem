using System;
namespace DBA.Model
{
	/// <summary>
	/// Warning:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Warning
	{
		public Warning()
		{}
		#region Model
		private int _id;
		private string _warntype;
		private string _min;
		private string _max;
		private string _str1;
		private string _str2;
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
		public string WarnType
		{
			set{ _warntype=value;}
			get{return _warntype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Min
		{
			set{ _min=value;}
			get{return _min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Max
		{
			set{ _max=value;}
			get{return _max;}
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
		#endregion Model

	}
}

