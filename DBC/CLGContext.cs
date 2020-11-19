using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CLG_DB.Models;

namespace CLG_DB.DBC
{
    public class CLGContext: DbContext
    {
        public CLGContext() : base("CLGContext")
        {
        }
        public  DbSet<Student> Students { get; set; }
        public DbSet<Color> Colors { get; set; }
        public  DbSet<Marks> Score { get; set; }
        public  DbSet<Teachers> Teacher { get; set; }
        public  DbSet<Subjects> Subject { get; set; }

    }
}