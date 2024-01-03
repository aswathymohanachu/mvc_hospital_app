using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_hospital_app.Models
{
    public class PatientReg
    {

       [Required(ErrorMessage ="enter the name")]
        public string p_name { get; set; }
       [Range(18,50,ErrorMessage ="Enter the age b/w 18 to 50")]
        public int Age { get; set; }
        public string sex { get; set; }
        [Required(ErrorMessage = "enter the address")]
        public string address { get; set; }
        [Required(ErrorMessage = "enter the mobile number")]
        public long mob { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "enter the username")]
        public string username { get; set; }
        [Required(ErrorMessage = "enter the password")]
        public string password { get; set; }
        [Compare("password",ErrorMessage ="password mismatch")]
        public string conformpassword { get; set; }
        public string msg { get; set; }
    }
}