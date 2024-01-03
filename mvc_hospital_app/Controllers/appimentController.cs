using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_hospital_app.Models;

namespace mvc_hospital_app.Controllers
{
    public class appimentController : Controller
    {

        HOSPITALEntities dbobj = new HOSPITALEntities();
        // GET: appiment
        public ActionResult appoiment_pageload()
        {

            return View();
        }
        public ActionResult Index()
        {
            var model = new appoiment
            {
                // preselect the second item which has value=2
                //SelectedId = "2",

                Items = new[]
                {
                    new SelectListItem { Value = "10:00:00", Text = "10:00:00" },
                    new SelectListItem { Value = "12:00:00", Text = "12:00:00" },
                    new SelectListItem { Value = "14:00:00", Text = "14:00:00" },
                    new SelectListItem { Value = "16:00:00", Text = "16:00:00" }
                },


                Item = new[]
                {
                 new SelectListItem { Value = "2023-12-31", Text = "2023-12-31" },
                 new SelectListItem { Value = "2023-12-1", Text = "2023-12-1" },
                 new SelectListItem { Value = "2023-12-22", Text = "2023-12-22" },
                 new SelectListItem { Value = "2023-12-6", Text = "2023-12-6" }
               },

                doc = new[]
                {
                 new SelectListItem { Value = "1", Text = "DR.ANANDHU" },
                 new SelectListItem { Value = "2", Text = "DR.RIYA" },
                 new SelectListItem { Value = "3", Text = "DR.HARISH" },
                 new SelectListItem { Value = "4", Text = "DR.DHRUV" }
               }





            };


            return View(model);
        }
        public ActionResult appoim_click(appoiment objcls)
        {
            if(ModelState.IsValid)
            {
                dbobj.sp_appoiment(objcls.appdates, objcls.SelectedId, objcls.doctor, objcls.patientid);
                    
                objcls.msg = "BOOKING COMPLETED";

                return RedirectToAction("appoiment_pageload", objcls);

              //  return View("Index", objcls);

            }
            return RedirectToAction("appoiment_pageload", objcls);
            //return View("Index", objcls);
            //return View("appoiment_pageload", objcls);
        }
        [HttpGet]
        public ActionResult Detail(idgets objcls)
        {

            var getdata = dbobj.sp_idgeting(Session["uname"].ToString()).FirstOrDefault();
            //return View(new idgets
            //{
            objcls.pid = getdata.patient_id;
            //}
            //);
          
            Session["id"] = objcls.pid;

            var getdatas = dbobj.sp_bookingdet(Convert.ToInt32(Session["id"])).FirstOrDefault();
            return View( new idgets
            {

                SelectedId = getdatas.app_time,
                appdates = getdatas.app_date,
                doctor = getdatas.doctor_id,
                pid = getdata.patient_id

            }
            );

            //return View();
        }
    }
}