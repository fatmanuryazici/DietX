using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.MealBusinessService
{
    public interface IMealService
    {
        bool Add(Meal meal);
        bool Update(Meal meal);
        bool Delete(int mealId);
        Meal GetById(int mealId);
        List<Meal> GettAll();
    }
}
