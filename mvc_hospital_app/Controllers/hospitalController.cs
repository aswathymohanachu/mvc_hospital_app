using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_hospital_app.Controllers
{
    public class hospitalController : Controller
    {
        // GET: hospital
        public ActionResult Index()
        {
            return View();
        }
    }
}