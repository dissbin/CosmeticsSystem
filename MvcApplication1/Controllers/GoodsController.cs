using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class GoodsController : Controller
    {
        //
        // GET: /Goods/
        DBA.BLL.Goods bll = new DBA.BLL.Goods();
        DBA.BLL.Category depbll = new DBA.BLL.Category();
        DBA.BLL.Warning wbll = new DBA.BLL.Warning();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list = depbll.GetModelList(" Str1='1'");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].CategoryName,
                    Value = list[i].ID.ToString()
                }); 
            };
            ViewData["CategoryID"] = new SelectList(select1, "Value", "Text", "");
            List<SelectListItem> select3 = new List<SelectListItem>();
            select3.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Warning> list3 = wbll.GetModelList(" 1=1");
            for (int i = 0; i < list3.Count; i++)
            {
                select3.Add(new SelectListItem
                {
                    Text = list3[i].WarnType + "（" + list3[i].Min + "-" + list3[i].Max + "）",
                    Value = list3[i].ID.ToString()
                });
            };
            ViewData["Str1"] = new SelectList(select3, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
               DBA.Model.Goods  model= new DBA.Model.Goods();
               model.Str1 = "";
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));    
            }
           
        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Goods model)
        {
            bll.Edit(model);
            return RedirectToAction("GoodsManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        [HttpPost]
        public JsonResult GetGoods(string ISBN)
        {
            return Json(bll.GetModelList(" ISBN='" + ISBN + "'"));

        }

        public ActionResult GoodsManage(Conris.DBA.ViewModel.GoodsSearch model)
        {
            return View(model);
        }

        public PartialViewResult GoodsSearch(Conris.DBA.ViewModel.GoodsSearch model)
        {
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list = depbll.GetModelList(" Str1='1'");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].CategoryName,
                    Value = list[i].ID.ToString()
                });
            };
            ViewData["CategoryID"] = new SelectList(select1, "Value", "Text", "");
            return PartialView(model);
        }

        public PartialViewResult GoodsList(Conris.DBA.ViewModel.GoodsSearch model)
        {
                return PartialView(bll.SearchProject(model));
        }

      

        public ActionResult YManage(Conris.DBA.ViewModel.GoodsSearch model)
        {
            return View(model);
        }

        public PartialViewResult YGoodsList(Conris.DBA.ViewModel.GoodsSearch model)
        {
                return PartialView(bll.SearchProject2(model));
        }

        public PartialViewResult YGoodsSearch(Conris.DBA.ViewModel.GoodsSearch model)
        {
            List<SelectListItem> select1 = new List<SelectListItem>();
            select1.Add(new SelectListItem
            {
                Text = "请选择",
                Value = ""
            });
            List<DBA.Model.Category> list = depbll.GetModelList("");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].CategoryName,
                    Value = list[i].ID.ToString()
                });
            };
            ViewData["CategoryID"] = new SelectList(select1, "Value", "Text", "");
            return PartialView(model);
        }
    }
}
