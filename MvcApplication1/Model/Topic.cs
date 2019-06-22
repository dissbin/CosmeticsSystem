using System;
namespace DBA.Model
{
    /// <summary>
    /// Topic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Topic
    {
        public Topic()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _time;
        private string _userid;
        private string _username;
        private string _topiccontent;
        private string _category;
        private string _categoryid;
        private string _lasttime;
        private string _htnum;
        private string _str1;
        private string _str2;
        private string _str3;
        private string _str4;
        private string _str5;
        private string _rejectnum;

        public string RejectNum
        {
            get { return _rejectnum; }
            set { _rejectnum = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TopicContent
        {
            set { _topiccontent = value; }
            get { return _topiccontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CategoryID
        {
            set { _categoryid = value; }
            get { return _categoryid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LastTime
        {
            set { _lasttime = value; }
            get { return _lasttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HTNum
        {
            set { _htnum = value; }
            get { return _htnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str1
        {
            set { _str1 = value; }
            get { return _str1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str2
        {
            set { _str2 = value; }
            get { return _str2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str3
        {
            set { _str3 = value; }
            get { return _str3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str4
        {
            set { _str4 = value; }
            get { return _str4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Str5
        {
            set { _str5 = value; }
            get { return _str5; }
        }
        #endregion Model

    }
}

