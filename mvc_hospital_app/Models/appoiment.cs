using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_hospital_app.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace mvc_hospital_app.Models
{
    public class appoiment
    {

        //public appoiment()
        //{
        //    apptimes = new List<SelectListItem>();
        //}
        //[DisplayName("Times")]
        //public List<SelectListItem> apptimes { get; set; }


        public TimeSpan SelectedId { get; set; }
        public IEnumerable<SelectListItem> Items { get; set; }

        public DateTime appdates { get; set; }
        public IEnumerable<SelectListItem> Item { get; set; }

        public int doctor { get; set; }
        public IEnumerable<SelectListItem> doc { get; set; }

        public int patientid { get; set; }
        //public DateTime appdate { get; set; }

        //public TimeSpan apptime { get; set; }

        //[Required(ErrorMessage = "enter valid id")]
        //public int docid{ get; set; }
        //[Required(ErrorMessage = "enter valid id")]
        //public int patientid { get; set; }

        public string msg { get; set; }




    }
}