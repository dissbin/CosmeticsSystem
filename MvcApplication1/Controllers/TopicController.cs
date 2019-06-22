using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class TopicController : Controller
    {
        //
        // GET: /Topic/
        DBA.BLL.Topic bll = new DBA.BLL.Topic();
        DBA.BLL.Category cbll = new DBA.BLL.Category();
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
            List<DBA.Model.Category> list = cbll.GetModelList("");
            for (int i = 0; i < list.Count; i++)
            {
                select1.Add(new SelectListItem
                {
                    Text = list[i].CategoryName,
                    Value = list[i].CategoryName
                });
            };
            ViewData["Category"] = new SelectList(select1, "Value", "Text", "");
            if (string.IsNullOrEmpty(ID))
            {
               DBA.Model.Topic  model= new DBA.Model.Topic();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));    
            }
           
        }

        public ActionResult TZ(string Title)
        {
            TempData["Title"] = Title;
            return View();
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Edit(DBA.Model.Topic model)
        {
            bll.Edit(model);
            return RedirectToAction("TopicManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        [HttpPost]
        public JsonResult WC(string ID)
        {
            DBA.Model.Topic model = bll.GetModel(Convert.ToInt32(ID));
            model.HTNum = "处理完成";
            bll.Update(model);
            return Json(true);

        }

        public ActionResult TopicManage(Conris.DBA.ViewModel.TopicSearch model)
        {
            return View(model);
        }

        public PartialViewResult TopicSearch(Conris.DBA.ViewModel.TopicSearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult TopicList(Conris.DBA.ViewModel.TopicSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
