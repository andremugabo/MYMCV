using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYMVC.Models
{
    public class Students
    {
        public int id { get; set; }
        public String studentName { get; set; }
        public String gender { get; set;}
        public float marks { get; set; }

        public Students()
        {
            id = -1;
            studentName = "No Name";
            gender = "Unspesfied";
            marks = 0;
        }

        public Students(int id,String studentName,String gender,float marks)
        {
            this.id = id;
            this.studentName = studentName;
            this.gender = gender;
            this.marks = marks;

        }
    }
}