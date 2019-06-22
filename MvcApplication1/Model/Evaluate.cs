using System;
namespace DBA.Model
{
	/// <summary>
	/// Evaluate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Evaluate
	{
		public Evaluate()
		{}
		#region Model
		private int _id;
		private string _ghsid;
		private string _ghs;
		private string _nd;
		private string _yd;
		private string _score;
		private string _eurl;
		private string _str1;
		private string _str2;
		private string _str3;
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
		public string GHSID
		{
			set{ _ghsid=value;}
			get{return _ghsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GHS
		{
			set{ _ghs=value;}
			get{return _ghs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ND
		{
			set{ _nd=value;}
			get{return _nd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YD
		{
			set{ _yd=value;}
			get{return _yd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EUrl
		{
			set{ _eurl=value;}
			get{return _eurl;}
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

