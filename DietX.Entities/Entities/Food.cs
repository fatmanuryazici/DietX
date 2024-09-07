using DietX.Entities.Entities.Base;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.Entities.Entities
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
        public double Measure { get; set; }
        public PortionType PortionType { get; set; }
        public string Picture { get; set; }




        //Nav
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<UserMealReport> UserMealReports { get; set; }   //Tüketilen yiyecek öğeleri
    }
}
