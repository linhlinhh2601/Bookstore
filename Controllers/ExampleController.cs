using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bookstore.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index(string name,int intnum =1)
        {
            ViewBag.Message = "Hello "+ name;
            ViewBag.intnum = intnum;
            return View();
        }
    }
}