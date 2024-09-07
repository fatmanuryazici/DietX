using DietX.DAL;
using DietX.DAL.Repositories;
using DietX.Entities.Entities;
using DietX.Entities.Entities.UserEntities;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DietX.BLL.UserMealReportBusinessService
{
    public class UserMealReportService : IUserMealReportService
    {
        public bool Add(UserMealReport userMealReport)
        {
            if (userMealReport == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.UserMealReportRepository.Add(userMealReport);
            if (result == null)
            {
                return false;
            }
            return true;
        }


        public bool Delete(int userId)
        {
            var result = UnitOfWork.Intance.UserMealReportRepository.Remove(userId);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public UserMealReport GetById(int userId)
        {
            return UnitOfWork.Intance.UserMealReportRepository.GetbyId(userId);
        }

        public bool Update(UserMealReport userMealReport)
        {
            if (userMealReport == null)
            {
                return false;
            }
            var result = UnitOfWork.Intance.UserMealReportRepository.Update(userMealReport);
            if (result == null)
            {
                return false;
            }
            return true;
        }
        public List<UserMealReport> GettAll()
        {
            return UnitOfWork.Intance.UserMealReportRepository.GetAll();
        }





        //Girilen tarihten önceki 30 gün içindeki yiyecekleri ve ilişkili öğünleri ve kategoriler
        public List<UserMealReport> GetMonthlyReport()
        {

            DateTime endDate = DateTime.Now.Date;
            DateTime startDate = endDate.AddMonths(-1);

            var reports = UserManager.CurrentUser.UserMealReports
            .Where(report => report.ConsumedDate >= startDate && report.ConsumedDate <= endDate)
                        .GroupBy(x => new { x.UserId, x.Meal })
                        .Select(g => new UserMealReport
                        {
                            UserId = g.Key.UserId,
                            Meal = g.Key.Meal,
                            TotalCalories = g.Sum(x => x.Food.Calorie),
                            TotalFat = g.Sum(x => x.Food.Fat),
                            TotalProtein = g.Sum(x => x.Food.Protein),
                            TotalCarbs = g.Sum(x => x.Food.Carbohydrate)
                        }).ToList();

            return reports;


            //DateTime endDate = DateTime.Now.Date;
            //DateTime startDate = endDate.AddMonths(-1);

            //var reports = UnitOfWork.Intance.UserMealReportRepository.GetAll()
            //            .Where(x => x.ConsumedDate <= startDate && x.ConsumedDate >= endDate)
            //            .GroupBy(x => new { x.UserId, x.Meal })
            //            .Select(g => new UserMealReport
            //            {
            //                UserId = g.Key.UserId,
            //                Meal = g.Key.Meal,
            //                TotalCalories = g.Sum(x => x.Food.Calorie),
            //                TotalFat = g.Sum(x => x.Food.Fat),
            //                TotalProtein = g.Sum(x => x.Food.Protein),
            //                TotalCarbs = g.Sum(x => x.Food.Carbohydrate)
            //            }).ToList();

            //return reports;
        }


        public List<UserMealReport> GetWeeklyReport(int userId)
        {
            DateTime endDate = DateTime.Now.Date;
            DateTime startDate = endDate.AddDays(-7);
            var reports = UserManager.CurrentUser.UserMealReports
            .Where(report => report.ConsumedDate >= startDate && report.ConsumedDate <= endDate)
                        .GroupBy(x => new { x.UserId, x.Food.CategoryId })
                        .Select(g => new UserMealReport
                        {
                            UserId = g.Key.UserId,
                            //FoodCategory = g.Key.CategoryId,
                            TotalCalories = g.Sum(x => x.Food.Calorie),
                            TotalFat = g.Sum(x => x.Food.Fat),
                            TotalProtein = g.Sum(x => x.Food.Protein),
                            TotalCarbs = g.Sum(x => x.Food.Carbohydrate)
                        }).ToList();

            return reports;



            //DateTime endDate = DateTime.Now.Date;
            //DateTime startDate = endDate.AddDays(-7); // Bir hafta önceki tarih

            //var userMealReports = UserManager.CurrentUser.UserMealReports
            //    .Where(report => report.ConsumedDate >= startDate && report.ConsumedDate <= endDate)
            //    .Select(report => new
            //    {
            //        MealName = report.Meal.Name.ToString(),
            //        Calories = report.Food.Calorie,
            //        Fat = report.Food.Fat,
            //        Protein = report.Food.Protein,
            //        Carbohydrate = report.Food.Carbohydrate
            //    })
            //    .ToList();

            //return userMealReports;
        }

        public bool CalculateTotalMealCalori(DateTime date, Meals meal)
        {
            if (date == null)
            {
                return false;
            }
            double totalmealCalori = UnitOfWork.Intance.UserMealReportRepository.GetAll()
                .Where(x => x.ConsumedDate ==date && x.Meal.Name == meal)
                .Sum(x => x.TotalCalories);
            if (totalmealCalori == null)
            {
                return false;
            }
            return true;
        }



        public bool TotalCalori(DateTime date)
        {
            if (date == null)
            {
                return false;
            }
            UnitOfWork.Intance.UserMealReportRepository.GetAll()
               .Where(x => x.ConsumedDate ==date)
               .Sum(x => x.TotalCalories);

            return true;
        }

        public bool TotalCarb(DateTime date)
        {
            if (date == null)
            {
                return false;
            }
            double totalCalori = UnitOfWork.Intance.UserMealReportRepository.GetAll()
                .Where(x => x.ConsumedDate ==date)
                .Sum(x => x.TotalCarbs);
            if (totalCalori == null)
            {
                return false;
            }
            return true;
        }

       
    }
}
