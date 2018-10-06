using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webcontent.Models;
using Webcontent.Models.database;

namespace Webcontent.Service
{
    public class MasterService
    {

        //    using(var db = new TestEntities())
        //{
        //}
        public List<Category> getMenu()
        {
            List<Category> result = new List<Category>();
            using (var db = new TestEntities())
            {
                result = (from ct in db.CATAGORY orderby ct.Sort select new Category { ID = ct.ID, Name = ct.Name, Shotname = ct.Shotname, CreateDate = ct.CreateDate, Path = ct.Path }).ToList();

                //result = db.CATAGORY.OrderBy(o=>o.Sort).Select(s => new Category
                //{
                //    ID = s.ID,
                //    Name = s.Name,
                //    Shotname = s.Shotname,
                //    CreateDate = s.CreateDate,
                //    Path = s.Path
                //}
                //).ToList();

            }
            return result;
        }

        //var dataset = Category.processlists
        //     .Select(x => new { x.ServerName, x.ProcessID, x.Username })
        //     .Cast<PInfo>().ToList();
    }
}
