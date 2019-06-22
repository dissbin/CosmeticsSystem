using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class CKRecordController : Controller
    {
        //
        // GET: /CKRecord/
        DBA.BLL.CKRecord bll = new DBA.BLL.CKRecord();
        DBA.BLL.Goods bbll = new DBA.BLL.Goods();
        DBA.BLL.Users ubll = new DBA.BLL.Users();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
               DBA.Model.CKRecord  model= new DBA.Model.CKRecord();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));    
            }
           
        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.CKRecord model)
        {
            if (model.ID == 0)
            {
                DBA.Model.Users usermodel = ubll.GetModelList(" LoginName='"+model.Str1+"'").FirstOrDefault();
                if (usermodel==null)
                {
                    usermodel = new DBA.Model.Users();
                    usermodel.Age = model.Age;
                    usermodel.LoginName = model.Str1;
                    usermodel.Sex = model.Sex;
                    usermodel.UserName = model.Name;
                    ubll.Add(usermodel);
                }
                model.Time = DateTime.Now;
                DBA.Model.Goods Goods = bbll.GetModel(model.BookID);
                model.CreateUserName = DBA.BLL.Users.GetNowUserName();
                Goods.GoodsKC = Goods.GoodsKC - Convert.ToInt32(model.Num);
                model.Str3 = Goods.Price;
                model.Str2 = (Convert.ToDouble(model.Num) * (Convert.ToDouble(Goods.Price) - Convert.ToDouble(Goods.GoodsKey))).ToString();
                bbll.Update(Goods);
            }
          
            bll.Edit(model);
            return RedirectToAction("CKRecordManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult CKRecordManage(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return View(model);
        }
        public ActionResult CKRecordCountManage(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return View(model);
        }
        public PartialViewResult CKRecordCountSearch(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            List<DBA.Model.CKRecordCount> list = bll.SearchProject2(model);
            double d1 = 0;
            double d2 = 0;
            foreach(var item in list)
            {
                d1 += Convert.ToDouble(item.SumPrice);
                d2 += Convert.ToDouble(item.SumProfit);
            }
            TempData["SumPrice"] = d1;
            TempData["SumProfit"] = d2;

            return PartialView(model);
        }
        public PartialViewResult CKRecordSearch(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult CKRecordList(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }

        public PartialViewResult CKRecordCountList(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return PartialView(bll.SearchProject2(model));
        }
        public ActionResult CRecordManage(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return View(model);
        }

        public PartialViewResult CRecordSearch(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            List<DBA.Model.CKRecord> list = bll.SearchProject(model);
            double d1 = 0;
            double d2 = 0;
            foreach (var item in list)
            {
                d1 = d1 + Convert.ToDouble(item.Price);
                d2 = d2 + Convert.ToDouble(item.Str2);
            }
            TempData["Num"] = d1;
            TempData["Tol"] = d2;
            return PartialView(model);
        }

        public PartialViewResult CRecordList(Conris.DBA.ViewModel.CKRecordSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
