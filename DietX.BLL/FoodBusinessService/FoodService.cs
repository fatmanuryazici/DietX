using DietX.DAL;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.FoodBusinessService
{
    public class FoodService : IFoodService
    {
        public bool Add(Food food)
        {
            if (food == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.FoodRepository.Add(food);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int foodId)
        {
            var result = UnitOfWork.Intance.FoodRepository.Remove(foodId);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public Food GetById(int foodId)
        {
            return UnitOfWork.Intance.FoodRepository.GetbyId(foodId);
        }

        public List<Food> GettAll()
        {
            return UnitOfWork.Intance.FoodRepository.GetAll();
        }

        public bool Update(Food food)
        {
            if (food == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.FoodRepository.Update(food);
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
