using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webcontent.Models;
using Webcontent.Models.database;

namespace Webcontent.Service
{
    public class FoodService
    {
        public List<FoodModel> getFood()
        {
            List<FoodModel> result = new List<FoodModel>();

            using (var db = new TestEntities())
            {
                var temp = (from f in db.FOOD select f).ToList();
                result = temp.Select(s => new FoodModel
                {
                    ID = s.ID,
                    Name = myTrim(s.Name),
                    ImageSource = string.Concat("/Content/Image/ImageContent/") + s.ImageSource,
                    Catagory = myTrim(s.Catagory),
                    CatagoryNAme = findFullName(s.Catagory),
                    CreatedDateS = dateToString(s.CreatedDate),
                    CreatedBy = s.CreatedBy,
                    ModifiedDateS = dateToString(s.ModifiedDate),
                    ModifiedBy = s.ModifiedBy,
                }).ToList();
            }

            return result;
        }
        private string findFullName(String shortname)
        {
            string result = string.Empty;
            MasterService ser = new MasterService();
            if (!String.IsNullOrEmpty(shortname))
            {
                shortname = shortname.Trim();
                result = ser.getMenu().Where(w => myTrim(w.Shotname) == shortname.ToUpper()).Select(s => s.Name).FirstOrDefault();
            }
            return result;
        }
        private string dateToString(DateTime? date)
        {
            CultureInfo us = new CultureInfo("en-US");
            return date.HasValue ? date.Value.ToString("yyyy-MM-dd", us) : "-";
        }
        private string myTrim(String source)
        {
            return String.IsNullOrEmpty(source) ? null : source.Trim().ToUpper();
        }
    }
}