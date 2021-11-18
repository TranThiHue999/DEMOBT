using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOBT.Areas.Admins.Controllers
{
    [Authorize(Roles ="Admin")]
    public class Home_AdController : Controller
    {
        // GET: Admins/Home_Ad
        public ActionResult Index()
        {
            return View();
        }
    }
}