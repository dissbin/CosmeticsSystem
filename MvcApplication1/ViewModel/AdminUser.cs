using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conris.DBA.ViewModel
{
    class AdminUser
    {
    }


    public class TopicSearch
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Pageindex { get; set; }
    }
    //1
    public class CategorySearch
    {
        public string Name { get; set; }

        public int Pageindex { get; set; }
    }
    //public class CountSearch
    //{
    //    public string ID { get; set; }
    //    public string 
    //    public int Pageindex { get; set; }
    //}

    public class JobNewsSearch
    {
        public string JobName { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Pageindex { get; set; }
    }
    public class WarningSearch
    {
        public string WarnType { get; set; }

        public int Pageindex { get; set; }
    }

    public class EvaluateSearch
    {
        public string ND { get; set; }
        public string YD { get; set; }
        public string GHSID { get; set; }
        public string GHS { get; set; }
        public int Pageindex { get; set; }
    }

    //2
    public class UsersSearch
    {
        public string Name { get; set; }
        public string UserType { get; set; }
      
        public int Pageindex { get; set; }
    }
    //3
    public class MajorSearch
    {
        public string Name { get; set; }

        public int Pageindex { get; set; }
    }
    //4
    public class RegSearch
    {
        public string Name { get; set; }

        public int Pageindex { get; set; }
    }
    //5
    public class TitleSearch
    {
        public string Name { get; set; }

        public int Pageindex { get; set; }
    }
    //6
    public class GoodsSearch
    {
        public string GoodsName { get; set; }
        public string GoodsCBS { get; set; }
        public string ISBN { get; set; }
        public string GoodsZZ { get; set; }
        public string CategoryID { get; set; }
        public string Flag { get; set; }
        public int Pageindex { get; set; }
    }
    public class RRecordSearch
    {
        public string GoodsName { get; set; }
        public string ISBN { get; set; }
        public string GoodsZZ { get; set; }
        public string Str5 { get; set; }
        public int Pageindex { get; set; }
        public string Time { get; set; }
    }

    public class CKRecordSearch
    {
        public string GoodsName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ISBN { get; set; }
        public string GoodsZZ { get; set; }
        public int Pageindex { get; set; }
        public string Time { get; set; }
        public string BookName { get; set; }
    }
}
