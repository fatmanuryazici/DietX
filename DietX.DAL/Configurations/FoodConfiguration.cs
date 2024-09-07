using DietX.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Configurations
{
    public class FoodConfiguration : BaseEntityConfiguration<Food>
    {
        public override void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Calorie).IsRequired();
            builder.Property(x => x.Protein).IsRequired();
            builder.Property(x => x.Carbohydrate).IsRequired();
            builder.Property(x => x.Fat).IsRequired();
            builder.Property(x => x.Measure).IsRequired();

            base.Configure(builder);
        }
    }
}
