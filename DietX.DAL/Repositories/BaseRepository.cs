using DietX.DAL.RepositoryInterfaces;
using DietX.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public T Add(T entity)
        {
            var entry = ApplicationDatabase.Context.Set<T>().Add(entity);
            ApplicationDatabase.Context.SaveChanges();
            return entry.Entity;
        }

        public List<T> GetAll()
        {
            return ApplicationDatabase.Context.Set<T>().Where(x => x.Status != Entities.Enums.Status.Deleted).ToList();
        }

        public T GetbyId(int id)
        {
            return ApplicationDatabase.Context.Set<T>().FirstOrDefault(x => x.Id== id && x.Status != Entities.Enums.Status.Deleted);
        }

        public T Remove(int id)
        {
            var entity = ApplicationDatabase.Context.Set<T>().Remove(GetbyId(id)).Entity;
            ApplicationDatabase.Context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            var entityResult = ApplicationDatabase.Context.Set<T>().Update(entity).Entity;
            ApplicationDatabase.Context.SaveChanges();
            return entityResult;
        }
    }
}
