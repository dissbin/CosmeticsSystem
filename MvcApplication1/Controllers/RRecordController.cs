using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class RRecordController : Controller
    {
        //
        // GET: /RRecord/
        DBA.BLL.RRecord bll = new DBA.BLL.RRecord();
        DBA.BLL.Goods bbll = new DBA.BLL.Goods();
        DBA.BLL.Category cbll = new DBA.BLL.Category();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Reject(string ID)
        {
            return Json(bll.Reject(Convert.ToInt32(ID)));
        }
        public ActionResult Create(string ID)
        {
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list = cbll.GetModelList(" Str1='2'");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].CategoryName,
                    Value = list[i].ID.ToString()
                });
            };
            ViewData["CKID"] = new SelectList(select1, "Value", "Text", "");
            List<SelectListItem> select2 = new List<SelectListItem>();
            select2.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list2 = cbll.GetModelList(" Str1='3'");
            for (int i = 0; i < list2.Count; i++)
            {
                select2.Add(new SelectListItem
                {
                    Text = list2[i].CategoryName,
                    Value = list2[i].ID.ToString()
                });
            };
            ViewData["GHSID"] = new SelectList(select2, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
               DBA.Model.RRecord  model= new DBA.Model.RRecord();
               model.CreateUserName = DBA.BLL.Users.GetNowUserName();
             
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));    
            }
           
        }

        public ActionResult SCreate(string ID)
        {
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list = cbll.GetModelList(" Str1='2'");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].CategoryName,
                    Value = list[i].ID.ToString()
                });
            };
            ViewData["CKID"] = new SelectList(select1, "Value", "Text", "");
            List<SelectListItem> select2 = new List<SelectListItem>();
            select2.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list2 = cbll.GetModelList(" Str1='3'");
            for (int i = 0; i < list2.Count; i++)
            {
                select2.Add(new SelectListItem
                {
                    Text = list2[i].CategoryName,
                    Value = list2[i].ID.ToString()
                });
            };
            ViewData["GHSID"] = new SelectList(select2, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.RRecord model = new DBA.Model.RRecord();
                model.CreateUserName = DBA.BLL.Users.GetNowUserName();

                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.RRecord model)
        {
            
            
                model.Time = DateTime.Now;
                DBA.Model.Goods Goods = bbll.GetModel(model.BookID);
                //model.CategoryID = Goods.CategoryID;
                //if (Goods.GoodsKC == null)
                //{
                //    Goods.GoodsKC = 0;
                //}
                //Goods.GoodsKC = Goods.GoodsKC + Convert.ToInt32(model.Str1);
                //bbll.Update(Goods);
            
            bll.Edit(model);
            return RedirectToAction("RRecordManage");

        }

        [HttpPost]
        public ActionResult YEdit(DBA.Model.RRecord model)
        {

            DBA.Model.Goods Goods = bbll.GetModelList(" ISBN='" + model.ISBN + "'").FirstOrDefault();
                if (Goods.GoodsKC == null)
                {
                    Goods.GoodsKC = 0;
                }
                Goods.GoodsKC = Goods.GoodsKC + Convert.ToInt32(model.Str1);
                Goods.GoodsKey = model.Str2;
                bbll.Update(Goods);
          
            DBA.Model.RRecord model2 = bll.GetModel(model.ID);
            model2.Str5 = "已批准";
            bll.Update(model2);
            return RedirectToAction("RRecordManage");

        }

        [HttpPost]
        public ActionResult NEdit(DBA.Model.RRecord model)
        {
           
            DBA.Model.RRecord model2 = bll.GetModel(model.ID);
            model2.Str5 = "审核未通过";
            bll.Update(model2);
            return RedirectToAction("RRecordManage");

        }

        [HttpPost]
        public JsonResult DelYJ(string ID)
        {

            DBA.Model.RRecord model2 = bll.GetModel(Convert.ToInt32(ID));
            model2.Str5 = "已处理";
            bll.Update(model2);
            return Json(true);
         

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult RRecordManage(Conris.DBA.ViewModel.RRecordSearch model)
        {
            return View(model);
        }

        public PartialViewResult RRecordSearch(Conris.DBA.ViewModel.RRecordSearch model)
        {
          
            return PartialView(model);
        }

        public PartialViewResult RRecordList(Conris.DBA.ViewModel.RRecordSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }

        public ActionResult YManage(Conris.DBA.ViewModel.RRecordSearch model)
        {
            bll.GetYJ();
            //model.Str5 = "保质预警";
            return View(model);
        }

        public PartialViewResult YSearch(Conris.DBA.ViewModel.RRecordSearch model)
        {

            return PartialView(model);
        }

        public PartialViewResult YList(Conris.DBA.ViewModel.RRecordSearch model)
        {
            return PartialView(bll.GetYJ());
        }
        public ActionResult RRecordCountManage(Conris.DBA.ViewModel.RRecordSearch model)
        {
            return View(model);
        }
        public PartialViewResult RRecordCountSearch(Conris.DBA.ViewModel.RRecordSearch model)
        {
            return PartialView(model);
        }
        public PartialViewResult RRecordCountList(Conris.DBA.ViewModel.RRecordSearch model)
        {
            return PartialView(bll.SearchProject2(model));
        }
    }
}
