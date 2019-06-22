using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        DBA.BLL.Users bll = new DBA.BLL.Users();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
               DBA.Model.Users  model= new DBA.Model.Users();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));    
            }
           
        }

        public ActionResult UCreate(string ID)
        {
            if (string.IsNullOrEmpty(ID))
            {
                DBA.Model.Users model = new DBA.Model.Users();
                return View(model);
            }
            else
            {
                return View(bll.GetModel(Convert.ToInt32(ID)));
            }

        }

        [HttpPost]
        public ActionResult Edit(DBA.Model.Users model,string ID)
        {
            
            DBA.Model.Users PoorUser = bll.GetModel(Convert.ToInt32(ID));
            DBA.BLL.RRecord Rbll = new DBA.BLL.RRecord();
            Rbll.UsersUpdate(PoorUser,model);
            bll.Edit(model);
            return RedirectToAction("UsersManage");

        }

        [HttpPost]
        public ActionResult UEdit(DBA.Model.Users model)
        {
            bll.Edit(model);
            return Redirect("/Users/UsersManage?UserType=客户");
        }

        [HttpPost]
        public JsonResult Del(string ID)
        {
            return Json(bll.Delete(Convert.ToInt32(ID)));
        }

        [HttpPost]
        public JsonResult GetUser(string Phone)
        {
            return Json(bll.GetModelList(" LoginName='"+Phone+"'").FirstOrDefault());

        }

        public ActionResult UsersManage(Conris.DBA.ViewModel.UsersSearch model)
        {
            return View(model);
        }

        public PartialViewResult UsersSearch(Conris.DBA.ViewModel.UsersSearch model)
        {
            return PartialView(model);
        }

        public PartialViewResult UsersList(Conris.DBA.ViewModel.UsersSearch model)
        {
            return PartialView(bll.SearchProject(model));
        }
    }
}
