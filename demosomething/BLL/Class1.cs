using demosomething.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demosomething.BLL
{
    public class Class1
    {
        CrawlEntities db = new CrawlEntities();
        public List<Student> GetList()
        {
            List<Student> s = new List<Student>();
            s = db.Students.ToList();
            return s;
        }
    }
}