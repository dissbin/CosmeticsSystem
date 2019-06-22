using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBA.Model
{
    [Serializable]
    public partial class CKRecordCount
    {
        public CKRecordCount() { }
        private string _isbn;

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _bookname;

        public string BookName
        {
            get { return _bookname; }
            set { _bookname = value; }
        }
        private int _sumnum;

        public int SumNum
        {
            get { return _sumnum; }
            set { _sumnum = value; }
        }
        private int _sumprice;

        public int SumPrice
        {
            get { return _sumprice; }
            set { _sumprice = value; }
        }
        private int _sumprofit;

        public int SumProfit
        {
            get { return _sumprofit; }
            set { _sumprofit = value; }
        }
        private string _time;

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

    }
}