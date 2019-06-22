using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
        DBA.BLL.Category bll = new DBA.BLL.Category();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
               DBA.Model.Category  model= new DBA.Model.Category();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));    
            }
           
        }

        public ActionResult CCreate(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Category model = new DBA.Model.Category();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        public ActionResult GCreate(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Category model = new DBA.Model.Category();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Category model)
        {
            bll.Edit(model);
            return RedirectToAction("CategoryManage");

        }

        [HttpPost]
        public ActionResult CEdit(DBA.Model.Category model)
        {
            bll.Edit(model);
            return RedirectToAction("CCategoryManage");

        }

        [HttpPost]
        public ActionResult GEdit(DBA.Model.Category model)
        {
            bll.Edit(model);
            return RedirectToAction("GCategoryManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult CategoryManage(Conris.DBA.ViewModel.CategorySearch model)
        {
            return View(model);
        }

        public PartialViewResult CategorySearch(Conris.DBA.ViewModel.CategorySearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult CategoryList(Conris.DBA.ViewModel.CategorySearch model)
        {
            return PartialView(bll.SearchProject(model));
        }

        public ActionResult CCategoryManage(Conris.DBA.ViewModel.CategorySearch model)
        {
            return View(model);
        }

        public PartialViewResult CCategorySearch(Conris.DBA.ViewModel.CategorySearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult CCategoryList(Conris.DBA.ViewModel.CategorySearch model)
        {
            return PartialView(bll.SearchProject2(model));
        }

        public ActionResult GCategoryManage(Conris.DBA.ViewModel.CategorySearch model)
        {
            return View(model);
        }

        public PartialViewResult GCategorySearch(Conris.DBA.ViewModel.CategorySearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult GCategoryList(Conris.DBA.ViewModel.CategorySearch model)
        {
            return PartialView(bll.SearchProject3(model));
        }
    }
}
