using DietX.Entities.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.Configurations
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).IsRequired();

            base.Configure(builder);
        }
    }
}
