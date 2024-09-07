using DietX.DAL.AppDbContext;
using DietX.DAL.SeedData;
using DietX.UI.Forms;

namespace DietX.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            DietXDbContext context = new DietXDbContext();
            ApplicationConfiguration.Initialize();
            CategorySeed.AddCategorySeed(context);
            FoodSeed.AddFoodSeed(context);
            MealSeed.AddMealSeed(context);
            Application.Run(new Welcome());
        }
    }
}