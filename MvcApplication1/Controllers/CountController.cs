using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CountController : Controller
    {
        //
        // GET: /Count/
        DBA.BLL.Goods bll = new DBA.BLL.Goods();
        DBA.BLL.Category depbll = new DBA.BLL.Category();
        DBA.BLL.Warning wbll = new DBA.BLL.Warning();
        public ActionResult Index()
        {
            return View();
        }
        //public PartialViewResult CountList(Conris.DBA.ViewModel.CountSearch model)
        //{
        //    return PartialView(bll.SearchProject(model));
        //}
    }
}
