using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DBA.BLL.Users bll = new DBA.BLL.Users();
        DBA.BLL.JobNews jbll = new DBA.BLL.JobNews();
        public ActionResult Index()
        {
            List<DBA.Model.JobNews> list = jbll.GetModelList(" Category='热销新品'");
            return View(list);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string LoginName, string LoginPwd)
        {
            string IsLogin = bll.Login(LoginName, LoginPwd, false);
            return Json(IsLogin);
        }

        public ActionResult Detail(string ID)
        {
            return View(jbll.GetModel(Convert.ToInt32(ID)));
        }



        public ActionResult List(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(jbll.SearchProject(model));
        }



        public ActionResult CXList(Conris.DBA.ViewModel.JobNewsSearch model)
        {
            return View(jbll.SearchProject(model));
        }
        public ActionResult Regist()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetIndexNews(string flag, string Category)
        {
            List<DBA.Model.JobNews> List = jbll.GetModelList(Convert.ToInt32(flag), " Category='" + Category + "'", " ID desc");
            return Json(List);
        }


        [HttpPost]
        public JsonResult EditMM(string Old, string Newpsd)
        {
            string UserID = DBA.BLL.Users.GetNowUserID();
            DBA.Model.Users model = bll.GetModel(Convert.ToInt32(UserID));
            if (Old != model.LoginPSD.Trim())
            {
                return Json(false);
            }
            else
            {
                model.LoginPSD = Newpsd;
                bll.Update(model);
            
            }
            return Json(true);
        }

        [HttpPost]
        public JsonResult LogOff()
        {
            return Json(bll.LogOut());
        }
    }
}
