using System;
namespace DBA.Model
{
    /// <summary>
    /// Category:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Category
    {
        public Category()
        { }
        #region Model
        private int _id;
        private string _categoryname;
        private string _str1;
        private string _dz;
        private string _lxfs;
        private string _storehouse;

        public string Storehouse
        {
            get { return _storehouse; }
            set { _storehouse = value; }
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
        public string CategoryName
        {
            set { _categoryname = value; }
            get { return _categoryname; }
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
        public string DZ
        {
            set { _dz = value; }
            get { return _dz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LXFS
        {
            set { _lxfs = value; }
            get { return _lxfs; }
        }
        #endregion Model

    }
}

