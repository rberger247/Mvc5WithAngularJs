using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Mvc;

namespace AngularJs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[HttpGet("/index")]
        public ActionResult Index()
        {
            return View();
        }
    }

 
  
}