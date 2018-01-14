using StudentSystemDbContext.Data.Repositories;
using StudentSystemDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDbContext.Data
{
    public interface IStudentSystemData
    {
        IRepository<Student> Students { get; }

        IRepository<Lecturer> Lecturers { get; }

        IRepository<Specialty> Specialties { get; }

        IRepository<Faculty> Faculties { get; }

        IRepository<DiplomaWork> DiplomaWorks { get; }

        int SaveChanges();
    }
}
