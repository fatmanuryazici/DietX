using DietX.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.RepositoryInterfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        T Update(T entity);
        List<T> GetAll();
        T GetbyId(int id);
        T Remove(int id);
    }
}
