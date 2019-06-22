using System;
namespace DBA.Model
{
    /// <summary>
    /// RRecord:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class RRecord
    {
        public RRecord()
        { }
        #region Model
        private int _id;
        private string _createusername;
        private DateTime? _time;
        private int _bookid;
        private string _isbn;
        private string _bookname;
        private int _categoryid;
        private string _str1;
        private string _str2;
        private string _ckid;
        private string _gg;
        private string _ghsid;
        private string _str4;
        private string _str5;
        private string _dw;
        private string _name;
        private string _sex;
        private string _age;
        private string _isReject;
        private string _sumnum;

        public string SumNum
        {
            get { return _sumnum; }
            set { _sumnum = value; }
        }
        private string _singleprice;

        public string SinglePrice
        {
            get { return _singleprice; }
            set { _singleprice = value; }
        }
        private string _sumprice;

        public string SumPrice
        {
            get { return _sumprice; }
            set { _sumprice = value; }
        }

        public string IsReject
        {
            get { return _isReject; }
            set { _isReject = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
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
            set { _createusername = value; }
            get { return _createusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int BookID
        {
            set { _bookid = value; }
            get { return _bookid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ISBN
        {
            set { _isbn = value; }
            get { return _isbn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BookName
        {
            set { _bookname = value; }
            get { return _bookname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CategoryID
        {
            set { _categoryid = value; }
            get { return _categoryid; }
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
        public string CKID
        {
            set { _ckid = value; }
            get { return _ckid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GG
        {
            set { _gg = value; }
            get { return _gg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GHSID
        {
            set { _ghsid = value; }
            get { return _ghsid; }
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
        /// <summary>
        /// 
        /// </summary>
        public string DW
        {
            set { _dw = value; }
            get { return _dw; }
        }
        #endregion Model

    }
}

