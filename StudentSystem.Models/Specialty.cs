using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystemDbContext.Models
{
    public class Specialty
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Faculty Faculty { get; set; }

        public IEnumerable<Student> Students { get; set; }

        public IEnumerable<Lecturer> Lecturers { get; set; }
    }
}