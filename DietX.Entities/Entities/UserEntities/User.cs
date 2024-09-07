using DietX.Entities.Entities.Base;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.Entities.Entities.UserEntities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Nav
        public virtual List<UserMealReport> UserMealReports { get; set; }     // Kullanıcının tükettiği yiyecek öğeleri
    }
}
