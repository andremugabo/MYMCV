using MYMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYMVC.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Students> allStudents = new List<Students>();
            allStudents.Add(new Students(20000, "Munezero Ange", "Female",90));
            allStudents.Add(new Students(20001, "Munezero Ange1", "Female1",904));
            allStudents.Add(new Students(20002, "Munezero Ange2", "Female2",904));
            allStudents.Add(new Students(20003, "Munezero Ange3", "Female3",904));
            allStudents.Add(new Students(20004, "Munezero Ange4", "Female4",905));
            return View("Index",allStudents);
        }
    }
}