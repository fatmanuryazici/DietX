using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.CategoryBusinessService
{
    public interface ICategoryService
    {
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(int categoryId);
        Category GetById(int categoryId);
        List<Category> GettAll();
    }
}
