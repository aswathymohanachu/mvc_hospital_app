using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_hospital_app.Models;

namespace mvc_hospital_app.Controllers
{
    public class DbLoginController : Controller
    {
        HOSPITALEntities dbobj = new HOSPITALEntities();
        // GET: DbLogin
        public ActionResult login_Pageload()
        {
            return View();
        }

        public ActionResult Login_Home()
        {
            return View();
        }
        public ActionResult login_Click(PatientLogin objcls)
        {

            if(ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.username, objcls.password, op);//get
                int val = Convert.ToInt32(op.Value);
                if(val==1)
                {
                    Session["uname"] = objcls.username;
                    return RedirectToAction("Login_Home");

                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "invalid login";
                    return View("login_Pageload",objcls);
                }
            }



            return View("login_Pageload", objcls);
        }




    }
}