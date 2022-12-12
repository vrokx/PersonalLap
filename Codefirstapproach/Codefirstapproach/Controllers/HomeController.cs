using Codefirstapproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirstapproach.Controllers
{
    public class HomeController : Controller
    {
       ShoppyDataContext db =new ShoppyDataContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.User.ToList();
            return View();
        }
    }
}