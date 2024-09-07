using DietX.Entities.Entities.Base;
using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.Entities.Entities
{
    public class Meal :BaseEntity
    {
        public Meals Name { get; set; }

        //Nav Prop
        public virtual List<UserMealReport>? UserMealReports { get; set; }
    }
}
