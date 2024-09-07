using DietX.Entities.Entities;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.BLL.UserMealReportBusinessService
{
    public interface IUserMealReportService
    {
        bool Add(UserMealReport userMealReport);
        bool Update(UserMealReport userMealReport);
        bool Delete(int userId);
        UserMealReport GetById(int userId);
        List<UserMealReport> GettAll();
        List<UserMealReport> GetWeeklyReport(int userId);
        List<UserMealReport> GetMonthlyReport();
        bool TotalCalori(DateTime date);
        bool TotalCarb(DateTime date);
        bool CalculateTotalMealCalori(DateTime date, Meals meal);
    }
}
