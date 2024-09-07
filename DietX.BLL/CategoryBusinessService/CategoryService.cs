using DietX.DAL;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.CategoryBusinessService
{
    public class CategoryService : ICategoryService
    {
        public bool Add(Category category)
        {
            if (category == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.CategoryRepository.Add(category);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int categoryId)
        {
            var result = UnitOfWork.Intance.CategoryRepository.Remove(categoryId);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public Category GetById(int categoryId)
        {
            return UnitOfWork.Intance.CategoryRepository.GetbyId(categoryId);
        }

        public List<Category> GettAll()
        {
            return UnitOfWork.Intance.CategoryRepository.GetAll();
        }

        public bool Update(Category category)
        {
            if (category == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.CategoryRepository.Update(category);
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
