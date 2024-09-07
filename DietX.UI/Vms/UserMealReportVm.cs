using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.UI.Vms
{
    public class UserMealReportVm
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public string CategoryName { get; set; }
        public string FoodName { get; set; }
        public double TotalMeasure { get; set; }
        public double TotalCalories { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public DateTime ConsumedDate { get; set; }
        public string UserId { get; set; }
    }
}
