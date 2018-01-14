using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystemDbContext.Data.Repositories;
using StudentSystemDbContext.Models;

namespace StudentSystemDbContext.Data
{
    public class StudentSystemData : IStudentSystemData
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public StudentSystemData()
            : this(new StudentSystemDbContextImpl())
        {
        }

        public StudentSystemData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Student> Students
        {
            get
            {
                return this.GetRepository<Student>();
            }
        }

        public IRepository<Lecturer> Lecturers => GetRepository<Lecturer>();

        public IRepository<Specialty> Specialties => GetRepository<Specialty>();

        public IRepository<Faculty> Faculties => GetRepository<Faculty>();

        public IRepository<DiplomaWork> DiplomaWorks => GetRepository<DiplomaWork>();

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>()
            where T : class
        {
            var typeOfRepository = typeof(T);

            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(EFRepository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.repositories[typeOfRepository];
        }
    }
}
