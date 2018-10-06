using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webcontent.Models
{
    public class FoodModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string Catagory { get; set; }
        public string CatagoryNAme { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public String CreatedDateS { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public String ModifiedDateS { get; set; }
        public string ModifiedBy { get; set; }
    }
}