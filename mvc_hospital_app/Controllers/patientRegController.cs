using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_hospital_app.Models;

namespace mvc_hospital_app.Controllers
{
    public class patientRegController : Controller
    {
        HOSPITALEntities dbobj = new HOSPITALEntities();
        // GET: patientReg
        public ActionResult insert_pageload()
        {
            return View();
        }
        public ActionResult insert_click(PatientReg objcls)
        {
            if (ModelState.IsValid)
            {
                dbobj.p_register(objcls.p_name, objcls.Age, objcls.sex, objcls.address, objcls.mob, objcls.email, objcls.username, objcls.password);

                objcls.msg = "successfully inserted";

                //  return RedirectToAction("DbLogin");
                ////  return View("DbLogin", objcls);
                return View("insert_pageload", objcls);

            }


            return View("insert_pageload", objcls);
        }
    }
}