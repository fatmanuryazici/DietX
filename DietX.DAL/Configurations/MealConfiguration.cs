using DietX.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Configurations
{
    public class MealConfiguration : BaseEntityConfiguration<Meal>
    {
        public override void Configure(EntityTypeBuilder<Meal> builder)
        {
            base.Configure(builder);
        }
    }
}
