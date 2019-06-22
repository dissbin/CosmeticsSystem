using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class WarningController : Controller
    {
        //
        // GET: /Warning/
        DBA.BLL.Warning bll = new DBA.BLL.Warning();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Warning model = new DBA.Model.Warning();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }
        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Warning model)
        {
            bll.Edit(model);
            return RedirectToAction("WarningManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult WarningManage(Conris.DBA.ViewModel.WarningSearch model)
        {
            return View(model);
        }

        public PartialViewResult WarningSearch(Conris.DBA.ViewModel.WarningSearch model)
        {
          
            return PartialView(model);
        }

        public PartialViewResult WarningList(Conris.DBA.ViewModel.WarningSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
