using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 心理咨询.Controllers
{
    public class JobNewsController : Controller
    {
        //
        // GET: /Job/
        DBA.BLL.JobNews bll = new DBA.BLL.JobNews();
        DBA.BLL.Users ubll = new DBA.BLL.Users();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
           
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.JobNews model = new DBA.Model.JobNews();
                model.CreateName = DateTime.Now.ToShortDateString();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        public ActionResult RCAP()
        {

                return View();          
        }

        public ActionResult KCreate(string ID,string Company)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.JobNews model = new DBA.Model.JobNews();
                model.CreateName = DateTime.Now.ToShortDateString();
                return View(model);
            }
            else
            {
                DBA.Model.JobNews model = new DBA.Model.JobNews();
                model.ID = Convert.ToInt32(ID);
                model.Company = Company;
                return View(model);
            }

        }

      

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(DBA.Model.JobNews model)
        {
            bll.Edit(model);
            return RedirectToAction("JobNewsManage");

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult REdit(DBA.Model.JobNews model)
        {
            bll.Edit(model);
            return RedirectToAction("RCManage");

        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));

        }

      

        public ActionResult JobNewsManage(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(model);
        }

        public PartialViewResult JobNewsSearch(Conris.DBA.ViewModel.JobNewsSearch model)
        {
           
            return PartialView(model);
        }

        public PartialViewResult JobNewsList(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }

        public ActionResult RCManage(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(model);
        }

        public PartialViewResult RCSearch(Conris.DBA.ViewModel.JobNewsSearch model)
        {
           
            return PartialView(model);
        }

        public PartialViewResult RCList(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return PartialView(bll.SearchProject2(model));
        }
    }
}
