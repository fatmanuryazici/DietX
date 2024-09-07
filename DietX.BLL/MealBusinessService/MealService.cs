using DietX.DAL;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.MealBusinessService
{
    public class MealService : IMealService
    {
        public bool Add(Meal meal)
        {
            if (meal == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.MealRepository.Add(meal);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int mealId)
        {
            var result = UnitOfWork.Intance.MealRepository.Remove(mealId);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public Meal GetById(int mealId)
        {
            return UnitOfWork.Intance.MealRepository.GetbyId(mealId);
        }

        public List<Meal> GettAll()
        {
            return UnitOfWork.Intance.MealRepository.GetAll();
        }

        public bool Update(Meal meal)
        {
            if (meal == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.MealRepository.Update(meal);
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
