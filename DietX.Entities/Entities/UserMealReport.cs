using DietX.Entities.Entities.Base;
using DietX.Entities.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.Entities.Entities
{
    //Kişinin belirtilen tarihte belirtilen öğünde yediği şeyler 
    public class UserMealReport : BaseEntity
    {
        public DateTime ConsumedDate { get; set; }    // Yiyecek öğesinin tüketildiği tarih
        public double TotalMeasure { get; set; }
        public double TotalCalories { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public int CategoryId { get; set; }




        //Nav
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int FoodId { get; set; }
        public virtual Food? Food { get; set; }
        public int MealId { get; set; }
        public virtual Meal? Meal { get; set; }


    }
}
