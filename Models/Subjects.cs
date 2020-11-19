using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLG_DB.Models
{
    public class Subjects
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int TeacherID { get; set; }

        public virtual Teachers Teacher { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }

    }
}