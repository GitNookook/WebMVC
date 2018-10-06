using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webcontent.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Shotname { get; set; }
        public string Path { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}