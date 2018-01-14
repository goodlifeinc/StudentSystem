using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystemDbContext.Models
{
    public class Student : ApplicationUser
    {
        public int FacultyNumber { get; set; }

        public Specialty Specialty { get; set; }

        public Faculty Faculty { get; set; }

        public DiplomaWork DiplomaWork { get; set; }
    }
}