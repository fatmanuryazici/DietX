using DietX.DAL.Repositories;
using DietX.DAL.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL
{
    public class UnitOfWork
    {
        private static UnitOfWork intance;
        public static UnitOfWork Intance
        {
            get
            {
                if (intance == null)
                {
                    intance = new UnitOfWork();
                }

                return intance;
            }

        }

        public IFoodRepository FoodRepository
        {
            get
            {
                return new FoodRepository();
            }
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return new CategoryRepository();
            }
        }
        public IMealRepository MealRepository
        {
            get
            {
                return new MealRepository();
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return new UserRepository();
            }
        }

        public IUserMealReportRepository UserMealReportRepository
        {
            get
            {
                return new UserMealReportRepository();
            }
        }
    }
}
