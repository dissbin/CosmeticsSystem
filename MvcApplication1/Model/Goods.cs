using System;
namespace DBA.Model
{
    /// <summary>
    /// Goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Goods
    {
        public Goods()
        { }
        #region Model
        private int _id;
        private string _goodsname;
        private string _goodscbs;
        private string _isbn;
        private string _goodszz;
        private int? _goodskc;
        private string _price;
        private int _categoryid;
        private string _str1;
        private string _str2;
        private string _goodskey;
        private string _goodsjj;
        private string _max;
        private string _min;
        private string _warnname;
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
        public string GoodsName
        {
            set { _goodsname = value; }
            get { return _goodsname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GoodsCBS
        {
            set { _goodscbs = value; }
            get { return _goodscbs; }
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
        public string GoodsZZ
        {
            set { _goodszz = value; }
            get { return _goodszz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? GoodsKC
        {
            set { _goodskc = value; }
            get { return _goodskc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Price
        {
            set { _price = value; }
            get { return _price; }
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
        public string GoodsKey
        {
            set { _goodskey = value; }
            get { return _goodskey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GoodsJJ
        {
            set { _goodsjj = value; }
            get { return _goodsjj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Max
        {
            set { _max = value; }
            get { return _max; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Min
        {
            set { _min = value; }
            get { return _min; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WarnName
        {
            set { _warnname = value; }
            get { return _warnname; }
        }
        #endregion Model

    }
}

