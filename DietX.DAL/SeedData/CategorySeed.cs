using DietX.DAL.AppDbContext;
using DietX.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.SeedData
{
    public static class CategorySeed
    {
        public static void AddCategorySeed(DietXDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }
            List<Category> categories = new List<Category>()
            {
              new Category { Name = "Breakfast" },
              new Category { Name = "Bakery Products" },
              new Category { Name = "Dairy Products " },
              new Category { Name = "Boiled Vegetables " },
              new Category { Name = "Snacks" },
              new Category { Name = "Fruit " },
              new Category { Name = "Alcohol" },
              new Category { Name = "Salads" },
              new Category { Name = "Fats" },
              new Category { Name = "Soups" },
              new Category { Name = "Vegetable Dishes" },
              new Category { Name = "Grain and Legume Dishes " },
              new Category { Name = "Poultry" },
              new Category { Name = "Meat Products" },
              new Category { Name = "Seafood " },
              new Category { Name = "Dessert " },
              new Category { Name = "Soft Drink " },
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
