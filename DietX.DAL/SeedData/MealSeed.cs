using DietX.DAL.AppDbContext;
using DietX.Entities.Entities;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.SeedData
{
    public static class MealSeed
    {
        public static void AddMealSeed(DietXDbContext context)
        {
            if (context.Meals.Any())
            {
                return;
            }
            List<Meal> meals = new List<Meal>()
            {
                new Meal {Name = Meals.Breakfast },
                new Meal {Name = Meals.Dinner },
                new Meal {Name = Meals.Lunch},
                new Meal {Name = Meals.Snack},

            };
            context.Meals.AddRange(meals);
            context.SaveChanges();
        }
    }
}
