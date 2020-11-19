using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLG_DB.Models
{
    public class Student
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Branch { get; set; }
        public int Semester { get; set; }

        public virtual ICollection<Marks> Marks { get; set; }
    }

    
}