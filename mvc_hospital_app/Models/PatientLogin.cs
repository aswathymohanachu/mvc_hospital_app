using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_hospital_app.Models
{
    public class PatientLogin
    {
        [Required(ErrorMessage = "enter the username")]
        public string username { get; set; }
        [Required(ErrorMessage = "enter the password")]
        public string password { get; set; }
       
        public string msg { get; set; }
    }
}