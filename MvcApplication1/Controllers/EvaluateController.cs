using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class EvaluateController : Controller
    {
        //
        // GET: /Evaluate/
        DBA.BLL.Evaluate bll = new DBA.BLL.Evaluate();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID,string GHS,string GHSID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Evaluate model = new DBA.Model.Evaluate();
                model.GHS = GHS;
                model.GHSID = GHSID;
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }
        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Evaluate model)
        {
            bll.Edit(model);
            return Redirect("/Evaluate/EvaluateManage?GHSID="+model.GHSID);

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

        public ActionResult EvaluateManage(Conris.DBA.ViewModel.EvaluateSearch model)
        {
            return View(model);
        }

        public PartialViewResult EvaluateSearch(Conris.DBA.ViewModel.EvaluateSearch model)
        {
          
            return PartialView(model);
        }

        public PartialViewResult EvaluateList(Conris.DBA.ViewModel.EvaluateSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
