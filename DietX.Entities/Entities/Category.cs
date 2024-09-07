using DietX.Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.Entities.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //Nav
        public virtual List<Food> Foods { get; set; }
    }
}
