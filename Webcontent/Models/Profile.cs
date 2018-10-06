using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webcontent.Models
{
    public class Profile
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        public string lastname { get; set; }
        [Display(Name = "E-mail")]
        public string email { get; set; }
        [Display(Name = "User Name")]
        public string username { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Gender")]
        public string gender { get; set; }
    }
}