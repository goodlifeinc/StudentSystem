using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystemDbContext.Models
{
    public class Lecturer : ApplicationUser
    {
        public String Title { get; set; }

        public Faculty Faculty { get; set; }

        public IEnumerable<Specialty> Specialty { get; set; }
    }
}