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
    public class CategoryConfiguration : BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            base.Configure(builder);
        }
    }
}
