using demosomething.BLL;
using demosomething.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demosomething.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            Class1 a = new Class1();
            List<Student> list = a.GetList();
            ViewBag.abc = list;
            return View();
        }
    }
}