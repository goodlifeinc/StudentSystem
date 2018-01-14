using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemDbContext.Data.Repositories
{
    using System.Linq;

    public interface IRepository<T>
        where T : class
    {
        IQueryable<T> All();

        T Find(object id);

        void Add(T entity);

        void Update(T entity);

        T Delete(T entity);

        T Delete(object Id);

        int SaveChanges();
    }
}
