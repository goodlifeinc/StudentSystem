using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSystemDbContext.Models
{
    public class DiplomaWork
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public Student AssignedStudent { get; set; }
    }
}